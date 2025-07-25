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
    // [START networkservices_v1_generated_NetworkServices_CreateWasmPluginVersion_async_flattened_resourceNames]
    using Google.Cloud.NetworkServices.V1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedNetworkServicesClientSnippets
    {
        /// <summary>Snippet for CreateWasmPluginVersionAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task CreateWasmPluginVersionResourceNamesAsync()
        {
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            WasmPluginName parent = WasmPluginName.FromProjectLocationWasmPlugin("[PROJECT]", "[LOCATION]", "[WASM_PLUGIN]");
            WasmPluginVersion wasmPluginVersion = new WasmPluginVersion();
            string wasmPluginVersionId = "";
            // Make the request
            Operation<WasmPluginVersion, OperationMetadata> response = await networkServicesClient.CreateWasmPluginVersionAsync(parent, wasmPluginVersion, wasmPluginVersionId);

            // Poll until the returned long-running operation is complete
            Operation<WasmPluginVersion, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WasmPluginVersion result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WasmPluginVersion, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceCreateWasmPluginVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WasmPluginVersion retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END networkservices_v1_generated_NetworkServices_CreateWasmPluginVersion_async_flattened_resourceNames]
}
