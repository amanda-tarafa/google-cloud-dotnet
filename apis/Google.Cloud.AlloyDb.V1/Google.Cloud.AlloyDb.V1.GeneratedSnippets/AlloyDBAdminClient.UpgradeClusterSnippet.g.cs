// Copyright 2025 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace GoogleCSharpSnippets
{
    // [START alloydb_v1_generated_AlloyDBAdmin_UpgradeCluster_sync_flattened]
    using Google.Cloud.AlloyDb.V1;
    using Google.LongRunning;

    public sealed partial class GeneratedAlloyDBAdminClientSnippets
    {
        /// <summary>Snippet for UpgradeCluster</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void UpgradeCluster()
        {
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            DatabaseVersion version = DatabaseVersion.Unspecified;
            // Make the request
            Operation<UpgradeClusterResponse, OperationMetadata> response = alloyDBAdminClient.UpgradeCluster(name, version);

            // Poll until the returned long-running operation is complete
            Operation<UpgradeClusterResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UpgradeClusterResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UpgradeClusterResponse, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceUpgradeCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UpgradeClusterResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END alloydb_v1_generated_AlloyDBAdmin_UpgradeCluster_sync_flattened]
}
