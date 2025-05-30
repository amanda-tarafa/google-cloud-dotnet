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
    // [START domains_v1beta1_generated_Domains_ExportRegistration_sync_flattened_resourceNames]
    using Google.Cloud.Domains.V1Beta1;
    using Google.LongRunning;

    public sealed partial class GeneratedDomainsClientSnippets
    {
        /// <summary>Snippet for ExportRegistration</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void ExportRegistrationResourceNames()
        {
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            RegistrationName name = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]");
            // Make the request
            Operation<Registration, OperationMetadata> response = domainsClient.ExportRegistration(name);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = domainsClient.PollOnceExportRegistration(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END domains_v1beta1_generated_Domains_ExportRegistration_sync_flattened_resourceNames]
}
