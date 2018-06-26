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

using Google.Api.Gax.Rest;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Compute.v1;
using Google.Apis.Compute.v1.Data;
using Google.Apis.Services;
using Google.Cloud.BigQuery.V2;
using Google.Cloud.Bigtable.Admin.V2;
using System;
using System.Collections.Generic;
using System.Threading;
using BigTableInstance = Google.Cloud.Bigtable.Admin.V2.Instance;
using ComputeInstance = Google.Apis.Compute.v1.Data.Instance;

namespace TestProgram.Comparison
{
    public static class APIsComparisons
    {
        public const string ProjectID = "cloud-sharp-playground";

        public const string ComputeZoneID = "europe-west2-c";
        public const string ComputeInstanceID = "testing-instance";

        public const string BigQueryDatasetID = "testing_dataset";
        public const string BigQueryTableID = "testing_table";

        public const string BigTableInstanceID = "testing-instance";
        public const string BigTableZoneID = "europe-west1-b";

        private static readonly ScopedCredentialProvider _credentialProvider = new ScopedCredentialProvider(
            new[] {
                ComputeService.Scope.CloudPlatform
            });

        public async static void Run()
        {
            #region Simplest Client creation

            #region Compute (Apiary)
            GoogleCredential scopedCredentials = await _credentialProvider.GetCredentialsAsync(null).ConfigureAwait(false);
            BaseClientService.Initializer serviceInitializer = new BaseClientService.Initializer
            {
                HttpClientInitializer = scopedCredentials
            };
            ComputeService computeService = new ComputeService(serviceInitializer);
            Console.WriteLine("ComputeService created");
            #endregion

            #region BigQuery (Apiary wrapper)
            BigQueryClient bigQueryService = BigQueryClient.Create(ProjectID);
            Console.WriteLine("BigQueryService created");
            #endregion

            #region BigTable (GAPIC)
            BigtableInstanceAdminClient bigTableService = BigtableInstanceAdminClient.Create();
            Console.WriteLine("BigTableService created");
            #endregion

            #endregion

            #region Normal operation

            #region Compute
            InstancesResource.GetRequest getInstanceRequest = computeService.Instances.Get(ProjectID, ComputeZoneID, ComputeInstanceID);
            ComputeInstance computeInstance = getInstanceRequest.Execute();
            Console.WriteLine($"Compute instance of name {computeInstance.Name} gotten.");
            #endregion

            #region BigQuery
            BigQueryTable bigQueryTable = bigQueryService.GetTable(BigQueryDatasetID, BigQueryTableID);
            Console.WriteLine($"Big query table with ID {bigQueryTable.FullyQualifiedId} gotten.");
            #endregion

            #region BigTable
            InstanceName instanceName = new InstanceName(ProjectID, BigTableInstanceID);
            BigTableInstance bigTableInstance = bigTableService.GetInstance(instanceName);
            Console.WriteLine($"Big table instance of name {bigTableInstance.Name} gotten.");
            #endregion

            #endregion

            #region Long running operation

            #region Compute
            InstancesResource.ResetRequest resetRequest = computeService.Instances.Reset(ProjectID, ComputeZoneID, ComputeInstanceID);
            Console.WriteLine("Reseting compute instance ...");
            Operation resetOperation = resetRequest.Execute();
            while (resetOperation.Status != "DONE")
            {
                Thread.Sleep(250);
                ZoneOperationsResource.GetRequest getOperationRequest = computeService.ZoneOperations.Get(ProjectID, ComputeZoneID, resetOperation.Name);
                resetOperation = getOperationRequest.Execute();
            }
            Console.WriteLine("Compute instance reset");
            #endregion

            #region BigQuery
            Console.WriteLine("Starting query...");
            BigQueryJob queryJob = bigQueryService.CreateQueryJob($"select * from {bigQueryTable} limit 10", null);
            queryJob = queryJob.PollUntilCompleted();
            BigQueryResults queryResult = queryJob.GetQueryResults();
            Console.WriteLine($"Query returned {queryResult.TotalRows} results");
            #endregion

            #region BigTable
            Console.WriteLine("Creating BigTable cluster...");
            ProjectName projectName = new ProjectName(ProjectID);
            string clusterId = $"testing-cluster-{Guid.NewGuid().ToString().Substring(0, 10)}";
            Google.LongRunning.Operation<Cluster, CreateClusterMetadata> createClusterOperation
                = bigTableService.CreateCluster(instanceName, clusterId,
                new Cluster
                {
                    Location = $"projects/{ProjectID}/locations/{BigTableZoneID}",
                    ServeNodes = 3
                });
            createClusterOperation = createClusterOperation.PollUntilCompleted();
            Cluster createdCluster = createClusterOperation.Result;
            Console.WriteLine($"Big table create custer is completed {createClusterOperation.IsCompleted}");
            #endregion

            #endregion

            #region List operation

            #region Compute
            Console.WriteLine("Listing compute instances.");
            List<ComputeInstance> instances = new List<ComputeInstance>();
            string nextPageToken = null;
            do
            {
                InstancesResource.ListRequest listRequest = computeService.Instances.List(ProjectID, ComputeZoneID);
                listRequest.PageToken = nextPageToken;
                InstanceList instancesList = listRequest.Execute();
                instances.AddRange(instancesList.Items);
                nextPageToken = instancesList.NextPageToken;
            }
            while (nextPageToken != null);
            foreach (ComputeInstance ins in instances)
            {
                Console.WriteLine($"Compute instance retrieved {ins.Name}");
            }
            #endregion

            #region BigQuery
            Console.WriteLine("Listing bigquery jobs.");
            Google.Api.Gax.PagedEnumerable<Google.Apis.Bigquery.v2.Data.JobList, BigQueryJob> jobs
                = bigQueryService.ListJobs(new ListJobsOptions { StateFilter = JobState.Done });

            foreach (BigQueryJob job in jobs)
            {
                Console.WriteLine($"Big query job {job.Reference.JobId} listed");
            }
            #endregion

            #region BigTable
            Console.WriteLine("Listing bigquery profiles");
            Google.Api.Gax.PagedEnumerable<ListAppProfilesResponse, AppProfile> profiles
                = bigTableService.ListAppProfiles(bigTableInstance.InstanceName);
            foreach (AppProfile profile in profiles)
            {
                Console.WriteLine($"Big table profile {profile.Name}");
            }
            #endregion

            #endregion
        }
    }
}
