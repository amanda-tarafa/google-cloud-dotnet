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
using System.Threading;
using TestProgram.Comparison;

namespace TestProgram.Extensions
{
    /// <summary>
    /// This holds code similar to the one we'd need to generate if we were to go
    /// with tweaking the apiary codegen to offer more helpful functionality
    /// directly in the compute apiary client lib.
    /// This is a very initial prototype, if we don't decide to go with this option
    /// we don't need to expand on it further.
    /// </summary>
    public static class ComputeApiaryExtension
    {
        /// <summary>
        /// This method shows how usage of the improved apiary client lib would look like.
        /// </summary>
        public static void Run()
        {
            // Client creation (hiding credential obtention)
            ComputeService computeService = Create();
            Console.WriteLine("ComputeService created");

            // Normal operation (hiding request object)
            Instance instance = computeService.Instances.GetInstance(
                APIsComparisons.ProjectID, APIsComparisons.ComputeZoneID, APIsComparisons.ComputeInstanceID);
            Console.WriteLine($"Compute instance of name {instance.Name} gotten.");

            // Long running operation (entirely hiding polling)
            computeService.Instances.ResetInstance(
                APIsComparisons.ProjectID, APIsComparisons.ComputeZoneID, APIsComparisons.ComputeInstanceID);
            Console.WriteLine("Instance reset");

            // Long running operation (allowing client code to poll until completed at will)
            Operation operation = computeService.Instances.StartResetInstanceOperation(
                APIsComparisons.ProjectID, APIsComparisons.ComputeZoneID, APIsComparisons.ComputeInstanceID);
            computeService.ZoneOperations.PollUntilCompleted(APIsComparisons.ProjectID, APIsComparisons.ComputeZoneID,
                operation);
            Console.WriteLine("Instance reset");

            // List operation (hiding paging logic and returning an IEnumerable)
            IEnumerable<Instance> instances = computeService.Instances.ListInstances(
                APIsComparisons.ProjectID, APIsComparisons.ComputeZoneID);
            foreach (Instance ins in instances)
                Console.WriteLine(ins.Name);
        }

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
        /// Eases creation, hiding auth logic.
        /// Include also and async version that fetches credentials in an asyc manner.
        /// (This would be a static method generated on <see cref="ComputeService"/>)
        /// </summary>
        public static ComputeService Create(GoogleCredential credential = null)
        {
            GoogleCredential scopedCredentials = _credentialProvider.GetCredentials(credential);
            BaseClientService.Initializer serviceInitializer = new BaseClientService.Initializer
            {
                HttpClientInitializer = scopedCredentials
            };
            return new ComputeService(serviceInitializer);
        }

        /// <summary>
        /// This won't really be an extension method but a method generated on <see cref="InstancesResource"/>.
        /// I think that we can also add properties on <see cref="InstancesResource"/> to set
        /// project, zone, instance so that we can have overloads that don't receive these.
        /// For each resource type we can add these properties depending on what is included on the
        /// resource path.
        /// </summary>
        public static Instance GetInstance(this InstancesResource instances, string project, string zone, string instance)
        {
            InstancesResource.GetRequest getInstanceRequest = instances.Get(project, zone, instance);
            return getInstanceRequest.Execute();
        }

        /// <summary>
        /// This one is an example of a long running operation. The request has a body and also some query
        /// parameters which are exposed by <see cref="InstanceCreationOptions"/> which will generate.
        /// </summary>
        public static void CreateInstance(this InstancesResource instances, string project, string zone, Instance instance, InstanceCreationOptions options = null)
        {
            InstancesResource.InsertRequest insertRequest = instances.Insert(instance, project, zone);
            insertRequest.SourceInstanceTemplate = options?.SourceInstanceTemplate;
            insertRequest.RequestId = options?.RequestId;
            Operation insertOperation = insertRequest.Execute();

            // Since we would we adding this code on InstancesResource we would have access to the private client service
            // and the following lines of code wouldn't be neccessary, probably, adding them here to check that this works.
            var computeService = Create();
            insertOperation = computeService.ZoneOperations.PollUntilCompleted(project, zone, insertOperation);
            if (insertOperation.Error != null)
                throw new Exception("Errors occurred");
        }

        /// <summary>
        /// And we could also have the following.
        /// </summary>
        public static Operation StartCreateInstanceOperation(this InstancesResource instances, string project, string zone, Instance instance, InstanceCreationOptions options = null)
        {
            InstancesResource.InsertRequest insertRequest = instances.Insert(instance, project, zone);
            insertRequest.SourceInstanceTemplate = options?.SourceInstanceTemplate;
            insertRequest.RequestId = options?.RequestId;
            return insertRequest.Execute();
        }

        public class InstanceCreationOptions
        {
            public string SourceInstanceTemplate { get; set; }
            public string RequestId { get; set; }
        }

        public static void ResetInstance(this InstancesResource instances, string project, string zone, string instance)
        {
            InstancesResource.ResetRequest resetRequest = instances.Reset(project, zone, instance);
            Operation resetOperation = resetRequest.Execute();

            // Since we would we adding this code on InstancesResource we would have access to the private client service
            // and the following lines of code wouldn't be neccessary, probably, adding them here to check that this works.
            var computeService = Create();
            resetOperation = computeService.ZoneOperations.PollUntilCompleted(project, zone, resetOperation);
            if (resetOperation.Error != null)
                throw new Exception("Errors occurred");
        }

        public static Operation StartResetInstanceOperation(this InstancesResource instances, string project, string zone, string instance)
        {
            InstancesResource.ResetRequest resetRequest = instances.Reset(project, zone, instance);
            return resetRequest.Execute();
        }

        public static Operation PollUntilCompleted(this ZoneOperationsResource zoneOperations, string project, string zone, Operation operation)
        {
            if (operation.Zone == null)
                throw new ArgumentException("Not a zone operation");

            return Polling.PollRepeatedly(
                ignoredDeadline =>
                {
                    ZoneOperationsResource.GetRequest getOperationRequest = zoneOperations.Get(project, zone, operation.Name);
                    return getOperationRequest.Execute();
                },
                oper => oper.Status != "DONE",
                SystemClock.Instance, SystemScheduler.Instance,
                new PollSettings(Expiration.None, TimeSpan.FromSeconds(5)),
                CancellationToken.None);
        }

        public static IEnumerable<Instance> ListInstances(this InstancesResource instances, string project, string zone)
        {
            var pageManager = new InstancePageManager();
            return new RestPagedEnumerable<InstancesResource.ListRequest, InstanceList, Instance>(
                () => instances.List(project, zone),
                pageManager);
        }

        private class InstancePageManager : IPageManager<InstancesResource.ListRequest, InstanceList, Instance>
        {
            public string GetNextPageToken(InstanceList response) => response?.NextPageToken;

            public IEnumerable<Instance> GetResources(InstanceList response) => response?.Items;

            public void SetPageSize(InstancesResource.ListRequest request, int pageSize) => request.MaxResults = pageSize;

            public void SetPageToken(InstancesResource.ListRequest request, string pageToken) => request.PageToken = pageToken;
        }
    }
}
