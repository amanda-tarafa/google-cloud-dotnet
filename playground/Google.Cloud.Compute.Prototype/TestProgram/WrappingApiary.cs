// Copyright 2018 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Google.Api.Gax.Rest;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Compute.v1;
using Google.Apis.Compute.v1.Data;
using Google.Apis.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using TestProgram.Comparison;

namespace TestProgram.Wrapping
{
    public static class WrappingApiary
    {
        /// <summary>
        /// This method shows how usage of the apiary client wrapper would look like
        /// </summary>
        public static void Run()
        {
            // Client creation (hiding credential obtention)
            ComputeClient computeClient = ComputeClient.Create();
            Console.WriteLine("ComputeService created");

            computeClient.Project = APIsComparisons.ProjectID;
            computeClient.Instances.Zone = APIsComparisons.ComputeZoneID;

            // Normal operation (hiding request object) (using the project and zone set)
            Instance instance = computeClient.Instances.GetInstance(APIsComparisons.ComputeInstanceID);
            Console.WriteLine($"Compute instance of name {instance.Name} gotten.");

            // Long running operation (entirely hiding polling) (using the project and zone set)
            computeClient.Instances.ResetInstance(APIsComparisons.ComputeInstanceID);
            Console.WriteLine("Instance reset");

            // Unsetting to test overload that receives these
            computeClient.Project = null;
            computeClient.Instances.Zone = null;

            // Long running operation (allowing client code to poll until completed at will)
            Operation operation = computeClient.Instances.StartResetInstanceOperation(
                APIsComparisons.ProjectID, APIsComparisons.ComputeZoneID, APIsComparisons.ComputeInstanceID);
            computeClient.Operations.PollUntilCompleted(APIsComparisons.ProjectID, operation);
            Console.WriteLine("Instance reset");

            // List operation (hiding paging logic and returning an IEnumerable)
            IEnumerable<Instance> instances = computeClient.Instances.ListInstances(
                APIsComparisons.ProjectID, APIsComparisons.ComputeZoneID);
            foreach (Instance ins in instances)
                Console.WriteLine(ins.Name);
        }
    }

    public class ComputeClient
    {
        private static readonly ScopedCredentialProvider _credentialProvider = new ScopedCredentialProvider(
            new[] {
                ComputeService.Scope.ComputeReadonly,
                ComputeService.Scope.Compute,
                ComputeService.Scope.DevstorageReadOnly,
                ComputeService.Scope.DevstorageReadWrite,
                ComputeService.Scope.DevstorageFullControl,
                ComputeService.Scope.CloudPlatform
            });

        /// <summary>
        /// We can have this and have overloads that receive a Project id and others that don't
        /// receive a project id and use this one.
        /// </summary>
        public string Project { get; set; }
        public ComputeService InternalService { get; }

        public InstacesRepo Instances { get; }
        public OperationsRepo Operations { get; }

        internal ComputeClient(ComputeService client)
        {
            InternalService = client;
            Instances = new InstacesRepo(this);
            Operations = new OperationsRepo(this);
        }

        public static ComputeClient Create(GoogleCredential credential = null)
        {
            GoogleCredential scopedCredentials = _credentialProvider.GetCredentials(credential);
            BaseClientService.Initializer serviceInitializer = new BaseClientService.Initializer
            {
                HttpClientInitializer = scopedCredentials
            };
            return new ComputeClient(new ComputeService(serviceInitializer));
        }
    }

    /// <summary>
    /// For lack of a better name.
    /// On this prototype I'm writing one repo per original resource
    /// but maybe we might consider grouping resources via a config file
    /// into more business meaningful repos?
    /// </summary>
    public class InstacesRepo
    {
        public ComputeClient Client { get; }

        /// <summary>
        /// In each of the repos we might allow to set the IDs that make the most
        /// sense for the operations. It might be that Zone is used everywhere and makes
        /// more sense to add it to ComputeClient.
        /// </summary>
        public string Zone { get; set; }

        internal InstacesRepo(ComputeClient client)
        {
            Client = client;
        }

        /// <summary>
        /// We can have overloads that use the project and zone set on the client or the repo.
        /// </summary>
        /// <returns></returns>
        public Instance GetInstance(string instance)
        {
            return GetInstance(Client.Project, Zone, instance);
        }

        public Instance GetInstance(string project, string zone, string instance)
        {
            InstancesResource.GetRequest getInstanceRequest = Client.InternalService.Instances.Get(project, zone, instance);
            return getInstanceRequest.Execute();
        }

        /// <summary>
        /// This one is an example of a long running operation. The request has a body and also some query
        /// parameters which are exposed by <see cref="InstanceCreationOptions"/> which will generate.
        /// Also, depending up to what point we want to get in the balance generated/manually written,
        /// we can have methods like these that take care of creating all the nested resources, for instance,
        /// for creating an instance a disk needs to be created before hand.
        /// </summary>
        public void CreateInstance(string project, string zone, Instance instance, InstanceCreationOptions options = null)
        {
            InstancesResource.InsertRequest insertRequest = Client.InternalService.Instances.Insert(instance, project, zone);
            insertRequest.SourceInstanceTemplate = options?.SourceInstanceTemplate;
            insertRequest.RequestId = options?.RequestId;
            Operation insertOperation = insertRequest.Execute();


            insertOperation = Client.Operations.PollUntilCompleted(project, insertOperation);
            if (insertOperation.Error != null)
                throw new Exception("Errors occurred");
        }

        public void CreateInstance(Instance instance, InstanceCreationOptions options = null)
        {
            CreateInstance(Client.Project, Zone, instance, options);
        }

        /// <summary>
        /// And we could also have the following.
        /// </summary>
        public Operation StartCreateInstanceOperation(string project, string zone, Instance instance, InstanceCreationOptions options = null)
        {
            InstancesResource.InsertRequest insertRequest = Client.InternalService.Instances.Insert(instance, project, zone);
            insertRequest.SourceInstanceTemplate = options?.SourceInstanceTemplate;
            insertRequest.RequestId = options?.RequestId;
            return insertRequest.Execute();
        }

        public Operation StartCreateInstanceOperation(Instance instance, InstanceCreationOptions options = null)
        {
            return StartCreateInstanceOperation(Client.Project, Zone, instance, options);
        }

        public class InstanceCreationOptions
        {
            public string SourceInstanceTemplate { get; set; }
            public string RequestId { get; set; }
        }

        public void ResetInstance(string project, string zone, string instance)
        {
            InstancesResource.ResetRequest resetRequest = Client.InternalService.Instances.Reset(project, zone, instance);
            Operation resetOperation = resetRequest.Execute();

            resetOperation = Client.Operations.PollUntilCompleted(project, resetOperation);
            if (resetOperation.Error != null)
                throw new Exception("Errors occurred");
        }

        public void ResetInstance(string instance)
        {
            ResetInstance(Client.Project, Zone, instance);
        }

        public Operation StartResetInstanceOperation(string project, string zone, string instance)
        {
            InstancesResource.ResetRequest resetRequest = Client.InternalService.Instances.Reset(project, zone, instance);
            return resetRequest.Execute();
        }

        public IEnumerable<Instance> ListInstances(string project, string zone)
        {
            var pageManager = new InstancePageManager();
            return new RestPagedEnumerable<InstancesResource.ListRequest, InstanceList, Instance>(
                () => Client.InternalService.Instances.List(project, zone),
                pageManager);
        }

        public IEnumerable<Instance> ListInstances()
        {
            return ListInstances(Client.Project, Zone);
        }

        private class InstancePageManager : IPageManager<InstancesResource.ListRequest, InstanceList, Instance>
        {
            public string GetNextPageToken(InstanceList response) => response?.NextPageToken;

            public IEnumerable<Instance> GetResources(InstanceList response) => response?.Items;

            public void SetPageSize(InstancesResource.ListRequest request, int pageSize) => request.MaxResults = pageSize;

            public void SetPageToken(InstancesResource.ListRequest request, string pageToken) => request.PageToken = pageToken;
        }
    }

    public class OperationsRepo
    {
        public ComputeClient Client { get; }

        internal OperationsRepo(ComputeClient client)
        {
            Client = client;
        }

        public Operation PollUntilCompleted(Operation operation)
        {
            return PollUntilCompleted(Client.Project, operation);
        }

        public Operation PollUntilCompleted(string project, Operation operation)
        {
            string region = LassPathPart(operation.Region);
            string zone = LassPathPart(operation.Zone);

            Func<Operation> operationRefresh;
            if (region != null)
            {
                operationRefresh = () =>
                {
                    RegionOperationsResource.GetRequest getOperationRequest = Client.InternalService.RegionOperations.Get(project, region, operation.Name);
                    return getOperationRequest.Execute();
                };
            }
            else if (zone != null)
            {
                operationRefresh = () =>
                {
                    ZoneOperationsResource.GetRequest getOperationRequest = Client.InternalService.ZoneOperations.Get(project, zone, operation.Name);
                    return getOperationRequest.Execute();
                };
            }
            else
            {
                operationRefresh = () =>
                {
                    GlobalOperationsResource.GetRequest getOperationRequest = Client.InternalService.GlobalOperations.Get(project, operation.Name);
                    return getOperationRequest.Execute();
                };
            }

            return Polling.PollRepeatedly(
                ignoredDeadline => operationRefresh(),
                oper => oper.Status != "DONE",
                SystemClock.Instance, SystemScheduler.Instance,
                new PollSettings(Expiration.None, TimeSpan.FromSeconds(5)),
                CancellationToken.None);
        }

        private static string LassPathPart(string path)
        {
            if (path == null)
                return null;
            return (from part in path?.Split('/')
                    select part).LastOrDefault();
        }
    }
}
