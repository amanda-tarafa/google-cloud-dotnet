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
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.NetworkServices.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedNetworkServicesClientSnippets
    {
        /// <summary>Snippet for ListEndpointPolicies</summary>
        public void ListEndpointPoliciesRequestObject()
        {
            // Snippet: ListEndpointPolicies(ListEndpointPoliciesRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            ListEndpointPoliciesRequest request = new ListEndpointPoliciesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<ListEndpointPoliciesResponse, EndpointPolicy> response = networkServicesClient.ListEndpointPolicies(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EndpointPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEndpointPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EndpointPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EndpointPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EndpointPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEndpointPoliciesAsync</summary>
        public async Task ListEndpointPoliciesRequestObjectAsync()
        {
            // Snippet: ListEndpointPoliciesAsync(ListEndpointPoliciesRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            ListEndpointPoliciesRequest request = new ListEndpointPoliciesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<ListEndpointPoliciesResponse, EndpointPolicy> response = networkServicesClient.ListEndpointPoliciesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EndpointPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEndpointPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EndpointPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EndpointPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EndpointPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEndpointPolicies</summary>
        public void ListEndpointPolicies()
        {
            // Snippet: ListEndpointPolicies(string, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListEndpointPoliciesResponse, EndpointPolicy> response = networkServicesClient.ListEndpointPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EndpointPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEndpointPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EndpointPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EndpointPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EndpointPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEndpointPoliciesAsync</summary>
        public async Task ListEndpointPoliciesAsync()
        {
            // Snippet: ListEndpointPoliciesAsync(string, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListEndpointPoliciesResponse, EndpointPolicy> response = networkServicesClient.ListEndpointPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EndpointPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEndpointPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EndpointPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EndpointPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EndpointPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEndpointPolicies</summary>
        public void ListEndpointPoliciesResourceNames()
        {
            // Snippet: ListEndpointPolicies(LocationName, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListEndpointPoliciesResponse, EndpointPolicy> response = networkServicesClient.ListEndpointPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EndpointPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEndpointPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EndpointPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EndpointPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EndpointPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEndpointPoliciesAsync</summary>
        public async Task ListEndpointPoliciesResourceNamesAsync()
        {
            // Snippet: ListEndpointPoliciesAsync(LocationName, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListEndpointPoliciesResponse, EndpointPolicy> response = networkServicesClient.ListEndpointPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EndpointPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEndpointPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EndpointPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EndpointPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EndpointPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetEndpointPolicy</summary>
        public void GetEndpointPolicyRequestObject()
        {
            // Snippet: GetEndpointPolicy(GetEndpointPolicyRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            GetEndpointPolicyRequest request = new GetEndpointPolicyRequest
            {
                EndpointPolicyName = EndpointPolicyName.FromProjectLocationEndpointPolicy("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]"),
            };
            // Make the request
            EndpointPolicy response = networkServicesClient.GetEndpointPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetEndpointPolicyAsync</summary>
        public async Task GetEndpointPolicyRequestObjectAsync()
        {
            // Snippet: GetEndpointPolicyAsync(GetEndpointPolicyRequest, CallSettings)
            // Additional: GetEndpointPolicyAsync(GetEndpointPolicyRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            GetEndpointPolicyRequest request = new GetEndpointPolicyRequest
            {
                EndpointPolicyName = EndpointPolicyName.FromProjectLocationEndpointPolicy("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]"),
            };
            // Make the request
            EndpointPolicy response = await networkServicesClient.GetEndpointPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEndpointPolicy</summary>
        public void GetEndpointPolicy()
        {
            // Snippet: GetEndpointPolicy(string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/endpointPolicies/[ENDPOINT_POLICY]";
            // Make the request
            EndpointPolicy response = networkServicesClient.GetEndpointPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetEndpointPolicyAsync</summary>
        public async Task GetEndpointPolicyAsync()
        {
            // Snippet: GetEndpointPolicyAsync(string, CallSettings)
            // Additional: GetEndpointPolicyAsync(string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/endpointPolicies/[ENDPOINT_POLICY]";
            // Make the request
            EndpointPolicy response = await networkServicesClient.GetEndpointPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEndpointPolicy</summary>
        public void GetEndpointPolicyResourceNames()
        {
            // Snippet: GetEndpointPolicy(EndpointPolicyName, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            EndpointPolicyName name = EndpointPolicyName.FromProjectLocationEndpointPolicy("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]");
            // Make the request
            EndpointPolicy response = networkServicesClient.GetEndpointPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetEndpointPolicyAsync</summary>
        public async Task GetEndpointPolicyResourceNamesAsync()
        {
            // Snippet: GetEndpointPolicyAsync(EndpointPolicyName, CallSettings)
            // Additional: GetEndpointPolicyAsync(EndpointPolicyName, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            EndpointPolicyName name = EndpointPolicyName.FromProjectLocationEndpointPolicy("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]");
            // Make the request
            EndpointPolicy response = await networkServicesClient.GetEndpointPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateEndpointPolicy</summary>
        public void CreateEndpointPolicyRequestObject()
        {
            // Snippet: CreateEndpointPolicy(CreateEndpointPolicyRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            CreateEndpointPolicyRequest request = new CreateEndpointPolicyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EndpointPolicyId = "",
                EndpointPolicy = new EndpointPolicy(),
            };
            // Make the request
            Operation<EndpointPolicy, OperationMetadata> response = networkServicesClient.CreateEndpointPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<EndpointPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            EndpointPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EndpointPolicy, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceCreateEndpointPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EndpointPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEndpointPolicyAsync</summary>
        public async Task CreateEndpointPolicyRequestObjectAsync()
        {
            // Snippet: CreateEndpointPolicyAsync(CreateEndpointPolicyRequest, CallSettings)
            // Additional: CreateEndpointPolicyAsync(CreateEndpointPolicyRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            CreateEndpointPolicyRequest request = new CreateEndpointPolicyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EndpointPolicyId = "",
                EndpointPolicy = new EndpointPolicy(),
            };
            // Make the request
            Operation<EndpointPolicy, OperationMetadata> response = await networkServicesClient.CreateEndpointPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<EndpointPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            EndpointPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EndpointPolicy, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceCreateEndpointPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EndpointPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEndpointPolicy</summary>
        public void CreateEndpointPolicy()
        {
            // Snippet: CreateEndpointPolicy(string, EndpointPolicy, string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            EndpointPolicy endpointPolicy = new EndpointPolicy();
            string endpointPolicyId = "";
            // Make the request
            Operation<EndpointPolicy, OperationMetadata> response = networkServicesClient.CreateEndpointPolicy(parent, endpointPolicy, endpointPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<EndpointPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            EndpointPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EndpointPolicy, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceCreateEndpointPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EndpointPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEndpointPolicyAsync</summary>
        public async Task CreateEndpointPolicyAsync()
        {
            // Snippet: CreateEndpointPolicyAsync(string, EndpointPolicy, string, CallSettings)
            // Additional: CreateEndpointPolicyAsync(string, EndpointPolicy, string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            EndpointPolicy endpointPolicy = new EndpointPolicy();
            string endpointPolicyId = "";
            // Make the request
            Operation<EndpointPolicy, OperationMetadata> response = await networkServicesClient.CreateEndpointPolicyAsync(parent, endpointPolicy, endpointPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<EndpointPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            EndpointPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EndpointPolicy, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceCreateEndpointPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EndpointPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEndpointPolicy</summary>
        public void CreateEndpointPolicyResourceNames()
        {
            // Snippet: CreateEndpointPolicy(LocationName, EndpointPolicy, string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            EndpointPolicy endpointPolicy = new EndpointPolicy();
            string endpointPolicyId = "";
            // Make the request
            Operation<EndpointPolicy, OperationMetadata> response = networkServicesClient.CreateEndpointPolicy(parent, endpointPolicy, endpointPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<EndpointPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            EndpointPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EndpointPolicy, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceCreateEndpointPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EndpointPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEndpointPolicyAsync</summary>
        public async Task CreateEndpointPolicyResourceNamesAsync()
        {
            // Snippet: CreateEndpointPolicyAsync(LocationName, EndpointPolicy, string, CallSettings)
            // Additional: CreateEndpointPolicyAsync(LocationName, EndpointPolicy, string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            EndpointPolicy endpointPolicy = new EndpointPolicy();
            string endpointPolicyId = "";
            // Make the request
            Operation<EndpointPolicy, OperationMetadata> response = await networkServicesClient.CreateEndpointPolicyAsync(parent, endpointPolicy, endpointPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<EndpointPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            EndpointPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EndpointPolicy, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceCreateEndpointPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EndpointPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEndpointPolicy</summary>
        public void UpdateEndpointPolicyRequestObject()
        {
            // Snippet: UpdateEndpointPolicy(UpdateEndpointPolicyRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            UpdateEndpointPolicyRequest request = new UpdateEndpointPolicyRequest
            {
                UpdateMask = new FieldMask(),
                EndpointPolicy = new EndpointPolicy(),
            };
            // Make the request
            Operation<EndpointPolicy, OperationMetadata> response = networkServicesClient.UpdateEndpointPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<EndpointPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            EndpointPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EndpointPolicy, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceUpdateEndpointPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EndpointPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEndpointPolicyAsync</summary>
        public async Task UpdateEndpointPolicyRequestObjectAsync()
        {
            // Snippet: UpdateEndpointPolicyAsync(UpdateEndpointPolicyRequest, CallSettings)
            // Additional: UpdateEndpointPolicyAsync(UpdateEndpointPolicyRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            UpdateEndpointPolicyRequest request = new UpdateEndpointPolicyRequest
            {
                UpdateMask = new FieldMask(),
                EndpointPolicy = new EndpointPolicy(),
            };
            // Make the request
            Operation<EndpointPolicy, OperationMetadata> response = await networkServicesClient.UpdateEndpointPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<EndpointPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            EndpointPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EndpointPolicy, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceUpdateEndpointPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EndpointPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEndpointPolicy</summary>
        public void UpdateEndpointPolicy()
        {
            // Snippet: UpdateEndpointPolicy(EndpointPolicy, FieldMask, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            EndpointPolicy endpointPolicy = new EndpointPolicy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<EndpointPolicy, OperationMetadata> response = networkServicesClient.UpdateEndpointPolicy(endpointPolicy, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<EndpointPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            EndpointPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EndpointPolicy, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceUpdateEndpointPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EndpointPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEndpointPolicyAsync</summary>
        public async Task UpdateEndpointPolicyAsync()
        {
            // Snippet: UpdateEndpointPolicyAsync(EndpointPolicy, FieldMask, CallSettings)
            // Additional: UpdateEndpointPolicyAsync(EndpointPolicy, FieldMask, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            EndpointPolicy endpointPolicy = new EndpointPolicy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<EndpointPolicy, OperationMetadata> response = await networkServicesClient.UpdateEndpointPolicyAsync(endpointPolicy, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<EndpointPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            EndpointPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EndpointPolicy, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceUpdateEndpointPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EndpointPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEndpointPolicy</summary>
        public void DeleteEndpointPolicyRequestObject()
        {
            // Snippet: DeleteEndpointPolicy(DeleteEndpointPolicyRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            DeleteEndpointPolicyRequest request = new DeleteEndpointPolicyRequest
            {
                EndpointPolicyName = EndpointPolicyName.FromProjectLocationEndpointPolicy("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = networkServicesClient.DeleteEndpointPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceDeleteEndpointPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEndpointPolicyAsync</summary>
        public async Task DeleteEndpointPolicyRequestObjectAsync()
        {
            // Snippet: DeleteEndpointPolicyAsync(DeleteEndpointPolicyRequest, CallSettings)
            // Additional: DeleteEndpointPolicyAsync(DeleteEndpointPolicyRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteEndpointPolicyRequest request = new DeleteEndpointPolicyRequest
            {
                EndpointPolicyName = EndpointPolicyName.FromProjectLocationEndpointPolicy("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkServicesClient.DeleteEndpointPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceDeleteEndpointPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEndpointPolicy</summary>
        public void DeleteEndpointPolicy()
        {
            // Snippet: DeleteEndpointPolicy(string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/endpointPolicies/[ENDPOINT_POLICY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = networkServicesClient.DeleteEndpointPolicy(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceDeleteEndpointPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEndpointPolicyAsync</summary>
        public async Task DeleteEndpointPolicyAsync()
        {
            // Snippet: DeleteEndpointPolicyAsync(string, CallSettings)
            // Additional: DeleteEndpointPolicyAsync(string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/endpointPolicies/[ENDPOINT_POLICY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkServicesClient.DeleteEndpointPolicyAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceDeleteEndpointPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEndpointPolicy</summary>
        public void DeleteEndpointPolicyResourceNames()
        {
            // Snippet: DeleteEndpointPolicy(EndpointPolicyName, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            EndpointPolicyName name = EndpointPolicyName.FromProjectLocationEndpointPolicy("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = networkServicesClient.DeleteEndpointPolicy(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceDeleteEndpointPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEndpointPolicyAsync</summary>
        public async Task DeleteEndpointPolicyResourceNamesAsync()
        {
            // Snippet: DeleteEndpointPolicyAsync(EndpointPolicyName, CallSettings)
            // Additional: DeleteEndpointPolicyAsync(EndpointPolicyName, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            EndpointPolicyName name = EndpointPolicyName.FromProjectLocationEndpointPolicy("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkServicesClient.DeleteEndpointPolicyAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceDeleteEndpointPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListWasmPluginVersions</summary>
        public void ListWasmPluginVersionsRequestObject()
        {
            // Snippet: ListWasmPluginVersions(ListWasmPluginVersionsRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            ListWasmPluginVersionsRequest request = new ListWasmPluginVersionsRequest
            {
                ParentAsWasmPluginName = WasmPluginName.FromProjectLocationWasmPlugin("[PROJECT]", "[LOCATION]", "[WASM_PLUGIN]"),
            };
            // Make the request
            PagedEnumerable<ListWasmPluginVersionsResponse, WasmPluginVersion> response = networkServicesClient.ListWasmPluginVersions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (WasmPluginVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWasmPluginVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WasmPluginVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WasmPluginVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WasmPluginVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWasmPluginVersionsAsync</summary>
        public async Task ListWasmPluginVersionsRequestObjectAsync()
        {
            // Snippet: ListWasmPluginVersionsAsync(ListWasmPluginVersionsRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            ListWasmPluginVersionsRequest request = new ListWasmPluginVersionsRequest
            {
                ParentAsWasmPluginName = WasmPluginName.FromProjectLocationWasmPlugin("[PROJECT]", "[LOCATION]", "[WASM_PLUGIN]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListWasmPluginVersionsResponse, WasmPluginVersion> response = networkServicesClient.ListWasmPluginVersionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((WasmPluginVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWasmPluginVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WasmPluginVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WasmPluginVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WasmPluginVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWasmPluginVersions</summary>
        public void ListWasmPluginVersions()
        {
            // Snippet: ListWasmPluginVersions(string, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/wasmPlugins/[WASM_PLUGIN]";
            // Make the request
            PagedEnumerable<ListWasmPluginVersionsResponse, WasmPluginVersion> response = networkServicesClient.ListWasmPluginVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (WasmPluginVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWasmPluginVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WasmPluginVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WasmPluginVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WasmPluginVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWasmPluginVersionsAsync</summary>
        public async Task ListWasmPluginVersionsAsync()
        {
            // Snippet: ListWasmPluginVersionsAsync(string, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/wasmPlugins/[WASM_PLUGIN]";
            // Make the request
            PagedAsyncEnumerable<ListWasmPluginVersionsResponse, WasmPluginVersion> response = networkServicesClient.ListWasmPluginVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((WasmPluginVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWasmPluginVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WasmPluginVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WasmPluginVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WasmPluginVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWasmPluginVersions</summary>
        public void ListWasmPluginVersionsResourceNames()
        {
            // Snippet: ListWasmPluginVersions(WasmPluginName, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            WasmPluginName parent = WasmPluginName.FromProjectLocationWasmPlugin("[PROJECT]", "[LOCATION]", "[WASM_PLUGIN]");
            // Make the request
            PagedEnumerable<ListWasmPluginVersionsResponse, WasmPluginVersion> response = networkServicesClient.ListWasmPluginVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (WasmPluginVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWasmPluginVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WasmPluginVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WasmPluginVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WasmPluginVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWasmPluginVersionsAsync</summary>
        public async Task ListWasmPluginVersionsResourceNamesAsync()
        {
            // Snippet: ListWasmPluginVersionsAsync(WasmPluginName, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            WasmPluginName parent = WasmPluginName.FromProjectLocationWasmPlugin("[PROJECT]", "[LOCATION]", "[WASM_PLUGIN]");
            // Make the request
            PagedAsyncEnumerable<ListWasmPluginVersionsResponse, WasmPluginVersion> response = networkServicesClient.ListWasmPluginVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((WasmPluginVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWasmPluginVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WasmPluginVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WasmPluginVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WasmPluginVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetWasmPluginVersion</summary>
        public void GetWasmPluginVersionRequestObject()
        {
            // Snippet: GetWasmPluginVersion(GetWasmPluginVersionRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            GetWasmPluginVersionRequest request = new GetWasmPluginVersionRequest
            {
                WasmPluginVersionName = WasmPluginVersionName.FromProjectLocationWasmPluginWasmPluginVersion("[PROJECT]", "[LOCATION]", "[WASM_PLUGIN]", "[WASM_PLUGIN_VERSION]"),
            };
            // Make the request
            WasmPluginVersion response = networkServicesClient.GetWasmPluginVersion(request);
            // End snippet
        }

        /// <summary>Snippet for GetWasmPluginVersionAsync</summary>
        public async Task GetWasmPluginVersionRequestObjectAsync()
        {
            // Snippet: GetWasmPluginVersionAsync(GetWasmPluginVersionRequest, CallSettings)
            // Additional: GetWasmPluginVersionAsync(GetWasmPluginVersionRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            GetWasmPluginVersionRequest request = new GetWasmPluginVersionRequest
            {
                WasmPluginVersionName = WasmPluginVersionName.FromProjectLocationWasmPluginWasmPluginVersion("[PROJECT]", "[LOCATION]", "[WASM_PLUGIN]", "[WASM_PLUGIN_VERSION]"),
            };
            // Make the request
            WasmPluginVersion response = await networkServicesClient.GetWasmPluginVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetWasmPluginVersion</summary>
        public void GetWasmPluginVersion()
        {
            // Snippet: GetWasmPluginVersion(string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/wasmPlugins/[WASM_PLUGIN]/versions/[WASM_PLUGIN_VERSION]";
            // Make the request
            WasmPluginVersion response = networkServicesClient.GetWasmPluginVersion(name);
            // End snippet
        }

        /// <summary>Snippet for GetWasmPluginVersionAsync</summary>
        public async Task GetWasmPluginVersionAsync()
        {
            // Snippet: GetWasmPluginVersionAsync(string, CallSettings)
            // Additional: GetWasmPluginVersionAsync(string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/wasmPlugins/[WASM_PLUGIN]/versions/[WASM_PLUGIN_VERSION]";
            // Make the request
            WasmPluginVersion response = await networkServicesClient.GetWasmPluginVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetWasmPluginVersion</summary>
        public void GetWasmPluginVersionResourceNames()
        {
            // Snippet: GetWasmPluginVersion(WasmPluginVersionName, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            WasmPluginVersionName name = WasmPluginVersionName.FromProjectLocationWasmPluginWasmPluginVersion("[PROJECT]", "[LOCATION]", "[WASM_PLUGIN]", "[WASM_PLUGIN_VERSION]");
            // Make the request
            WasmPluginVersion response = networkServicesClient.GetWasmPluginVersion(name);
            // End snippet
        }

        /// <summary>Snippet for GetWasmPluginVersionAsync</summary>
        public async Task GetWasmPluginVersionResourceNamesAsync()
        {
            // Snippet: GetWasmPluginVersionAsync(WasmPluginVersionName, CallSettings)
            // Additional: GetWasmPluginVersionAsync(WasmPluginVersionName, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            WasmPluginVersionName name = WasmPluginVersionName.FromProjectLocationWasmPluginWasmPluginVersion("[PROJECT]", "[LOCATION]", "[WASM_PLUGIN]", "[WASM_PLUGIN_VERSION]");
            // Make the request
            WasmPluginVersion response = await networkServicesClient.GetWasmPluginVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateWasmPluginVersion</summary>
        public void CreateWasmPluginVersionRequestObject()
        {
            // Snippet: CreateWasmPluginVersion(CreateWasmPluginVersionRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            CreateWasmPluginVersionRequest request = new CreateWasmPluginVersionRequest
            {
                ParentAsWasmPluginName = WasmPluginName.FromProjectLocationWasmPlugin("[PROJECT]", "[LOCATION]", "[WASM_PLUGIN]"),
                WasmPluginVersionId = "",
                WasmPluginVersion = new WasmPluginVersion(),
            };
            // Make the request
            Operation<WasmPluginVersion, OperationMetadata> response = networkServicesClient.CreateWasmPluginVersion(request);

            // Poll until the returned long-running operation is complete
            Operation<WasmPluginVersion, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WasmPluginVersion result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WasmPluginVersion, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceCreateWasmPluginVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WasmPluginVersion retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWasmPluginVersionAsync</summary>
        public async Task CreateWasmPluginVersionRequestObjectAsync()
        {
            // Snippet: CreateWasmPluginVersionAsync(CreateWasmPluginVersionRequest, CallSettings)
            // Additional: CreateWasmPluginVersionAsync(CreateWasmPluginVersionRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            CreateWasmPluginVersionRequest request = new CreateWasmPluginVersionRequest
            {
                ParentAsWasmPluginName = WasmPluginName.FromProjectLocationWasmPlugin("[PROJECT]", "[LOCATION]", "[WASM_PLUGIN]"),
                WasmPluginVersionId = "",
                WasmPluginVersion = new WasmPluginVersion(),
            };
            // Make the request
            Operation<WasmPluginVersion, OperationMetadata> response = await networkServicesClient.CreateWasmPluginVersionAsync(request);

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
            // End snippet
        }

        /// <summary>Snippet for CreateWasmPluginVersion</summary>
        public void CreateWasmPluginVersion()
        {
            // Snippet: CreateWasmPluginVersion(string, WasmPluginVersion, string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/wasmPlugins/[WASM_PLUGIN]";
            WasmPluginVersion wasmPluginVersion = new WasmPluginVersion();
            string wasmPluginVersionId = "";
            // Make the request
            Operation<WasmPluginVersion, OperationMetadata> response = networkServicesClient.CreateWasmPluginVersion(parent, wasmPluginVersion, wasmPluginVersionId);

            // Poll until the returned long-running operation is complete
            Operation<WasmPluginVersion, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WasmPluginVersion result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WasmPluginVersion, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceCreateWasmPluginVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WasmPluginVersion retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWasmPluginVersionAsync</summary>
        public async Task CreateWasmPluginVersionAsync()
        {
            // Snippet: CreateWasmPluginVersionAsync(string, WasmPluginVersion, string, CallSettings)
            // Additional: CreateWasmPluginVersionAsync(string, WasmPluginVersion, string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/wasmPlugins/[WASM_PLUGIN]";
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
            // End snippet
        }

        /// <summary>Snippet for CreateWasmPluginVersion</summary>
        public void CreateWasmPluginVersionResourceNames()
        {
            // Snippet: CreateWasmPluginVersion(WasmPluginName, WasmPluginVersion, string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            WasmPluginName parent = WasmPluginName.FromProjectLocationWasmPlugin("[PROJECT]", "[LOCATION]", "[WASM_PLUGIN]");
            WasmPluginVersion wasmPluginVersion = new WasmPluginVersion();
            string wasmPluginVersionId = "";
            // Make the request
            Operation<WasmPluginVersion, OperationMetadata> response = networkServicesClient.CreateWasmPluginVersion(parent, wasmPluginVersion, wasmPluginVersionId);

            // Poll until the returned long-running operation is complete
            Operation<WasmPluginVersion, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WasmPluginVersion result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WasmPluginVersion, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceCreateWasmPluginVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WasmPluginVersion retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWasmPluginVersionAsync</summary>
        public async Task CreateWasmPluginVersionResourceNamesAsync()
        {
            // Snippet: CreateWasmPluginVersionAsync(WasmPluginName, WasmPluginVersion, string, CallSettings)
            // Additional: CreateWasmPluginVersionAsync(WasmPluginName, WasmPluginVersion, string, CancellationToken)
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
            // End snippet
        }

        /// <summary>Snippet for DeleteWasmPluginVersion</summary>
        public void DeleteWasmPluginVersionRequestObject()
        {
            // Snippet: DeleteWasmPluginVersion(DeleteWasmPluginVersionRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            DeleteWasmPluginVersionRequest request = new DeleteWasmPluginVersionRequest
            {
                WasmPluginVersionName = WasmPluginVersionName.FromProjectLocationWasmPluginWasmPluginVersion("[PROJECT]", "[LOCATION]", "[WASM_PLUGIN]", "[WASM_PLUGIN_VERSION]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = networkServicesClient.DeleteWasmPluginVersion(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceDeleteWasmPluginVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWasmPluginVersionAsync</summary>
        public async Task DeleteWasmPluginVersionRequestObjectAsync()
        {
            // Snippet: DeleteWasmPluginVersionAsync(DeleteWasmPluginVersionRequest, CallSettings)
            // Additional: DeleteWasmPluginVersionAsync(DeleteWasmPluginVersionRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteWasmPluginVersionRequest request = new DeleteWasmPluginVersionRequest
            {
                WasmPluginVersionName = WasmPluginVersionName.FromProjectLocationWasmPluginWasmPluginVersion("[PROJECT]", "[LOCATION]", "[WASM_PLUGIN]", "[WASM_PLUGIN_VERSION]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkServicesClient.DeleteWasmPluginVersionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceDeleteWasmPluginVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWasmPluginVersion</summary>
        public void DeleteWasmPluginVersion()
        {
            // Snippet: DeleteWasmPluginVersion(string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/wasmPlugins/[WASM_PLUGIN]/versions/[WASM_PLUGIN_VERSION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = networkServicesClient.DeleteWasmPluginVersion(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceDeleteWasmPluginVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWasmPluginVersionAsync</summary>
        public async Task DeleteWasmPluginVersionAsync()
        {
            // Snippet: DeleteWasmPluginVersionAsync(string, CallSettings)
            // Additional: DeleteWasmPluginVersionAsync(string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/wasmPlugins/[WASM_PLUGIN]/versions/[WASM_PLUGIN_VERSION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkServicesClient.DeleteWasmPluginVersionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceDeleteWasmPluginVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWasmPluginVersion</summary>
        public void DeleteWasmPluginVersionResourceNames()
        {
            // Snippet: DeleteWasmPluginVersion(WasmPluginVersionName, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            WasmPluginVersionName name = WasmPluginVersionName.FromProjectLocationWasmPluginWasmPluginVersion("[PROJECT]", "[LOCATION]", "[WASM_PLUGIN]", "[WASM_PLUGIN_VERSION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = networkServicesClient.DeleteWasmPluginVersion(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceDeleteWasmPluginVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWasmPluginVersionAsync</summary>
        public async Task DeleteWasmPluginVersionResourceNamesAsync()
        {
            // Snippet: DeleteWasmPluginVersionAsync(WasmPluginVersionName, CallSettings)
            // Additional: DeleteWasmPluginVersionAsync(WasmPluginVersionName, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            WasmPluginVersionName name = WasmPluginVersionName.FromProjectLocationWasmPluginWasmPluginVersion("[PROJECT]", "[LOCATION]", "[WASM_PLUGIN]", "[WASM_PLUGIN_VERSION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkServicesClient.DeleteWasmPluginVersionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceDeleteWasmPluginVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListWasmPlugins</summary>
        public void ListWasmPluginsRequestObject()
        {
            // Snippet: ListWasmPlugins(ListWasmPluginsRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            ListWasmPluginsRequest request = new ListWasmPluginsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListWasmPluginsResponse, WasmPlugin> response = networkServicesClient.ListWasmPlugins(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (WasmPlugin item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWasmPluginsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WasmPlugin item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WasmPlugin> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WasmPlugin item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWasmPluginsAsync</summary>
        public async Task ListWasmPluginsRequestObjectAsync()
        {
            // Snippet: ListWasmPluginsAsync(ListWasmPluginsRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            ListWasmPluginsRequest request = new ListWasmPluginsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListWasmPluginsResponse, WasmPlugin> response = networkServicesClient.ListWasmPluginsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((WasmPlugin item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWasmPluginsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WasmPlugin item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WasmPlugin> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WasmPlugin item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWasmPlugins</summary>
        public void ListWasmPlugins()
        {
            // Snippet: ListWasmPlugins(string, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListWasmPluginsResponse, WasmPlugin> response = networkServicesClient.ListWasmPlugins(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (WasmPlugin item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWasmPluginsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WasmPlugin item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WasmPlugin> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WasmPlugin item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWasmPluginsAsync</summary>
        public async Task ListWasmPluginsAsync()
        {
            // Snippet: ListWasmPluginsAsync(string, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListWasmPluginsResponse, WasmPlugin> response = networkServicesClient.ListWasmPluginsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((WasmPlugin item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWasmPluginsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WasmPlugin item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WasmPlugin> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WasmPlugin item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWasmPlugins</summary>
        public void ListWasmPluginsResourceNames()
        {
            // Snippet: ListWasmPlugins(LocationName, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListWasmPluginsResponse, WasmPlugin> response = networkServicesClient.ListWasmPlugins(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (WasmPlugin item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWasmPluginsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WasmPlugin item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WasmPlugin> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WasmPlugin item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWasmPluginsAsync</summary>
        public async Task ListWasmPluginsResourceNamesAsync()
        {
            // Snippet: ListWasmPluginsAsync(LocationName, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListWasmPluginsResponse, WasmPlugin> response = networkServicesClient.ListWasmPluginsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((WasmPlugin item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWasmPluginsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WasmPlugin item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WasmPlugin> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WasmPlugin item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetWasmPlugin</summary>
        public void GetWasmPluginRequestObject()
        {
            // Snippet: GetWasmPlugin(GetWasmPluginRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            GetWasmPluginRequest request = new GetWasmPluginRequest
            {
                WasmPluginName = WasmPluginName.FromProjectLocationWasmPlugin("[PROJECT]", "[LOCATION]", "[WASM_PLUGIN]"),
                View = WasmPluginView.Unspecified,
            };
            // Make the request
            WasmPlugin response = networkServicesClient.GetWasmPlugin(request);
            // End snippet
        }

        /// <summary>Snippet for GetWasmPluginAsync</summary>
        public async Task GetWasmPluginRequestObjectAsync()
        {
            // Snippet: GetWasmPluginAsync(GetWasmPluginRequest, CallSettings)
            // Additional: GetWasmPluginAsync(GetWasmPluginRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            GetWasmPluginRequest request = new GetWasmPluginRequest
            {
                WasmPluginName = WasmPluginName.FromProjectLocationWasmPlugin("[PROJECT]", "[LOCATION]", "[WASM_PLUGIN]"),
                View = WasmPluginView.Unspecified,
            };
            // Make the request
            WasmPlugin response = await networkServicesClient.GetWasmPluginAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetWasmPlugin</summary>
        public void GetWasmPlugin()
        {
            // Snippet: GetWasmPlugin(string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/wasmPlugins/[WASM_PLUGIN]";
            // Make the request
            WasmPlugin response = networkServicesClient.GetWasmPlugin(name);
            // End snippet
        }

        /// <summary>Snippet for GetWasmPluginAsync</summary>
        public async Task GetWasmPluginAsync()
        {
            // Snippet: GetWasmPluginAsync(string, CallSettings)
            // Additional: GetWasmPluginAsync(string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/wasmPlugins/[WASM_PLUGIN]";
            // Make the request
            WasmPlugin response = await networkServicesClient.GetWasmPluginAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetWasmPlugin</summary>
        public void GetWasmPluginResourceNames()
        {
            // Snippet: GetWasmPlugin(WasmPluginName, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            WasmPluginName name = WasmPluginName.FromProjectLocationWasmPlugin("[PROJECT]", "[LOCATION]", "[WASM_PLUGIN]");
            // Make the request
            WasmPlugin response = networkServicesClient.GetWasmPlugin(name);
            // End snippet
        }

        /// <summary>Snippet for GetWasmPluginAsync</summary>
        public async Task GetWasmPluginResourceNamesAsync()
        {
            // Snippet: GetWasmPluginAsync(WasmPluginName, CallSettings)
            // Additional: GetWasmPluginAsync(WasmPluginName, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            WasmPluginName name = WasmPluginName.FromProjectLocationWasmPlugin("[PROJECT]", "[LOCATION]", "[WASM_PLUGIN]");
            // Make the request
            WasmPlugin response = await networkServicesClient.GetWasmPluginAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateWasmPlugin</summary>
        public void CreateWasmPluginRequestObject()
        {
            // Snippet: CreateWasmPlugin(CreateWasmPluginRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            CreateWasmPluginRequest request = new CreateWasmPluginRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                WasmPluginId = "",
                WasmPlugin = new WasmPlugin(),
            };
            // Make the request
            Operation<WasmPlugin, OperationMetadata> response = networkServicesClient.CreateWasmPlugin(request);

            // Poll until the returned long-running operation is complete
            Operation<WasmPlugin, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WasmPlugin result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WasmPlugin, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceCreateWasmPlugin(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WasmPlugin retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWasmPluginAsync</summary>
        public async Task CreateWasmPluginRequestObjectAsync()
        {
            // Snippet: CreateWasmPluginAsync(CreateWasmPluginRequest, CallSettings)
            // Additional: CreateWasmPluginAsync(CreateWasmPluginRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            CreateWasmPluginRequest request = new CreateWasmPluginRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                WasmPluginId = "",
                WasmPlugin = new WasmPlugin(),
            };
            // Make the request
            Operation<WasmPlugin, OperationMetadata> response = await networkServicesClient.CreateWasmPluginAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<WasmPlugin, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WasmPlugin result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WasmPlugin, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceCreateWasmPluginAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WasmPlugin retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWasmPlugin</summary>
        public void CreateWasmPlugin()
        {
            // Snippet: CreateWasmPlugin(string, WasmPlugin, string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            WasmPlugin wasmPlugin = new WasmPlugin();
            string wasmPluginId = "";
            // Make the request
            Operation<WasmPlugin, OperationMetadata> response = networkServicesClient.CreateWasmPlugin(parent, wasmPlugin, wasmPluginId);

            // Poll until the returned long-running operation is complete
            Operation<WasmPlugin, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WasmPlugin result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WasmPlugin, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceCreateWasmPlugin(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WasmPlugin retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWasmPluginAsync</summary>
        public async Task CreateWasmPluginAsync()
        {
            // Snippet: CreateWasmPluginAsync(string, WasmPlugin, string, CallSettings)
            // Additional: CreateWasmPluginAsync(string, WasmPlugin, string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            WasmPlugin wasmPlugin = new WasmPlugin();
            string wasmPluginId = "";
            // Make the request
            Operation<WasmPlugin, OperationMetadata> response = await networkServicesClient.CreateWasmPluginAsync(parent, wasmPlugin, wasmPluginId);

            // Poll until the returned long-running operation is complete
            Operation<WasmPlugin, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WasmPlugin result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WasmPlugin, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceCreateWasmPluginAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WasmPlugin retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWasmPlugin</summary>
        public void CreateWasmPluginResourceNames()
        {
            // Snippet: CreateWasmPlugin(LocationName, WasmPlugin, string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            WasmPlugin wasmPlugin = new WasmPlugin();
            string wasmPluginId = "";
            // Make the request
            Operation<WasmPlugin, OperationMetadata> response = networkServicesClient.CreateWasmPlugin(parent, wasmPlugin, wasmPluginId);

            // Poll until the returned long-running operation is complete
            Operation<WasmPlugin, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WasmPlugin result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WasmPlugin, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceCreateWasmPlugin(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WasmPlugin retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWasmPluginAsync</summary>
        public async Task CreateWasmPluginResourceNamesAsync()
        {
            // Snippet: CreateWasmPluginAsync(LocationName, WasmPlugin, string, CallSettings)
            // Additional: CreateWasmPluginAsync(LocationName, WasmPlugin, string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            WasmPlugin wasmPlugin = new WasmPlugin();
            string wasmPluginId = "";
            // Make the request
            Operation<WasmPlugin, OperationMetadata> response = await networkServicesClient.CreateWasmPluginAsync(parent, wasmPlugin, wasmPluginId);

            // Poll until the returned long-running operation is complete
            Operation<WasmPlugin, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WasmPlugin result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WasmPlugin, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceCreateWasmPluginAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WasmPlugin retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateWasmPlugin</summary>
        public void UpdateWasmPluginRequestObject()
        {
            // Snippet: UpdateWasmPlugin(UpdateWasmPluginRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            UpdateWasmPluginRequest request = new UpdateWasmPluginRequest
            {
                UpdateMask = new FieldMask(),
                WasmPlugin = new WasmPlugin(),
            };
            // Make the request
            Operation<WasmPlugin, OperationMetadata> response = networkServicesClient.UpdateWasmPlugin(request);

            // Poll until the returned long-running operation is complete
            Operation<WasmPlugin, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WasmPlugin result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WasmPlugin, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceUpdateWasmPlugin(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WasmPlugin retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateWasmPluginAsync</summary>
        public async Task UpdateWasmPluginRequestObjectAsync()
        {
            // Snippet: UpdateWasmPluginAsync(UpdateWasmPluginRequest, CallSettings)
            // Additional: UpdateWasmPluginAsync(UpdateWasmPluginRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            UpdateWasmPluginRequest request = new UpdateWasmPluginRequest
            {
                UpdateMask = new FieldMask(),
                WasmPlugin = new WasmPlugin(),
            };
            // Make the request
            Operation<WasmPlugin, OperationMetadata> response = await networkServicesClient.UpdateWasmPluginAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<WasmPlugin, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WasmPlugin result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WasmPlugin, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceUpdateWasmPluginAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WasmPlugin retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateWasmPlugin</summary>
        public void UpdateWasmPlugin()
        {
            // Snippet: UpdateWasmPlugin(WasmPlugin, FieldMask, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            WasmPlugin wasmPlugin = new WasmPlugin();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<WasmPlugin, OperationMetadata> response = networkServicesClient.UpdateWasmPlugin(wasmPlugin, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<WasmPlugin, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WasmPlugin result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WasmPlugin, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceUpdateWasmPlugin(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WasmPlugin retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateWasmPluginAsync</summary>
        public async Task UpdateWasmPluginAsync()
        {
            // Snippet: UpdateWasmPluginAsync(WasmPlugin, FieldMask, CallSettings)
            // Additional: UpdateWasmPluginAsync(WasmPlugin, FieldMask, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            WasmPlugin wasmPlugin = new WasmPlugin();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<WasmPlugin, OperationMetadata> response = await networkServicesClient.UpdateWasmPluginAsync(wasmPlugin, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<WasmPlugin, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WasmPlugin result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WasmPlugin, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceUpdateWasmPluginAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WasmPlugin retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWasmPlugin</summary>
        public void DeleteWasmPluginRequestObject()
        {
            // Snippet: DeleteWasmPlugin(DeleteWasmPluginRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            DeleteWasmPluginRequest request = new DeleteWasmPluginRequest
            {
                WasmPluginName = WasmPluginName.FromProjectLocationWasmPlugin("[PROJECT]", "[LOCATION]", "[WASM_PLUGIN]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = networkServicesClient.DeleteWasmPlugin(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceDeleteWasmPlugin(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWasmPluginAsync</summary>
        public async Task DeleteWasmPluginRequestObjectAsync()
        {
            // Snippet: DeleteWasmPluginAsync(DeleteWasmPluginRequest, CallSettings)
            // Additional: DeleteWasmPluginAsync(DeleteWasmPluginRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteWasmPluginRequest request = new DeleteWasmPluginRequest
            {
                WasmPluginName = WasmPluginName.FromProjectLocationWasmPlugin("[PROJECT]", "[LOCATION]", "[WASM_PLUGIN]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkServicesClient.DeleteWasmPluginAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceDeleteWasmPluginAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWasmPlugin</summary>
        public void DeleteWasmPlugin()
        {
            // Snippet: DeleteWasmPlugin(string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/wasmPlugins/[WASM_PLUGIN]";
            // Make the request
            Operation<Empty, OperationMetadata> response = networkServicesClient.DeleteWasmPlugin(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceDeleteWasmPlugin(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWasmPluginAsync</summary>
        public async Task DeleteWasmPluginAsync()
        {
            // Snippet: DeleteWasmPluginAsync(string, CallSettings)
            // Additional: DeleteWasmPluginAsync(string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/wasmPlugins/[WASM_PLUGIN]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkServicesClient.DeleteWasmPluginAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceDeleteWasmPluginAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWasmPlugin</summary>
        public void DeleteWasmPluginResourceNames()
        {
            // Snippet: DeleteWasmPlugin(WasmPluginName, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            WasmPluginName name = WasmPluginName.FromProjectLocationWasmPlugin("[PROJECT]", "[LOCATION]", "[WASM_PLUGIN]");
            // Make the request
            Operation<Empty, OperationMetadata> response = networkServicesClient.DeleteWasmPlugin(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceDeleteWasmPlugin(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWasmPluginAsync</summary>
        public async Task DeleteWasmPluginResourceNamesAsync()
        {
            // Snippet: DeleteWasmPluginAsync(WasmPluginName, CallSettings)
            // Additional: DeleteWasmPluginAsync(WasmPluginName, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            WasmPluginName name = WasmPluginName.FromProjectLocationWasmPlugin("[PROJECT]", "[LOCATION]", "[WASM_PLUGIN]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkServicesClient.DeleteWasmPluginAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceDeleteWasmPluginAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListGateways</summary>
        public void ListGatewaysRequestObject()
        {
            // Snippet: ListGateways(ListGatewaysRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            ListGatewaysRequest request = new ListGatewaysRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListGatewaysResponse, Gateway> response = networkServicesClient.ListGateways(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Gateway item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGatewaysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Gateway item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Gateway> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Gateway item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGatewaysAsync</summary>
        public async Task ListGatewaysRequestObjectAsync()
        {
            // Snippet: ListGatewaysAsync(ListGatewaysRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            ListGatewaysRequest request = new ListGatewaysRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListGatewaysResponse, Gateway> response = networkServicesClient.ListGatewaysAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Gateway item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGatewaysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Gateway item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Gateway> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Gateway item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGateways</summary>
        public void ListGateways()
        {
            // Snippet: ListGateways(string, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListGatewaysResponse, Gateway> response = networkServicesClient.ListGateways(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Gateway item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGatewaysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Gateway item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Gateway> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Gateway item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGatewaysAsync</summary>
        public async Task ListGatewaysAsync()
        {
            // Snippet: ListGatewaysAsync(string, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListGatewaysResponse, Gateway> response = networkServicesClient.ListGatewaysAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Gateway item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGatewaysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Gateway item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Gateway> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Gateway item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGateways</summary>
        public void ListGatewaysResourceNames()
        {
            // Snippet: ListGateways(LocationName, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListGatewaysResponse, Gateway> response = networkServicesClient.ListGateways(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Gateway item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGatewaysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Gateway item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Gateway> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Gateway item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGatewaysAsync</summary>
        public async Task ListGatewaysResourceNamesAsync()
        {
            // Snippet: ListGatewaysAsync(LocationName, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListGatewaysResponse, Gateway> response = networkServicesClient.ListGatewaysAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Gateway item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGatewaysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Gateway item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Gateway> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Gateway item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetGateway</summary>
        public void GetGatewayRequestObject()
        {
            // Snippet: GetGateway(GetGatewayRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            GetGatewayRequest request = new GetGatewayRequest
            {
                GatewayName = GatewayName.FromProjectLocationGateway("[PROJECT]", "[LOCATION]", "[GATEWAY]"),
            };
            // Make the request
            Gateway response = networkServicesClient.GetGateway(request);
            // End snippet
        }

        /// <summary>Snippet for GetGatewayAsync</summary>
        public async Task GetGatewayRequestObjectAsync()
        {
            // Snippet: GetGatewayAsync(GetGatewayRequest, CallSettings)
            // Additional: GetGatewayAsync(GetGatewayRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            GetGatewayRequest request = new GetGatewayRequest
            {
                GatewayName = GatewayName.FromProjectLocationGateway("[PROJECT]", "[LOCATION]", "[GATEWAY]"),
            };
            // Make the request
            Gateway response = await networkServicesClient.GetGatewayAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetGateway</summary>
        public void GetGateway()
        {
            // Snippet: GetGateway(string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/gateways/[GATEWAY]";
            // Make the request
            Gateway response = networkServicesClient.GetGateway(name);
            // End snippet
        }

        /// <summary>Snippet for GetGatewayAsync</summary>
        public async Task GetGatewayAsync()
        {
            // Snippet: GetGatewayAsync(string, CallSettings)
            // Additional: GetGatewayAsync(string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/gateways/[GATEWAY]";
            // Make the request
            Gateway response = await networkServicesClient.GetGatewayAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetGateway</summary>
        public void GetGatewayResourceNames()
        {
            // Snippet: GetGateway(GatewayName, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            GatewayName name = GatewayName.FromProjectLocationGateway("[PROJECT]", "[LOCATION]", "[GATEWAY]");
            // Make the request
            Gateway response = networkServicesClient.GetGateway(name);
            // End snippet
        }

        /// <summary>Snippet for GetGatewayAsync</summary>
        public async Task GetGatewayResourceNamesAsync()
        {
            // Snippet: GetGatewayAsync(GatewayName, CallSettings)
            // Additional: GetGatewayAsync(GatewayName, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            GatewayName name = GatewayName.FromProjectLocationGateway("[PROJECT]", "[LOCATION]", "[GATEWAY]");
            // Make the request
            Gateway response = await networkServicesClient.GetGatewayAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateGateway</summary>
        public void CreateGatewayRequestObject()
        {
            // Snippet: CreateGateway(CreateGatewayRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            CreateGatewayRequest request = new CreateGatewayRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                GatewayId = "",
                Gateway = new Gateway(),
            };
            // Make the request
            Operation<Gateway, OperationMetadata> response = networkServicesClient.CreateGateway(request);

            // Poll until the returned long-running operation is complete
            Operation<Gateway, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Gateway result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Gateway, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceCreateGateway(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Gateway retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGatewayAsync</summary>
        public async Task CreateGatewayRequestObjectAsync()
        {
            // Snippet: CreateGatewayAsync(CreateGatewayRequest, CallSettings)
            // Additional: CreateGatewayAsync(CreateGatewayRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            CreateGatewayRequest request = new CreateGatewayRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                GatewayId = "",
                Gateway = new Gateway(),
            };
            // Make the request
            Operation<Gateway, OperationMetadata> response = await networkServicesClient.CreateGatewayAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Gateway, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Gateway result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Gateway, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceCreateGatewayAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Gateway retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGateway</summary>
        public void CreateGateway()
        {
            // Snippet: CreateGateway(string, Gateway, string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Gateway gateway = new Gateway();
            string gatewayId = "";
            // Make the request
            Operation<Gateway, OperationMetadata> response = networkServicesClient.CreateGateway(parent, gateway, gatewayId);

            // Poll until the returned long-running operation is complete
            Operation<Gateway, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Gateway result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Gateway, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceCreateGateway(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Gateway retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGatewayAsync</summary>
        public async Task CreateGatewayAsync()
        {
            // Snippet: CreateGatewayAsync(string, Gateway, string, CallSettings)
            // Additional: CreateGatewayAsync(string, Gateway, string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Gateway gateway = new Gateway();
            string gatewayId = "";
            // Make the request
            Operation<Gateway, OperationMetadata> response = await networkServicesClient.CreateGatewayAsync(parent, gateway, gatewayId);

            // Poll until the returned long-running operation is complete
            Operation<Gateway, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Gateway result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Gateway, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceCreateGatewayAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Gateway retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGateway</summary>
        public void CreateGatewayResourceNames()
        {
            // Snippet: CreateGateway(LocationName, Gateway, string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Gateway gateway = new Gateway();
            string gatewayId = "";
            // Make the request
            Operation<Gateway, OperationMetadata> response = networkServicesClient.CreateGateway(parent, gateway, gatewayId);

            // Poll until the returned long-running operation is complete
            Operation<Gateway, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Gateway result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Gateway, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceCreateGateway(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Gateway retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGatewayAsync</summary>
        public async Task CreateGatewayResourceNamesAsync()
        {
            // Snippet: CreateGatewayAsync(LocationName, Gateway, string, CallSettings)
            // Additional: CreateGatewayAsync(LocationName, Gateway, string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Gateway gateway = new Gateway();
            string gatewayId = "";
            // Make the request
            Operation<Gateway, OperationMetadata> response = await networkServicesClient.CreateGatewayAsync(parent, gateway, gatewayId);

            // Poll until the returned long-running operation is complete
            Operation<Gateway, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Gateway result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Gateway, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceCreateGatewayAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Gateway retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGateway</summary>
        public void UpdateGatewayRequestObject()
        {
            // Snippet: UpdateGateway(UpdateGatewayRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            UpdateGatewayRequest request = new UpdateGatewayRequest
            {
                UpdateMask = new FieldMask(),
                Gateway = new Gateway(),
            };
            // Make the request
            Operation<Gateway, OperationMetadata> response = networkServicesClient.UpdateGateway(request);

            // Poll until the returned long-running operation is complete
            Operation<Gateway, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Gateway result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Gateway, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceUpdateGateway(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Gateway retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGatewayAsync</summary>
        public async Task UpdateGatewayRequestObjectAsync()
        {
            // Snippet: UpdateGatewayAsync(UpdateGatewayRequest, CallSettings)
            // Additional: UpdateGatewayAsync(UpdateGatewayRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            UpdateGatewayRequest request = new UpdateGatewayRequest
            {
                UpdateMask = new FieldMask(),
                Gateway = new Gateway(),
            };
            // Make the request
            Operation<Gateway, OperationMetadata> response = await networkServicesClient.UpdateGatewayAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Gateway, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Gateway result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Gateway, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceUpdateGatewayAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Gateway retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGateway</summary>
        public void UpdateGateway()
        {
            // Snippet: UpdateGateway(Gateway, FieldMask, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            Gateway gateway = new Gateway();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Gateway, OperationMetadata> response = networkServicesClient.UpdateGateway(gateway, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Gateway, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Gateway result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Gateway, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceUpdateGateway(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Gateway retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGatewayAsync</summary>
        public async Task UpdateGatewayAsync()
        {
            // Snippet: UpdateGatewayAsync(Gateway, FieldMask, CallSettings)
            // Additional: UpdateGatewayAsync(Gateway, FieldMask, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            Gateway gateway = new Gateway();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Gateway, OperationMetadata> response = await networkServicesClient.UpdateGatewayAsync(gateway, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Gateway, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Gateway result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Gateway, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceUpdateGatewayAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Gateway retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGateway</summary>
        public void DeleteGatewayRequestObject()
        {
            // Snippet: DeleteGateway(DeleteGatewayRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            DeleteGatewayRequest request = new DeleteGatewayRequest
            {
                GatewayName = GatewayName.FromProjectLocationGateway("[PROJECT]", "[LOCATION]", "[GATEWAY]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = networkServicesClient.DeleteGateway(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceDeleteGateway(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGatewayAsync</summary>
        public async Task DeleteGatewayRequestObjectAsync()
        {
            // Snippet: DeleteGatewayAsync(DeleteGatewayRequest, CallSettings)
            // Additional: DeleteGatewayAsync(DeleteGatewayRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteGatewayRequest request = new DeleteGatewayRequest
            {
                GatewayName = GatewayName.FromProjectLocationGateway("[PROJECT]", "[LOCATION]", "[GATEWAY]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkServicesClient.DeleteGatewayAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceDeleteGatewayAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGateway</summary>
        public void DeleteGateway()
        {
            // Snippet: DeleteGateway(string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/gateways/[GATEWAY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = networkServicesClient.DeleteGateway(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceDeleteGateway(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGatewayAsync</summary>
        public async Task DeleteGatewayAsync()
        {
            // Snippet: DeleteGatewayAsync(string, CallSettings)
            // Additional: DeleteGatewayAsync(string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/gateways/[GATEWAY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkServicesClient.DeleteGatewayAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceDeleteGatewayAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGateway</summary>
        public void DeleteGatewayResourceNames()
        {
            // Snippet: DeleteGateway(GatewayName, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            GatewayName name = GatewayName.FromProjectLocationGateway("[PROJECT]", "[LOCATION]", "[GATEWAY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = networkServicesClient.DeleteGateway(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceDeleteGateway(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGatewayAsync</summary>
        public async Task DeleteGatewayResourceNamesAsync()
        {
            // Snippet: DeleteGatewayAsync(GatewayName, CallSettings)
            // Additional: DeleteGatewayAsync(GatewayName, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            GatewayName name = GatewayName.FromProjectLocationGateway("[PROJECT]", "[LOCATION]", "[GATEWAY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkServicesClient.DeleteGatewayAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceDeleteGatewayAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListGrpcRoutes</summary>
        public void ListGrpcRoutesRequestObject()
        {
            // Snippet: ListGrpcRoutes(ListGrpcRoutesRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            ListGrpcRoutesRequest request = new ListGrpcRoutesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<ListGrpcRoutesResponse, GrpcRoute> response = networkServicesClient.ListGrpcRoutes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GrpcRoute item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGrpcRoutesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GrpcRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GrpcRoute> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GrpcRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGrpcRoutesAsync</summary>
        public async Task ListGrpcRoutesRequestObjectAsync()
        {
            // Snippet: ListGrpcRoutesAsync(ListGrpcRoutesRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            ListGrpcRoutesRequest request = new ListGrpcRoutesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<ListGrpcRoutesResponse, GrpcRoute> response = networkServicesClient.ListGrpcRoutesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GrpcRoute item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGrpcRoutesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GrpcRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GrpcRoute> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GrpcRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGrpcRoutes</summary>
        public void ListGrpcRoutes()
        {
            // Snippet: ListGrpcRoutes(string, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListGrpcRoutesResponse, GrpcRoute> response = networkServicesClient.ListGrpcRoutes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GrpcRoute item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGrpcRoutesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GrpcRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GrpcRoute> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GrpcRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGrpcRoutesAsync</summary>
        public async Task ListGrpcRoutesAsync()
        {
            // Snippet: ListGrpcRoutesAsync(string, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListGrpcRoutesResponse, GrpcRoute> response = networkServicesClient.ListGrpcRoutesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GrpcRoute item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGrpcRoutesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GrpcRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GrpcRoute> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GrpcRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGrpcRoutes</summary>
        public void ListGrpcRoutesResourceNames()
        {
            // Snippet: ListGrpcRoutes(LocationName, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListGrpcRoutesResponse, GrpcRoute> response = networkServicesClient.ListGrpcRoutes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GrpcRoute item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGrpcRoutesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GrpcRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GrpcRoute> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GrpcRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGrpcRoutesAsync</summary>
        public async Task ListGrpcRoutesResourceNamesAsync()
        {
            // Snippet: ListGrpcRoutesAsync(LocationName, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListGrpcRoutesResponse, GrpcRoute> response = networkServicesClient.ListGrpcRoutesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GrpcRoute item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGrpcRoutesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GrpcRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GrpcRoute> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GrpcRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetGrpcRoute</summary>
        public void GetGrpcRouteRequestObject()
        {
            // Snippet: GetGrpcRoute(GetGrpcRouteRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            GetGrpcRouteRequest request = new GetGrpcRouteRequest
            {
                GrpcRouteName = GrpcRouteName.FromProjectLocationGrpcRoute("[PROJECT]", "[LOCATION]", "[GRPC_ROUTE]"),
            };
            // Make the request
            GrpcRoute response = networkServicesClient.GetGrpcRoute(request);
            // End snippet
        }

        /// <summary>Snippet for GetGrpcRouteAsync</summary>
        public async Task GetGrpcRouteRequestObjectAsync()
        {
            // Snippet: GetGrpcRouteAsync(GetGrpcRouteRequest, CallSettings)
            // Additional: GetGrpcRouteAsync(GetGrpcRouteRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            GetGrpcRouteRequest request = new GetGrpcRouteRequest
            {
                GrpcRouteName = GrpcRouteName.FromProjectLocationGrpcRoute("[PROJECT]", "[LOCATION]", "[GRPC_ROUTE]"),
            };
            // Make the request
            GrpcRoute response = await networkServicesClient.GetGrpcRouteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetGrpcRoute</summary>
        public void GetGrpcRoute()
        {
            // Snippet: GetGrpcRoute(string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/grpcRoutes/[GRPC_ROUTE]";
            // Make the request
            GrpcRoute response = networkServicesClient.GetGrpcRoute(name);
            // End snippet
        }

        /// <summary>Snippet for GetGrpcRouteAsync</summary>
        public async Task GetGrpcRouteAsync()
        {
            // Snippet: GetGrpcRouteAsync(string, CallSettings)
            // Additional: GetGrpcRouteAsync(string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/grpcRoutes/[GRPC_ROUTE]";
            // Make the request
            GrpcRoute response = await networkServicesClient.GetGrpcRouteAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetGrpcRoute</summary>
        public void GetGrpcRouteResourceNames()
        {
            // Snippet: GetGrpcRoute(GrpcRouteName, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            GrpcRouteName name = GrpcRouteName.FromProjectLocationGrpcRoute("[PROJECT]", "[LOCATION]", "[GRPC_ROUTE]");
            // Make the request
            GrpcRoute response = networkServicesClient.GetGrpcRoute(name);
            // End snippet
        }

        /// <summary>Snippet for GetGrpcRouteAsync</summary>
        public async Task GetGrpcRouteResourceNamesAsync()
        {
            // Snippet: GetGrpcRouteAsync(GrpcRouteName, CallSettings)
            // Additional: GetGrpcRouteAsync(GrpcRouteName, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            GrpcRouteName name = GrpcRouteName.FromProjectLocationGrpcRoute("[PROJECT]", "[LOCATION]", "[GRPC_ROUTE]");
            // Make the request
            GrpcRoute response = await networkServicesClient.GetGrpcRouteAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateGrpcRoute</summary>
        public void CreateGrpcRouteRequestObject()
        {
            // Snippet: CreateGrpcRoute(CreateGrpcRouteRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            CreateGrpcRouteRequest request = new CreateGrpcRouteRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                GrpcRouteId = "",
                GrpcRoute = new GrpcRoute(),
            };
            // Make the request
            Operation<GrpcRoute, OperationMetadata> response = networkServicesClient.CreateGrpcRoute(request);

            // Poll until the returned long-running operation is complete
            Operation<GrpcRoute, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GrpcRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GrpcRoute, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceCreateGrpcRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GrpcRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGrpcRouteAsync</summary>
        public async Task CreateGrpcRouteRequestObjectAsync()
        {
            // Snippet: CreateGrpcRouteAsync(CreateGrpcRouteRequest, CallSettings)
            // Additional: CreateGrpcRouteAsync(CreateGrpcRouteRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            CreateGrpcRouteRequest request = new CreateGrpcRouteRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                GrpcRouteId = "",
                GrpcRoute = new GrpcRoute(),
            };
            // Make the request
            Operation<GrpcRoute, OperationMetadata> response = await networkServicesClient.CreateGrpcRouteAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<GrpcRoute, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GrpcRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GrpcRoute, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceCreateGrpcRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GrpcRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGrpcRoute</summary>
        public void CreateGrpcRoute()
        {
            // Snippet: CreateGrpcRoute(string, GrpcRoute, string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            GrpcRoute grpcRoute = new GrpcRoute();
            string grpcRouteId = "";
            // Make the request
            Operation<GrpcRoute, OperationMetadata> response = networkServicesClient.CreateGrpcRoute(parent, grpcRoute, grpcRouteId);

            // Poll until the returned long-running operation is complete
            Operation<GrpcRoute, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GrpcRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GrpcRoute, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceCreateGrpcRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GrpcRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGrpcRouteAsync</summary>
        public async Task CreateGrpcRouteAsync()
        {
            // Snippet: CreateGrpcRouteAsync(string, GrpcRoute, string, CallSettings)
            // Additional: CreateGrpcRouteAsync(string, GrpcRoute, string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            GrpcRoute grpcRoute = new GrpcRoute();
            string grpcRouteId = "";
            // Make the request
            Operation<GrpcRoute, OperationMetadata> response = await networkServicesClient.CreateGrpcRouteAsync(parent, grpcRoute, grpcRouteId);

            // Poll until the returned long-running operation is complete
            Operation<GrpcRoute, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GrpcRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GrpcRoute, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceCreateGrpcRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GrpcRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGrpcRoute</summary>
        public void CreateGrpcRouteResourceNames()
        {
            // Snippet: CreateGrpcRoute(LocationName, GrpcRoute, string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            GrpcRoute grpcRoute = new GrpcRoute();
            string grpcRouteId = "";
            // Make the request
            Operation<GrpcRoute, OperationMetadata> response = networkServicesClient.CreateGrpcRoute(parent, grpcRoute, grpcRouteId);

            // Poll until the returned long-running operation is complete
            Operation<GrpcRoute, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GrpcRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GrpcRoute, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceCreateGrpcRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GrpcRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGrpcRouteAsync</summary>
        public async Task CreateGrpcRouteResourceNamesAsync()
        {
            // Snippet: CreateGrpcRouteAsync(LocationName, GrpcRoute, string, CallSettings)
            // Additional: CreateGrpcRouteAsync(LocationName, GrpcRoute, string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            GrpcRoute grpcRoute = new GrpcRoute();
            string grpcRouteId = "";
            // Make the request
            Operation<GrpcRoute, OperationMetadata> response = await networkServicesClient.CreateGrpcRouteAsync(parent, grpcRoute, grpcRouteId);

            // Poll until the returned long-running operation is complete
            Operation<GrpcRoute, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GrpcRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GrpcRoute, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceCreateGrpcRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GrpcRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGrpcRoute</summary>
        public void UpdateGrpcRouteRequestObject()
        {
            // Snippet: UpdateGrpcRoute(UpdateGrpcRouteRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            UpdateGrpcRouteRequest request = new UpdateGrpcRouteRequest
            {
                UpdateMask = new FieldMask(),
                GrpcRoute = new GrpcRoute(),
            };
            // Make the request
            Operation<GrpcRoute, OperationMetadata> response = networkServicesClient.UpdateGrpcRoute(request);

            // Poll until the returned long-running operation is complete
            Operation<GrpcRoute, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GrpcRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GrpcRoute, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceUpdateGrpcRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GrpcRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGrpcRouteAsync</summary>
        public async Task UpdateGrpcRouteRequestObjectAsync()
        {
            // Snippet: UpdateGrpcRouteAsync(UpdateGrpcRouteRequest, CallSettings)
            // Additional: UpdateGrpcRouteAsync(UpdateGrpcRouteRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            UpdateGrpcRouteRequest request = new UpdateGrpcRouteRequest
            {
                UpdateMask = new FieldMask(),
                GrpcRoute = new GrpcRoute(),
            };
            // Make the request
            Operation<GrpcRoute, OperationMetadata> response = await networkServicesClient.UpdateGrpcRouteAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<GrpcRoute, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GrpcRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GrpcRoute, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceUpdateGrpcRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GrpcRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGrpcRoute</summary>
        public void UpdateGrpcRoute()
        {
            // Snippet: UpdateGrpcRoute(GrpcRoute, FieldMask, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            GrpcRoute grpcRoute = new GrpcRoute();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<GrpcRoute, OperationMetadata> response = networkServicesClient.UpdateGrpcRoute(grpcRoute, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<GrpcRoute, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GrpcRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GrpcRoute, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceUpdateGrpcRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GrpcRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGrpcRouteAsync</summary>
        public async Task UpdateGrpcRouteAsync()
        {
            // Snippet: UpdateGrpcRouteAsync(GrpcRoute, FieldMask, CallSettings)
            // Additional: UpdateGrpcRouteAsync(GrpcRoute, FieldMask, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            GrpcRoute grpcRoute = new GrpcRoute();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<GrpcRoute, OperationMetadata> response = await networkServicesClient.UpdateGrpcRouteAsync(grpcRoute, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<GrpcRoute, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GrpcRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GrpcRoute, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceUpdateGrpcRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GrpcRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGrpcRoute</summary>
        public void DeleteGrpcRouteRequestObject()
        {
            // Snippet: DeleteGrpcRoute(DeleteGrpcRouteRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            DeleteGrpcRouteRequest request = new DeleteGrpcRouteRequest
            {
                GrpcRouteName = GrpcRouteName.FromProjectLocationGrpcRoute("[PROJECT]", "[LOCATION]", "[GRPC_ROUTE]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = networkServicesClient.DeleteGrpcRoute(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceDeleteGrpcRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGrpcRouteAsync</summary>
        public async Task DeleteGrpcRouteRequestObjectAsync()
        {
            // Snippet: DeleteGrpcRouteAsync(DeleteGrpcRouteRequest, CallSettings)
            // Additional: DeleteGrpcRouteAsync(DeleteGrpcRouteRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteGrpcRouteRequest request = new DeleteGrpcRouteRequest
            {
                GrpcRouteName = GrpcRouteName.FromProjectLocationGrpcRoute("[PROJECT]", "[LOCATION]", "[GRPC_ROUTE]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkServicesClient.DeleteGrpcRouteAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceDeleteGrpcRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGrpcRoute</summary>
        public void DeleteGrpcRoute()
        {
            // Snippet: DeleteGrpcRoute(string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/grpcRoutes/[GRPC_ROUTE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = networkServicesClient.DeleteGrpcRoute(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceDeleteGrpcRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGrpcRouteAsync</summary>
        public async Task DeleteGrpcRouteAsync()
        {
            // Snippet: DeleteGrpcRouteAsync(string, CallSettings)
            // Additional: DeleteGrpcRouteAsync(string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/grpcRoutes/[GRPC_ROUTE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkServicesClient.DeleteGrpcRouteAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceDeleteGrpcRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGrpcRoute</summary>
        public void DeleteGrpcRouteResourceNames()
        {
            // Snippet: DeleteGrpcRoute(GrpcRouteName, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            GrpcRouteName name = GrpcRouteName.FromProjectLocationGrpcRoute("[PROJECT]", "[LOCATION]", "[GRPC_ROUTE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = networkServicesClient.DeleteGrpcRoute(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceDeleteGrpcRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGrpcRouteAsync</summary>
        public async Task DeleteGrpcRouteResourceNamesAsync()
        {
            // Snippet: DeleteGrpcRouteAsync(GrpcRouteName, CallSettings)
            // Additional: DeleteGrpcRouteAsync(GrpcRouteName, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            GrpcRouteName name = GrpcRouteName.FromProjectLocationGrpcRoute("[PROJECT]", "[LOCATION]", "[GRPC_ROUTE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkServicesClient.DeleteGrpcRouteAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceDeleteGrpcRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListHttpRoutes</summary>
        public void ListHttpRoutesRequestObject()
        {
            // Snippet: ListHttpRoutes(ListHttpRoutesRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            ListHttpRoutesRequest request = new ListHttpRoutesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<ListHttpRoutesResponse, HttpRoute> response = networkServicesClient.ListHttpRoutes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (HttpRoute item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListHttpRoutesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HttpRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HttpRoute> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HttpRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHttpRoutesAsync</summary>
        public async Task ListHttpRoutesRequestObjectAsync()
        {
            // Snippet: ListHttpRoutesAsync(ListHttpRoutesRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            ListHttpRoutesRequest request = new ListHttpRoutesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<ListHttpRoutesResponse, HttpRoute> response = networkServicesClient.ListHttpRoutesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((HttpRoute item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListHttpRoutesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HttpRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HttpRoute> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HttpRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHttpRoutes</summary>
        public void ListHttpRoutes()
        {
            // Snippet: ListHttpRoutes(string, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListHttpRoutesResponse, HttpRoute> response = networkServicesClient.ListHttpRoutes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (HttpRoute item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListHttpRoutesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HttpRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HttpRoute> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HttpRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHttpRoutesAsync</summary>
        public async Task ListHttpRoutesAsync()
        {
            // Snippet: ListHttpRoutesAsync(string, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListHttpRoutesResponse, HttpRoute> response = networkServicesClient.ListHttpRoutesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((HttpRoute item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListHttpRoutesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HttpRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HttpRoute> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HttpRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHttpRoutes</summary>
        public void ListHttpRoutesResourceNames()
        {
            // Snippet: ListHttpRoutes(LocationName, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListHttpRoutesResponse, HttpRoute> response = networkServicesClient.ListHttpRoutes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (HttpRoute item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListHttpRoutesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HttpRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HttpRoute> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HttpRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHttpRoutesAsync</summary>
        public async Task ListHttpRoutesResourceNamesAsync()
        {
            // Snippet: ListHttpRoutesAsync(LocationName, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListHttpRoutesResponse, HttpRoute> response = networkServicesClient.ListHttpRoutesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((HttpRoute item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListHttpRoutesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HttpRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HttpRoute> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HttpRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetHttpRoute</summary>
        public void GetHttpRouteRequestObject()
        {
            // Snippet: GetHttpRoute(GetHttpRouteRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            GetHttpRouteRequest request = new GetHttpRouteRequest
            {
                HttpRouteName = HttpRouteName.FromProjectLocationHttpRoute("[PROJECT]", "[LOCATION]", "[HTTP_ROUTE]"),
            };
            // Make the request
            HttpRoute response = networkServicesClient.GetHttpRoute(request);
            // End snippet
        }

        /// <summary>Snippet for GetHttpRouteAsync</summary>
        public async Task GetHttpRouteRequestObjectAsync()
        {
            // Snippet: GetHttpRouteAsync(GetHttpRouteRequest, CallSettings)
            // Additional: GetHttpRouteAsync(GetHttpRouteRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            GetHttpRouteRequest request = new GetHttpRouteRequest
            {
                HttpRouteName = HttpRouteName.FromProjectLocationHttpRoute("[PROJECT]", "[LOCATION]", "[HTTP_ROUTE]"),
            };
            // Make the request
            HttpRoute response = await networkServicesClient.GetHttpRouteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetHttpRoute</summary>
        public void GetHttpRoute()
        {
            // Snippet: GetHttpRoute(string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/httpRoutes/[HTTP_ROUTE]";
            // Make the request
            HttpRoute response = networkServicesClient.GetHttpRoute(name);
            // End snippet
        }

        /// <summary>Snippet for GetHttpRouteAsync</summary>
        public async Task GetHttpRouteAsync()
        {
            // Snippet: GetHttpRouteAsync(string, CallSettings)
            // Additional: GetHttpRouteAsync(string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/httpRoutes/[HTTP_ROUTE]";
            // Make the request
            HttpRoute response = await networkServicesClient.GetHttpRouteAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetHttpRoute</summary>
        public void GetHttpRouteResourceNames()
        {
            // Snippet: GetHttpRoute(HttpRouteName, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            HttpRouteName name = HttpRouteName.FromProjectLocationHttpRoute("[PROJECT]", "[LOCATION]", "[HTTP_ROUTE]");
            // Make the request
            HttpRoute response = networkServicesClient.GetHttpRoute(name);
            // End snippet
        }

        /// <summary>Snippet for GetHttpRouteAsync</summary>
        public async Task GetHttpRouteResourceNamesAsync()
        {
            // Snippet: GetHttpRouteAsync(HttpRouteName, CallSettings)
            // Additional: GetHttpRouteAsync(HttpRouteName, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            HttpRouteName name = HttpRouteName.FromProjectLocationHttpRoute("[PROJECT]", "[LOCATION]", "[HTTP_ROUTE]");
            // Make the request
            HttpRoute response = await networkServicesClient.GetHttpRouteAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateHttpRoute</summary>
        public void CreateHttpRouteRequestObject()
        {
            // Snippet: CreateHttpRoute(CreateHttpRouteRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            CreateHttpRouteRequest request = new CreateHttpRouteRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                HttpRouteId = "",
                HttpRoute = new HttpRoute(),
            };
            // Make the request
            Operation<HttpRoute, OperationMetadata> response = networkServicesClient.CreateHttpRoute(request);

            // Poll until the returned long-running operation is complete
            Operation<HttpRoute, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            HttpRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<HttpRoute, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceCreateHttpRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                HttpRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateHttpRouteAsync</summary>
        public async Task CreateHttpRouteRequestObjectAsync()
        {
            // Snippet: CreateHttpRouteAsync(CreateHttpRouteRequest, CallSettings)
            // Additional: CreateHttpRouteAsync(CreateHttpRouteRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            CreateHttpRouteRequest request = new CreateHttpRouteRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                HttpRouteId = "",
                HttpRoute = new HttpRoute(),
            };
            // Make the request
            Operation<HttpRoute, OperationMetadata> response = await networkServicesClient.CreateHttpRouteAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<HttpRoute, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            HttpRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<HttpRoute, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceCreateHttpRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                HttpRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateHttpRoute</summary>
        public void CreateHttpRoute()
        {
            // Snippet: CreateHttpRoute(string, HttpRoute, string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            HttpRoute httpRoute = new HttpRoute();
            string httpRouteId = "";
            // Make the request
            Operation<HttpRoute, OperationMetadata> response = networkServicesClient.CreateHttpRoute(parent, httpRoute, httpRouteId);

            // Poll until the returned long-running operation is complete
            Operation<HttpRoute, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            HttpRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<HttpRoute, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceCreateHttpRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                HttpRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateHttpRouteAsync</summary>
        public async Task CreateHttpRouteAsync()
        {
            // Snippet: CreateHttpRouteAsync(string, HttpRoute, string, CallSettings)
            // Additional: CreateHttpRouteAsync(string, HttpRoute, string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            HttpRoute httpRoute = new HttpRoute();
            string httpRouteId = "";
            // Make the request
            Operation<HttpRoute, OperationMetadata> response = await networkServicesClient.CreateHttpRouteAsync(parent, httpRoute, httpRouteId);

            // Poll until the returned long-running operation is complete
            Operation<HttpRoute, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            HttpRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<HttpRoute, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceCreateHttpRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                HttpRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateHttpRoute</summary>
        public void CreateHttpRouteResourceNames()
        {
            // Snippet: CreateHttpRoute(LocationName, HttpRoute, string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            HttpRoute httpRoute = new HttpRoute();
            string httpRouteId = "";
            // Make the request
            Operation<HttpRoute, OperationMetadata> response = networkServicesClient.CreateHttpRoute(parent, httpRoute, httpRouteId);

            // Poll until the returned long-running operation is complete
            Operation<HttpRoute, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            HttpRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<HttpRoute, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceCreateHttpRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                HttpRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateHttpRouteAsync</summary>
        public async Task CreateHttpRouteResourceNamesAsync()
        {
            // Snippet: CreateHttpRouteAsync(LocationName, HttpRoute, string, CallSettings)
            // Additional: CreateHttpRouteAsync(LocationName, HttpRoute, string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            HttpRoute httpRoute = new HttpRoute();
            string httpRouteId = "";
            // Make the request
            Operation<HttpRoute, OperationMetadata> response = await networkServicesClient.CreateHttpRouteAsync(parent, httpRoute, httpRouteId);

            // Poll until the returned long-running operation is complete
            Operation<HttpRoute, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            HttpRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<HttpRoute, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceCreateHttpRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                HttpRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateHttpRoute</summary>
        public void UpdateHttpRouteRequestObject()
        {
            // Snippet: UpdateHttpRoute(UpdateHttpRouteRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            UpdateHttpRouteRequest request = new UpdateHttpRouteRequest
            {
                UpdateMask = new FieldMask(),
                HttpRoute = new HttpRoute(),
            };
            // Make the request
            Operation<HttpRoute, OperationMetadata> response = networkServicesClient.UpdateHttpRoute(request);

            // Poll until the returned long-running operation is complete
            Operation<HttpRoute, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            HttpRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<HttpRoute, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceUpdateHttpRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                HttpRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateHttpRouteAsync</summary>
        public async Task UpdateHttpRouteRequestObjectAsync()
        {
            // Snippet: UpdateHttpRouteAsync(UpdateHttpRouteRequest, CallSettings)
            // Additional: UpdateHttpRouteAsync(UpdateHttpRouteRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            UpdateHttpRouteRequest request = new UpdateHttpRouteRequest
            {
                UpdateMask = new FieldMask(),
                HttpRoute = new HttpRoute(),
            };
            // Make the request
            Operation<HttpRoute, OperationMetadata> response = await networkServicesClient.UpdateHttpRouteAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<HttpRoute, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            HttpRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<HttpRoute, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceUpdateHttpRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                HttpRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateHttpRoute</summary>
        public void UpdateHttpRoute()
        {
            // Snippet: UpdateHttpRoute(HttpRoute, FieldMask, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            HttpRoute httpRoute = new HttpRoute();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<HttpRoute, OperationMetadata> response = networkServicesClient.UpdateHttpRoute(httpRoute, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<HttpRoute, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            HttpRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<HttpRoute, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceUpdateHttpRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                HttpRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateHttpRouteAsync</summary>
        public async Task UpdateHttpRouteAsync()
        {
            // Snippet: UpdateHttpRouteAsync(HttpRoute, FieldMask, CallSettings)
            // Additional: UpdateHttpRouteAsync(HttpRoute, FieldMask, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            HttpRoute httpRoute = new HttpRoute();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<HttpRoute, OperationMetadata> response = await networkServicesClient.UpdateHttpRouteAsync(httpRoute, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<HttpRoute, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            HttpRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<HttpRoute, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceUpdateHttpRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                HttpRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteHttpRoute</summary>
        public void DeleteHttpRouteRequestObject()
        {
            // Snippet: DeleteHttpRoute(DeleteHttpRouteRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            DeleteHttpRouteRequest request = new DeleteHttpRouteRequest
            {
                HttpRouteName = HttpRouteName.FromProjectLocationHttpRoute("[PROJECT]", "[LOCATION]", "[HTTP_ROUTE]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = networkServicesClient.DeleteHttpRoute(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceDeleteHttpRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteHttpRouteAsync</summary>
        public async Task DeleteHttpRouteRequestObjectAsync()
        {
            // Snippet: DeleteHttpRouteAsync(DeleteHttpRouteRequest, CallSettings)
            // Additional: DeleteHttpRouteAsync(DeleteHttpRouteRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteHttpRouteRequest request = new DeleteHttpRouteRequest
            {
                HttpRouteName = HttpRouteName.FromProjectLocationHttpRoute("[PROJECT]", "[LOCATION]", "[HTTP_ROUTE]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkServicesClient.DeleteHttpRouteAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceDeleteHttpRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteHttpRoute</summary>
        public void DeleteHttpRoute()
        {
            // Snippet: DeleteHttpRoute(string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/httpRoutes/[HTTP_ROUTE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = networkServicesClient.DeleteHttpRoute(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceDeleteHttpRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteHttpRouteAsync</summary>
        public async Task DeleteHttpRouteAsync()
        {
            // Snippet: DeleteHttpRouteAsync(string, CallSettings)
            // Additional: DeleteHttpRouteAsync(string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/httpRoutes/[HTTP_ROUTE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkServicesClient.DeleteHttpRouteAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceDeleteHttpRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteHttpRoute</summary>
        public void DeleteHttpRouteResourceNames()
        {
            // Snippet: DeleteHttpRoute(HttpRouteName, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            HttpRouteName name = HttpRouteName.FromProjectLocationHttpRoute("[PROJECT]", "[LOCATION]", "[HTTP_ROUTE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = networkServicesClient.DeleteHttpRoute(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceDeleteHttpRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteHttpRouteAsync</summary>
        public async Task DeleteHttpRouteResourceNamesAsync()
        {
            // Snippet: DeleteHttpRouteAsync(HttpRouteName, CallSettings)
            // Additional: DeleteHttpRouteAsync(HttpRouteName, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            HttpRouteName name = HttpRouteName.FromProjectLocationHttpRoute("[PROJECT]", "[LOCATION]", "[HTTP_ROUTE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkServicesClient.DeleteHttpRouteAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceDeleteHttpRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListTcpRoutes</summary>
        public void ListTcpRoutesRequestObject()
        {
            // Snippet: ListTcpRoutes(ListTcpRoutesRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            ListTcpRoutesRequest request = new ListTcpRoutesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<ListTcpRoutesResponse, TcpRoute> response = networkServicesClient.ListTcpRoutes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TcpRoute item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTcpRoutesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TcpRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TcpRoute> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TcpRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTcpRoutesAsync</summary>
        public async Task ListTcpRoutesRequestObjectAsync()
        {
            // Snippet: ListTcpRoutesAsync(ListTcpRoutesRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            ListTcpRoutesRequest request = new ListTcpRoutesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<ListTcpRoutesResponse, TcpRoute> response = networkServicesClient.ListTcpRoutesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TcpRoute item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTcpRoutesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TcpRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TcpRoute> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TcpRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTcpRoutes</summary>
        public void ListTcpRoutes()
        {
            // Snippet: ListTcpRoutes(string, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListTcpRoutesResponse, TcpRoute> response = networkServicesClient.ListTcpRoutes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TcpRoute item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTcpRoutesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TcpRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TcpRoute> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TcpRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTcpRoutesAsync</summary>
        public async Task ListTcpRoutesAsync()
        {
            // Snippet: ListTcpRoutesAsync(string, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListTcpRoutesResponse, TcpRoute> response = networkServicesClient.ListTcpRoutesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TcpRoute item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTcpRoutesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TcpRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TcpRoute> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TcpRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTcpRoutes</summary>
        public void ListTcpRoutesResourceNames()
        {
            // Snippet: ListTcpRoutes(LocationName, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListTcpRoutesResponse, TcpRoute> response = networkServicesClient.ListTcpRoutes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TcpRoute item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTcpRoutesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TcpRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TcpRoute> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TcpRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTcpRoutesAsync</summary>
        public async Task ListTcpRoutesResourceNamesAsync()
        {
            // Snippet: ListTcpRoutesAsync(LocationName, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListTcpRoutesResponse, TcpRoute> response = networkServicesClient.ListTcpRoutesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TcpRoute item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTcpRoutesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TcpRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TcpRoute> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TcpRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetTcpRoute</summary>
        public void GetTcpRouteRequestObject()
        {
            // Snippet: GetTcpRoute(GetTcpRouteRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            GetTcpRouteRequest request = new GetTcpRouteRequest
            {
                TcpRouteName = TcpRouteName.FromProjectLocationTcpRoute("[PROJECT]", "[LOCATION]", "[TCP_ROUTE]"),
            };
            // Make the request
            TcpRoute response = networkServicesClient.GetTcpRoute(request);
            // End snippet
        }

        /// <summary>Snippet for GetTcpRouteAsync</summary>
        public async Task GetTcpRouteRequestObjectAsync()
        {
            // Snippet: GetTcpRouteAsync(GetTcpRouteRequest, CallSettings)
            // Additional: GetTcpRouteAsync(GetTcpRouteRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            GetTcpRouteRequest request = new GetTcpRouteRequest
            {
                TcpRouteName = TcpRouteName.FromProjectLocationTcpRoute("[PROJECT]", "[LOCATION]", "[TCP_ROUTE]"),
            };
            // Make the request
            TcpRoute response = await networkServicesClient.GetTcpRouteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTcpRoute</summary>
        public void GetTcpRoute()
        {
            // Snippet: GetTcpRoute(string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tcpRoutes/[TCP_ROUTE]";
            // Make the request
            TcpRoute response = networkServicesClient.GetTcpRoute(name);
            // End snippet
        }

        /// <summary>Snippet for GetTcpRouteAsync</summary>
        public async Task GetTcpRouteAsync()
        {
            // Snippet: GetTcpRouteAsync(string, CallSettings)
            // Additional: GetTcpRouteAsync(string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tcpRoutes/[TCP_ROUTE]";
            // Make the request
            TcpRoute response = await networkServicesClient.GetTcpRouteAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTcpRoute</summary>
        public void GetTcpRouteResourceNames()
        {
            // Snippet: GetTcpRoute(TcpRouteName, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            TcpRouteName name = TcpRouteName.FromProjectLocationTcpRoute("[PROJECT]", "[LOCATION]", "[TCP_ROUTE]");
            // Make the request
            TcpRoute response = networkServicesClient.GetTcpRoute(name);
            // End snippet
        }

        /// <summary>Snippet for GetTcpRouteAsync</summary>
        public async Task GetTcpRouteResourceNamesAsync()
        {
            // Snippet: GetTcpRouteAsync(TcpRouteName, CallSettings)
            // Additional: GetTcpRouteAsync(TcpRouteName, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            TcpRouteName name = TcpRouteName.FromProjectLocationTcpRoute("[PROJECT]", "[LOCATION]", "[TCP_ROUTE]");
            // Make the request
            TcpRoute response = await networkServicesClient.GetTcpRouteAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateTcpRoute</summary>
        public void CreateTcpRouteRequestObject()
        {
            // Snippet: CreateTcpRoute(CreateTcpRouteRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            CreateTcpRouteRequest request = new CreateTcpRouteRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TcpRouteId = "",
                TcpRoute = new TcpRoute(),
            };
            // Make the request
            Operation<TcpRoute, OperationMetadata> response = networkServicesClient.CreateTcpRoute(request);

            // Poll until the returned long-running operation is complete
            Operation<TcpRoute, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TcpRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TcpRoute, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceCreateTcpRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TcpRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTcpRouteAsync</summary>
        public async Task CreateTcpRouteRequestObjectAsync()
        {
            // Snippet: CreateTcpRouteAsync(CreateTcpRouteRequest, CallSettings)
            // Additional: CreateTcpRouteAsync(CreateTcpRouteRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            CreateTcpRouteRequest request = new CreateTcpRouteRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TcpRouteId = "",
                TcpRoute = new TcpRoute(),
            };
            // Make the request
            Operation<TcpRoute, OperationMetadata> response = await networkServicesClient.CreateTcpRouteAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<TcpRoute, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TcpRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TcpRoute, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceCreateTcpRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TcpRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTcpRoute</summary>
        public void CreateTcpRoute()
        {
            // Snippet: CreateTcpRoute(string, TcpRoute, string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            TcpRoute tcpRoute = new TcpRoute();
            string tcpRouteId = "";
            // Make the request
            Operation<TcpRoute, OperationMetadata> response = networkServicesClient.CreateTcpRoute(parent, tcpRoute, tcpRouteId);

            // Poll until the returned long-running operation is complete
            Operation<TcpRoute, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TcpRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TcpRoute, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceCreateTcpRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TcpRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTcpRouteAsync</summary>
        public async Task CreateTcpRouteAsync()
        {
            // Snippet: CreateTcpRouteAsync(string, TcpRoute, string, CallSettings)
            // Additional: CreateTcpRouteAsync(string, TcpRoute, string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            TcpRoute tcpRoute = new TcpRoute();
            string tcpRouteId = "";
            // Make the request
            Operation<TcpRoute, OperationMetadata> response = await networkServicesClient.CreateTcpRouteAsync(parent, tcpRoute, tcpRouteId);

            // Poll until the returned long-running operation is complete
            Operation<TcpRoute, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TcpRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TcpRoute, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceCreateTcpRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TcpRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTcpRoute</summary>
        public void CreateTcpRouteResourceNames()
        {
            // Snippet: CreateTcpRoute(LocationName, TcpRoute, string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            TcpRoute tcpRoute = new TcpRoute();
            string tcpRouteId = "";
            // Make the request
            Operation<TcpRoute, OperationMetadata> response = networkServicesClient.CreateTcpRoute(parent, tcpRoute, tcpRouteId);

            // Poll until the returned long-running operation is complete
            Operation<TcpRoute, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TcpRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TcpRoute, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceCreateTcpRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TcpRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTcpRouteAsync</summary>
        public async Task CreateTcpRouteResourceNamesAsync()
        {
            // Snippet: CreateTcpRouteAsync(LocationName, TcpRoute, string, CallSettings)
            // Additional: CreateTcpRouteAsync(LocationName, TcpRoute, string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            TcpRoute tcpRoute = new TcpRoute();
            string tcpRouteId = "";
            // Make the request
            Operation<TcpRoute, OperationMetadata> response = await networkServicesClient.CreateTcpRouteAsync(parent, tcpRoute, tcpRouteId);

            // Poll until the returned long-running operation is complete
            Operation<TcpRoute, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TcpRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TcpRoute, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceCreateTcpRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TcpRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTcpRoute</summary>
        public void UpdateTcpRouteRequestObject()
        {
            // Snippet: UpdateTcpRoute(UpdateTcpRouteRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            UpdateTcpRouteRequest request = new UpdateTcpRouteRequest
            {
                UpdateMask = new FieldMask(),
                TcpRoute = new TcpRoute(),
            };
            // Make the request
            Operation<TcpRoute, OperationMetadata> response = networkServicesClient.UpdateTcpRoute(request);

            // Poll until the returned long-running operation is complete
            Operation<TcpRoute, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TcpRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TcpRoute, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceUpdateTcpRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TcpRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTcpRouteAsync</summary>
        public async Task UpdateTcpRouteRequestObjectAsync()
        {
            // Snippet: UpdateTcpRouteAsync(UpdateTcpRouteRequest, CallSettings)
            // Additional: UpdateTcpRouteAsync(UpdateTcpRouteRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTcpRouteRequest request = new UpdateTcpRouteRequest
            {
                UpdateMask = new FieldMask(),
                TcpRoute = new TcpRoute(),
            };
            // Make the request
            Operation<TcpRoute, OperationMetadata> response = await networkServicesClient.UpdateTcpRouteAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<TcpRoute, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TcpRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TcpRoute, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceUpdateTcpRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TcpRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTcpRoute</summary>
        public void UpdateTcpRoute()
        {
            // Snippet: UpdateTcpRoute(TcpRoute, FieldMask, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            TcpRoute tcpRoute = new TcpRoute();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<TcpRoute, OperationMetadata> response = networkServicesClient.UpdateTcpRoute(tcpRoute, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<TcpRoute, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TcpRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TcpRoute, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceUpdateTcpRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TcpRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTcpRouteAsync</summary>
        public async Task UpdateTcpRouteAsync()
        {
            // Snippet: UpdateTcpRouteAsync(TcpRoute, FieldMask, CallSettings)
            // Additional: UpdateTcpRouteAsync(TcpRoute, FieldMask, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            TcpRoute tcpRoute = new TcpRoute();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<TcpRoute, OperationMetadata> response = await networkServicesClient.UpdateTcpRouteAsync(tcpRoute, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<TcpRoute, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TcpRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TcpRoute, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceUpdateTcpRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TcpRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTcpRoute</summary>
        public void DeleteTcpRouteRequestObject()
        {
            // Snippet: DeleteTcpRoute(DeleteTcpRouteRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            DeleteTcpRouteRequest request = new DeleteTcpRouteRequest
            {
                TcpRouteName = TcpRouteName.FromProjectLocationTcpRoute("[PROJECT]", "[LOCATION]", "[TCP_ROUTE]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = networkServicesClient.DeleteTcpRoute(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceDeleteTcpRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTcpRouteAsync</summary>
        public async Task DeleteTcpRouteRequestObjectAsync()
        {
            // Snippet: DeleteTcpRouteAsync(DeleteTcpRouteRequest, CallSettings)
            // Additional: DeleteTcpRouteAsync(DeleteTcpRouteRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTcpRouteRequest request = new DeleteTcpRouteRequest
            {
                TcpRouteName = TcpRouteName.FromProjectLocationTcpRoute("[PROJECT]", "[LOCATION]", "[TCP_ROUTE]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkServicesClient.DeleteTcpRouteAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceDeleteTcpRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTcpRoute</summary>
        public void DeleteTcpRoute()
        {
            // Snippet: DeleteTcpRoute(string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tcpRoutes/[TCP_ROUTE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = networkServicesClient.DeleteTcpRoute(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceDeleteTcpRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTcpRouteAsync</summary>
        public async Task DeleteTcpRouteAsync()
        {
            // Snippet: DeleteTcpRouteAsync(string, CallSettings)
            // Additional: DeleteTcpRouteAsync(string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tcpRoutes/[TCP_ROUTE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkServicesClient.DeleteTcpRouteAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceDeleteTcpRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTcpRoute</summary>
        public void DeleteTcpRouteResourceNames()
        {
            // Snippet: DeleteTcpRoute(TcpRouteName, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            TcpRouteName name = TcpRouteName.FromProjectLocationTcpRoute("[PROJECT]", "[LOCATION]", "[TCP_ROUTE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = networkServicesClient.DeleteTcpRoute(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceDeleteTcpRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTcpRouteAsync</summary>
        public async Task DeleteTcpRouteResourceNamesAsync()
        {
            // Snippet: DeleteTcpRouteAsync(TcpRouteName, CallSettings)
            // Additional: DeleteTcpRouteAsync(TcpRouteName, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            TcpRouteName name = TcpRouteName.FromProjectLocationTcpRoute("[PROJECT]", "[LOCATION]", "[TCP_ROUTE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkServicesClient.DeleteTcpRouteAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceDeleteTcpRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListTlsRoutes</summary>
        public void ListTlsRoutesRequestObject()
        {
            // Snippet: ListTlsRoutes(ListTlsRoutesRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            ListTlsRoutesRequest request = new ListTlsRoutesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<ListTlsRoutesResponse, TlsRoute> response = networkServicesClient.ListTlsRoutes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TlsRoute item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTlsRoutesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TlsRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TlsRoute> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TlsRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTlsRoutesAsync</summary>
        public async Task ListTlsRoutesRequestObjectAsync()
        {
            // Snippet: ListTlsRoutesAsync(ListTlsRoutesRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            ListTlsRoutesRequest request = new ListTlsRoutesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<ListTlsRoutesResponse, TlsRoute> response = networkServicesClient.ListTlsRoutesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TlsRoute item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTlsRoutesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TlsRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TlsRoute> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TlsRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTlsRoutes</summary>
        public void ListTlsRoutes()
        {
            // Snippet: ListTlsRoutes(string, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListTlsRoutesResponse, TlsRoute> response = networkServicesClient.ListTlsRoutes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TlsRoute item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTlsRoutesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TlsRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TlsRoute> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TlsRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTlsRoutesAsync</summary>
        public async Task ListTlsRoutesAsync()
        {
            // Snippet: ListTlsRoutesAsync(string, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListTlsRoutesResponse, TlsRoute> response = networkServicesClient.ListTlsRoutesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TlsRoute item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTlsRoutesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TlsRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TlsRoute> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TlsRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTlsRoutes</summary>
        public void ListTlsRoutesResourceNames()
        {
            // Snippet: ListTlsRoutes(LocationName, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListTlsRoutesResponse, TlsRoute> response = networkServicesClient.ListTlsRoutes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TlsRoute item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTlsRoutesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TlsRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TlsRoute> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TlsRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTlsRoutesAsync</summary>
        public async Task ListTlsRoutesResourceNamesAsync()
        {
            // Snippet: ListTlsRoutesAsync(LocationName, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListTlsRoutesResponse, TlsRoute> response = networkServicesClient.ListTlsRoutesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TlsRoute item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTlsRoutesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TlsRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TlsRoute> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TlsRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetTlsRoute</summary>
        public void GetTlsRouteRequestObject()
        {
            // Snippet: GetTlsRoute(GetTlsRouteRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            GetTlsRouteRequest request = new GetTlsRouteRequest
            {
                TlsRouteName = TlsRouteName.FromProjectLocationTlsRoute("[PROJECT]", "[LOCATION]", "[TLS_ROUTE]"),
            };
            // Make the request
            TlsRoute response = networkServicesClient.GetTlsRoute(request);
            // End snippet
        }

        /// <summary>Snippet for GetTlsRouteAsync</summary>
        public async Task GetTlsRouteRequestObjectAsync()
        {
            // Snippet: GetTlsRouteAsync(GetTlsRouteRequest, CallSettings)
            // Additional: GetTlsRouteAsync(GetTlsRouteRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            GetTlsRouteRequest request = new GetTlsRouteRequest
            {
                TlsRouteName = TlsRouteName.FromProjectLocationTlsRoute("[PROJECT]", "[LOCATION]", "[TLS_ROUTE]"),
            };
            // Make the request
            TlsRoute response = await networkServicesClient.GetTlsRouteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTlsRoute</summary>
        public void GetTlsRoute()
        {
            // Snippet: GetTlsRoute(string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tlsRoutes/[TLS_ROUTE]";
            // Make the request
            TlsRoute response = networkServicesClient.GetTlsRoute(name);
            // End snippet
        }

        /// <summary>Snippet for GetTlsRouteAsync</summary>
        public async Task GetTlsRouteAsync()
        {
            // Snippet: GetTlsRouteAsync(string, CallSettings)
            // Additional: GetTlsRouteAsync(string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tlsRoutes/[TLS_ROUTE]";
            // Make the request
            TlsRoute response = await networkServicesClient.GetTlsRouteAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTlsRoute</summary>
        public void GetTlsRouteResourceNames()
        {
            // Snippet: GetTlsRoute(TlsRouteName, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            TlsRouteName name = TlsRouteName.FromProjectLocationTlsRoute("[PROJECT]", "[LOCATION]", "[TLS_ROUTE]");
            // Make the request
            TlsRoute response = networkServicesClient.GetTlsRoute(name);
            // End snippet
        }

        /// <summary>Snippet for GetTlsRouteAsync</summary>
        public async Task GetTlsRouteResourceNamesAsync()
        {
            // Snippet: GetTlsRouteAsync(TlsRouteName, CallSettings)
            // Additional: GetTlsRouteAsync(TlsRouteName, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            TlsRouteName name = TlsRouteName.FromProjectLocationTlsRoute("[PROJECT]", "[LOCATION]", "[TLS_ROUTE]");
            // Make the request
            TlsRoute response = await networkServicesClient.GetTlsRouteAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateTlsRoute</summary>
        public void CreateTlsRouteRequestObject()
        {
            // Snippet: CreateTlsRoute(CreateTlsRouteRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            CreateTlsRouteRequest request = new CreateTlsRouteRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TlsRouteId = "",
                TlsRoute = new TlsRoute(),
            };
            // Make the request
            Operation<TlsRoute, OperationMetadata> response = networkServicesClient.CreateTlsRoute(request);

            // Poll until the returned long-running operation is complete
            Operation<TlsRoute, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TlsRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TlsRoute, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceCreateTlsRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TlsRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTlsRouteAsync</summary>
        public async Task CreateTlsRouteRequestObjectAsync()
        {
            // Snippet: CreateTlsRouteAsync(CreateTlsRouteRequest, CallSettings)
            // Additional: CreateTlsRouteAsync(CreateTlsRouteRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            CreateTlsRouteRequest request = new CreateTlsRouteRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TlsRouteId = "",
                TlsRoute = new TlsRoute(),
            };
            // Make the request
            Operation<TlsRoute, OperationMetadata> response = await networkServicesClient.CreateTlsRouteAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<TlsRoute, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TlsRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TlsRoute, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceCreateTlsRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TlsRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTlsRoute</summary>
        public void CreateTlsRoute()
        {
            // Snippet: CreateTlsRoute(string, TlsRoute, string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            TlsRoute tlsRoute = new TlsRoute();
            string tlsRouteId = "";
            // Make the request
            Operation<TlsRoute, OperationMetadata> response = networkServicesClient.CreateTlsRoute(parent, tlsRoute, tlsRouteId);

            // Poll until the returned long-running operation is complete
            Operation<TlsRoute, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TlsRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TlsRoute, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceCreateTlsRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TlsRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTlsRouteAsync</summary>
        public async Task CreateTlsRouteAsync()
        {
            // Snippet: CreateTlsRouteAsync(string, TlsRoute, string, CallSettings)
            // Additional: CreateTlsRouteAsync(string, TlsRoute, string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            TlsRoute tlsRoute = new TlsRoute();
            string tlsRouteId = "";
            // Make the request
            Operation<TlsRoute, OperationMetadata> response = await networkServicesClient.CreateTlsRouteAsync(parent, tlsRoute, tlsRouteId);

            // Poll until the returned long-running operation is complete
            Operation<TlsRoute, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TlsRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TlsRoute, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceCreateTlsRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TlsRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTlsRoute</summary>
        public void CreateTlsRouteResourceNames()
        {
            // Snippet: CreateTlsRoute(LocationName, TlsRoute, string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            TlsRoute tlsRoute = new TlsRoute();
            string tlsRouteId = "";
            // Make the request
            Operation<TlsRoute, OperationMetadata> response = networkServicesClient.CreateTlsRoute(parent, tlsRoute, tlsRouteId);

            // Poll until the returned long-running operation is complete
            Operation<TlsRoute, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TlsRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TlsRoute, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceCreateTlsRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TlsRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTlsRouteAsync</summary>
        public async Task CreateTlsRouteResourceNamesAsync()
        {
            // Snippet: CreateTlsRouteAsync(LocationName, TlsRoute, string, CallSettings)
            // Additional: CreateTlsRouteAsync(LocationName, TlsRoute, string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            TlsRoute tlsRoute = new TlsRoute();
            string tlsRouteId = "";
            // Make the request
            Operation<TlsRoute, OperationMetadata> response = await networkServicesClient.CreateTlsRouteAsync(parent, tlsRoute, tlsRouteId);

            // Poll until the returned long-running operation is complete
            Operation<TlsRoute, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TlsRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TlsRoute, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceCreateTlsRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TlsRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTlsRoute</summary>
        public void UpdateTlsRouteRequestObject()
        {
            // Snippet: UpdateTlsRoute(UpdateTlsRouteRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            UpdateTlsRouteRequest request = new UpdateTlsRouteRequest
            {
                UpdateMask = new FieldMask(),
                TlsRoute = new TlsRoute(),
            };
            // Make the request
            Operation<TlsRoute, OperationMetadata> response = networkServicesClient.UpdateTlsRoute(request);

            // Poll until the returned long-running operation is complete
            Operation<TlsRoute, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TlsRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TlsRoute, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceUpdateTlsRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TlsRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTlsRouteAsync</summary>
        public async Task UpdateTlsRouteRequestObjectAsync()
        {
            // Snippet: UpdateTlsRouteAsync(UpdateTlsRouteRequest, CallSettings)
            // Additional: UpdateTlsRouteAsync(UpdateTlsRouteRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTlsRouteRequest request = new UpdateTlsRouteRequest
            {
                UpdateMask = new FieldMask(),
                TlsRoute = new TlsRoute(),
            };
            // Make the request
            Operation<TlsRoute, OperationMetadata> response = await networkServicesClient.UpdateTlsRouteAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<TlsRoute, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TlsRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TlsRoute, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceUpdateTlsRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TlsRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTlsRoute</summary>
        public void UpdateTlsRoute()
        {
            // Snippet: UpdateTlsRoute(TlsRoute, FieldMask, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            TlsRoute tlsRoute = new TlsRoute();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<TlsRoute, OperationMetadata> response = networkServicesClient.UpdateTlsRoute(tlsRoute, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<TlsRoute, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TlsRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TlsRoute, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceUpdateTlsRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TlsRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTlsRouteAsync</summary>
        public async Task UpdateTlsRouteAsync()
        {
            // Snippet: UpdateTlsRouteAsync(TlsRoute, FieldMask, CallSettings)
            // Additional: UpdateTlsRouteAsync(TlsRoute, FieldMask, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            TlsRoute tlsRoute = new TlsRoute();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<TlsRoute, OperationMetadata> response = await networkServicesClient.UpdateTlsRouteAsync(tlsRoute, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<TlsRoute, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TlsRoute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TlsRoute, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceUpdateTlsRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TlsRoute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTlsRoute</summary>
        public void DeleteTlsRouteRequestObject()
        {
            // Snippet: DeleteTlsRoute(DeleteTlsRouteRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            DeleteTlsRouteRequest request = new DeleteTlsRouteRequest
            {
                TlsRouteName = TlsRouteName.FromProjectLocationTlsRoute("[PROJECT]", "[LOCATION]", "[TLS_ROUTE]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = networkServicesClient.DeleteTlsRoute(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceDeleteTlsRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTlsRouteAsync</summary>
        public async Task DeleteTlsRouteRequestObjectAsync()
        {
            // Snippet: DeleteTlsRouteAsync(DeleteTlsRouteRequest, CallSettings)
            // Additional: DeleteTlsRouteAsync(DeleteTlsRouteRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTlsRouteRequest request = new DeleteTlsRouteRequest
            {
                TlsRouteName = TlsRouteName.FromProjectLocationTlsRoute("[PROJECT]", "[LOCATION]", "[TLS_ROUTE]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkServicesClient.DeleteTlsRouteAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceDeleteTlsRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTlsRoute</summary>
        public void DeleteTlsRoute()
        {
            // Snippet: DeleteTlsRoute(string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tlsRoutes/[TLS_ROUTE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = networkServicesClient.DeleteTlsRoute(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceDeleteTlsRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTlsRouteAsync</summary>
        public async Task DeleteTlsRouteAsync()
        {
            // Snippet: DeleteTlsRouteAsync(string, CallSettings)
            // Additional: DeleteTlsRouteAsync(string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tlsRoutes/[TLS_ROUTE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkServicesClient.DeleteTlsRouteAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceDeleteTlsRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTlsRoute</summary>
        public void DeleteTlsRouteResourceNames()
        {
            // Snippet: DeleteTlsRoute(TlsRouteName, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            TlsRouteName name = TlsRouteName.FromProjectLocationTlsRoute("[PROJECT]", "[LOCATION]", "[TLS_ROUTE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = networkServicesClient.DeleteTlsRoute(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceDeleteTlsRoute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTlsRouteAsync</summary>
        public async Task DeleteTlsRouteResourceNamesAsync()
        {
            // Snippet: DeleteTlsRouteAsync(TlsRouteName, CallSettings)
            // Additional: DeleteTlsRouteAsync(TlsRouteName, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            TlsRouteName name = TlsRouteName.FromProjectLocationTlsRoute("[PROJECT]", "[LOCATION]", "[TLS_ROUTE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkServicesClient.DeleteTlsRouteAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceDeleteTlsRouteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListServiceBindings</summary>
        public void ListServiceBindingsRequestObject()
        {
            // Snippet: ListServiceBindings(ListServiceBindingsRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            ListServiceBindingsRequest request = new ListServiceBindingsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListServiceBindingsResponse, ServiceBinding> response = networkServicesClient.ListServiceBindings(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ServiceBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServiceBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceBinding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceBindingsAsync</summary>
        public async Task ListServiceBindingsRequestObjectAsync()
        {
            // Snippet: ListServiceBindingsAsync(ListServiceBindingsRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            ListServiceBindingsRequest request = new ListServiceBindingsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListServiceBindingsResponse, ServiceBinding> response = networkServicesClient.ListServiceBindingsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ServiceBinding item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServiceBindingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceBinding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceBindings</summary>
        public void ListServiceBindings()
        {
            // Snippet: ListServiceBindings(string, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListServiceBindingsResponse, ServiceBinding> response = networkServicesClient.ListServiceBindings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ServiceBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServiceBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceBinding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceBindingsAsync</summary>
        public async Task ListServiceBindingsAsync()
        {
            // Snippet: ListServiceBindingsAsync(string, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListServiceBindingsResponse, ServiceBinding> response = networkServicesClient.ListServiceBindingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ServiceBinding item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServiceBindingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceBinding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceBindings</summary>
        public void ListServiceBindingsResourceNames()
        {
            // Snippet: ListServiceBindings(LocationName, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListServiceBindingsResponse, ServiceBinding> response = networkServicesClient.ListServiceBindings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ServiceBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServiceBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceBinding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceBindingsAsync</summary>
        public async Task ListServiceBindingsResourceNamesAsync()
        {
            // Snippet: ListServiceBindingsAsync(LocationName, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListServiceBindingsResponse, ServiceBinding> response = networkServicesClient.ListServiceBindingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ServiceBinding item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServiceBindingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceBinding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetServiceBinding</summary>
        public void GetServiceBindingRequestObject()
        {
            // Snippet: GetServiceBinding(GetServiceBindingRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            GetServiceBindingRequest request = new GetServiceBindingRequest
            {
                ServiceBindingName = ServiceBindingName.FromProjectLocationServiceBinding("[PROJECT]", "[LOCATION]", "[SERVICE_BINDING]"),
            };
            // Make the request
            ServiceBinding response = networkServicesClient.GetServiceBinding(request);
            // End snippet
        }

        /// <summary>Snippet for GetServiceBindingAsync</summary>
        public async Task GetServiceBindingRequestObjectAsync()
        {
            // Snippet: GetServiceBindingAsync(GetServiceBindingRequest, CallSettings)
            // Additional: GetServiceBindingAsync(GetServiceBindingRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            GetServiceBindingRequest request = new GetServiceBindingRequest
            {
                ServiceBindingName = ServiceBindingName.FromProjectLocationServiceBinding("[PROJECT]", "[LOCATION]", "[SERVICE_BINDING]"),
            };
            // Make the request
            ServiceBinding response = await networkServicesClient.GetServiceBindingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetServiceBinding</summary>
        public void GetServiceBinding()
        {
            // Snippet: GetServiceBinding(string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/serviceBindings/[SERVICE_BINDING]";
            // Make the request
            ServiceBinding response = networkServicesClient.GetServiceBinding(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceBindingAsync</summary>
        public async Task GetServiceBindingAsync()
        {
            // Snippet: GetServiceBindingAsync(string, CallSettings)
            // Additional: GetServiceBindingAsync(string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/serviceBindings/[SERVICE_BINDING]";
            // Make the request
            ServiceBinding response = await networkServicesClient.GetServiceBindingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceBinding</summary>
        public void GetServiceBindingResourceNames()
        {
            // Snippet: GetServiceBinding(ServiceBindingName, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            ServiceBindingName name = ServiceBindingName.FromProjectLocationServiceBinding("[PROJECT]", "[LOCATION]", "[SERVICE_BINDING]");
            // Make the request
            ServiceBinding response = networkServicesClient.GetServiceBinding(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceBindingAsync</summary>
        public async Task GetServiceBindingResourceNamesAsync()
        {
            // Snippet: GetServiceBindingAsync(ServiceBindingName, CallSettings)
            // Additional: GetServiceBindingAsync(ServiceBindingName, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            ServiceBindingName name = ServiceBindingName.FromProjectLocationServiceBinding("[PROJECT]", "[LOCATION]", "[SERVICE_BINDING]");
            // Make the request
            ServiceBinding response = await networkServicesClient.GetServiceBindingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceBinding</summary>
        public void CreateServiceBindingRequestObject()
        {
            // Snippet: CreateServiceBinding(CreateServiceBindingRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            CreateServiceBindingRequest request = new CreateServiceBindingRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ServiceBindingId = "",
                ServiceBinding = new ServiceBinding(),
            };
            // Make the request
            Operation<ServiceBinding, OperationMetadata> response = networkServicesClient.CreateServiceBinding(request);

            // Poll until the returned long-running operation is complete
            Operation<ServiceBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ServiceBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceBinding, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceCreateServiceBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceBindingAsync</summary>
        public async Task CreateServiceBindingRequestObjectAsync()
        {
            // Snippet: CreateServiceBindingAsync(CreateServiceBindingRequest, CallSettings)
            // Additional: CreateServiceBindingAsync(CreateServiceBindingRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            CreateServiceBindingRequest request = new CreateServiceBindingRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ServiceBindingId = "",
                ServiceBinding = new ServiceBinding(),
            };
            // Make the request
            Operation<ServiceBinding, OperationMetadata> response = await networkServicesClient.CreateServiceBindingAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ServiceBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ServiceBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceBinding, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceCreateServiceBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceBinding</summary>
        public void CreateServiceBinding()
        {
            // Snippet: CreateServiceBinding(string, ServiceBinding, string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ServiceBinding serviceBinding = new ServiceBinding();
            string serviceBindingId = "";
            // Make the request
            Operation<ServiceBinding, OperationMetadata> response = networkServicesClient.CreateServiceBinding(parent, serviceBinding, serviceBindingId);

            // Poll until the returned long-running operation is complete
            Operation<ServiceBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ServiceBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceBinding, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceCreateServiceBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceBindingAsync</summary>
        public async Task CreateServiceBindingAsync()
        {
            // Snippet: CreateServiceBindingAsync(string, ServiceBinding, string, CallSettings)
            // Additional: CreateServiceBindingAsync(string, ServiceBinding, string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ServiceBinding serviceBinding = new ServiceBinding();
            string serviceBindingId = "";
            // Make the request
            Operation<ServiceBinding, OperationMetadata> response = await networkServicesClient.CreateServiceBindingAsync(parent, serviceBinding, serviceBindingId);

            // Poll until the returned long-running operation is complete
            Operation<ServiceBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ServiceBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceBinding, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceCreateServiceBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceBinding</summary>
        public void CreateServiceBindingResourceNames()
        {
            // Snippet: CreateServiceBinding(LocationName, ServiceBinding, string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ServiceBinding serviceBinding = new ServiceBinding();
            string serviceBindingId = "";
            // Make the request
            Operation<ServiceBinding, OperationMetadata> response = networkServicesClient.CreateServiceBinding(parent, serviceBinding, serviceBindingId);

            // Poll until the returned long-running operation is complete
            Operation<ServiceBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ServiceBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceBinding, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceCreateServiceBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceBindingAsync</summary>
        public async Task CreateServiceBindingResourceNamesAsync()
        {
            // Snippet: CreateServiceBindingAsync(LocationName, ServiceBinding, string, CallSettings)
            // Additional: CreateServiceBindingAsync(LocationName, ServiceBinding, string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ServiceBinding serviceBinding = new ServiceBinding();
            string serviceBindingId = "";
            // Make the request
            Operation<ServiceBinding, OperationMetadata> response = await networkServicesClient.CreateServiceBindingAsync(parent, serviceBinding, serviceBindingId);

            // Poll until the returned long-running operation is complete
            Operation<ServiceBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ServiceBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceBinding, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceCreateServiceBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceBinding</summary>
        public void UpdateServiceBindingRequestObject()
        {
            // Snippet: UpdateServiceBinding(UpdateServiceBindingRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            UpdateServiceBindingRequest request = new UpdateServiceBindingRequest
            {
                UpdateMask = new FieldMask(),
                ServiceBinding = new ServiceBinding(),
            };
            // Make the request
            Operation<ServiceBinding, OperationMetadata> response = networkServicesClient.UpdateServiceBinding(request);

            // Poll until the returned long-running operation is complete
            Operation<ServiceBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ServiceBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceBinding, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceUpdateServiceBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceBindingAsync</summary>
        public async Task UpdateServiceBindingRequestObjectAsync()
        {
            // Snippet: UpdateServiceBindingAsync(UpdateServiceBindingRequest, CallSettings)
            // Additional: UpdateServiceBindingAsync(UpdateServiceBindingRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            UpdateServiceBindingRequest request = new UpdateServiceBindingRequest
            {
                UpdateMask = new FieldMask(),
                ServiceBinding = new ServiceBinding(),
            };
            // Make the request
            Operation<ServiceBinding, OperationMetadata> response = await networkServicesClient.UpdateServiceBindingAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ServiceBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ServiceBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceBinding, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceUpdateServiceBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceBinding</summary>
        public void UpdateServiceBinding()
        {
            // Snippet: UpdateServiceBinding(ServiceBinding, FieldMask, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            ServiceBinding serviceBinding = new ServiceBinding();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ServiceBinding, OperationMetadata> response = networkServicesClient.UpdateServiceBinding(serviceBinding, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ServiceBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ServiceBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceBinding, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceUpdateServiceBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceBindingAsync</summary>
        public async Task UpdateServiceBindingAsync()
        {
            // Snippet: UpdateServiceBindingAsync(ServiceBinding, FieldMask, CallSettings)
            // Additional: UpdateServiceBindingAsync(ServiceBinding, FieldMask, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            ServiceBinding serviceBinding = new ServiceBinding();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ServiceBinding, OperationMetadata> response = await networkServicesClient.UpdateServiceBindingAsync(serviceBinding, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ServiceBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ServiceBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceBinding, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceUpdateServiceBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceBinding</summary>
        public void DeleteServiceBindingRequestObject()
        {
            // Snippet: DeleteServiceBinding(DeleteServiceBindingRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            DeleteServiceBindingRequest request = new DeleteServiceBindingRequest
            {
                ServiceBindingName = ServiceBindingName.FromProjectLocationServiceBinding("[PROJECT]", "[LOCATION]", "[SERVICE_BINDING]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = networkServicesClient.DeleteServiceBinding(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceDeleteServiceBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceBindingAsync</summary>
        public async Task DeleteServiceBindingRequestObjectAsync()
        {
            // Snippet: DeleteServiceBindingAsync(DeleteServiceBindingRequest, CallSettings)
            // Additional: DeleteServiceBindingAsync(DeleteServiceBindingRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteServiceBindingRequest request = new DeleteServiceBindingRequest
            {
                ServiceBindingName = ServiceBindingName.FromProjectLocationServiceBinding("[PROJECT]", "[LOCATION]", "[SERVICE_BINDING]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkServicesClient.DeleteServiceBindingAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceDeleteServiceBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceBinding</summary>
        public void DeleteServiceBinding()
        {
            // Snippet: DeleteServiceBinding(string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/serviceBindings/[SERVICE_BINDING]";
            // Make the request
            Operation<Empty, OperationMetadata> response = networkServicesClient.DeleteServiceBinding(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceDeleteServiceBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceBindingAsync</summary>
        public async Task DeleteServiceBindingAsync()
        {
            // Snippet: DeleteServiceBindingAsync(string, CallSettings)
            // Additional: DeleteServiceBindingAsync(string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/serviceBindings/[SERVICE_BINDING]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkServicesClient.DeleteServiceBindingAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceDeleteServiceBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceBinding</summary>
        public void DeleteServiceBindingResourceNames()
        {
            // Snippet: DeleteServiceBinding(ServiceBindingName, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            ServiceBindingName name = ServiceBindingName.FromProjectLocationServiceBinding("[PROJECT]", "[LOCATION]", "[SERVICE_BINDING]");
            // Make the request
            Operation<Empty, OperationMetadata> response = networkServicesClient.DeleteServiceBinding(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceDeleteServiceBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceBindingAsync</summary>
        public async Task DeleteServiceBindingResourceNamesAsync()
        {
            // Snippet: DeleteServiceBindingAsync(ServiceBindingName, CallSettings)
            // Additional: DeleteServiceBindingAsync(ServiceBindingName, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            ServiceBindingName name = ServiceBindingName.FromProjectLocationServiceBinding("[PROJECT]", "[LOCATION]", "[SERVICE_BINDING]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkServicesClient.DeleteServiceBindingAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceDeleteServiceBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListMeshes</summary>
        public void ListMeshesRequestObject()
        {
            // Snippet: ListMeshes(ListMeshesRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            ListMeshesRequest request = new ListMeshesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<ListMeshesResponse, Mesh> response = networkServicesClient.ListMeshes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Mesh item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMeshesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Mesh item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Mesh> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Mesh item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMeshesAsync</summary>
        public async Task ListMeshesRequestObjectAsync()
        {
            // Snippet: ListMeshesAsync(ListMeshesRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            ListMeshesRequest request = new ListMeshesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<ListMeshesResponse, Mesh> response = networkServicesClient.ListMeshesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Mesh item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMeshesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Mesh item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Mesh> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Mesh item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMeshes</summary>
        public void ListMeshes()
        {
            // Snippet: ListMeshes(string, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListMeshesResponse, Mesh> response = networkServicesClient.ListMeshes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Mesh item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMeshesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Mesh item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Mesh> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Mesh item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMeshesAsync</summary>
        public async Task ListMeshesAsync()
        {
            // Snippet: ListMeshesAsync(string, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListMeshesResponse, Mesh> response = networkServicesClient.ListMeshesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Mesh item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMeshesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Mesh item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Mesh> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Mesh item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMeshes</summary>
        public void ListMeshesResourceNames()
        {
            // Snippet: ListMeshes(LocationName, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListMeshesResponse, Mesh> response = networkServicesClient.ListMeshes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Mesh item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMeshesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Mesh item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Mesh> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Mesh item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMeshesAsync</summary>
        public async Task ListMeshesResourceNamesAsync()
        {
            // Snippet: ListMeshesAsync(LocationName, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListMeshesResponse, Mesh> response = networkServicesClient.ListMeshesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Mesh item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMeshesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Mesh item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Mesh> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Mesh item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetMesh</summary>
        public void GetMeshRequestObject()
        {
            // Snippet: GetMesh(GetMeshRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            GetMeshRequest request = new GetMeshRequest
            {
                MeshName = MeshName.FromProjectLocationMesh("[PROJECT]", "[LOCATION]", "[MESH]"),
            };
            // Make the request
            Mesh response = networkServicesClient.GetMesh(request);
            // End snippet
        }

        /// <summary>Snippet for GetMeshAsync</summary>
        public async Task GetMeshRequestObjectAsync()
        {
            // Snippet: GetMeshAsync(GetMeshRequest, CallSettings)
            // Additional: GetMeshAsync(GetMeshRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            GetMeshRequest request = new GetMeshRequest
            {
                MeshName = MeshName.FromProjectLocationMesh("[PROJECT]", "[LOCATION]", "[MESH]"),
            };
            // Make the request
            Mesh response = await networkServicesClient.GetMeshAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMesh</summary>
        public void GetMesh()
        {
            // Snippet: GetMesh(string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/meshes/[MESH]";
            // Make the request
            Mesh response = networkServicesClient.GetMesh(name);
            // End snippet
        }

        /// <summary>Snippet for GetMeshAsync</summary>
        public async Task GetMeshAsync()
        {
            // Snippet: GetMeshAsync(string, CallSettings)
            // Additional: GetMeshAsync(string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/meshes/[MESH]";
            // Make the request
            Mesh response = await networkServicesClient.GetMeshAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMesh</summary>
        public void GetMeshResourceNames()
        {
            // Snippet: GetMesh(MeshName, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            MeshName name = MeshName.FromProjectLocationMesh("[PROJECT]", "[LOCATION]", "[MESH]");
            // Make the request
            Mesh response = networkServicesClient.GetMesh(name);
            // End snippet
        }

        /// <summary>Snippet for GetMeshAsync</summary>
        public async Task GetMeshResourceNamesAsync()
        {
            // Snippet: GetMeshAsync(MeshName, CallSettings)
            // Additional: GetMeshAsync(MeshName, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            MeshName name = MeshName.FromProjectLocationMesh("[PROJECT]", "[LOCATION]", "[MESH]");
            // Make the request
            Mesh response = await networkServicesClient.GetMeshAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateMesh</summary>
        public void CreateMeshRequestObject()
        {
            // Snippet: CreateMesh(CreateMeshRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            CreateMeshRequest request = new CreateMeshRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MeshId = "",
                Mesh = new Mesh(),
            };
            // Make the request
            Operation<Mesh, OperationMetadata> response = networkServicesClient.CreateMesh(request);

            // Poll until the returned long-running operation is complete
            Operation<Mesh, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Mesh result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Mesh, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceCreateMesh(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Mesh retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMeshAsync</summary>
        public async Task CreateMeshRequestObjectAsync()
        {
            // Snippet: CreateMeshAsync(CreateMeshRequest, CallSettings)
            // Additional: CreateMeshAsync(CreateMeshRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            CreateMeshRequest request = new CreateMeshRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MeshId = "",
                Mesh = new Mesh(),
            };
            // Make the request
            Operation<Mesh, OperationMetadata> response = await networkServicesClient.CreateMeshAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Mesh, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Mesh result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Mesh, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceCreateMeshAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Mesh retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMesh</summary>
        public void CreateMesh()
        {
            // Snippet: CreateMesh(string, Mesh, string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Mesh mesh = new Mesh();
            string meshId = "";
            // Make the request
            Operation<Mesh, OperationMetadata> response = networkServicesClient.CreateMesh(parent, mesh, meshId);

            // Poll until the returned long-running operation is complete
            Operation<Mesh, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Mesh result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Mesh, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceCreateMesh(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Mesh retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMeshAsync</summary>
        public async Task CreateMeshAsync()
        {
            // Snippet: CreateMeshAsync(string, Mesh, string, CallSettings)
            // Additional: CreateMeshAsync(string, Mesh, string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Mesh mesh = new Mesh();
            string meshId = "";
            // Make the request
            Operation<Mesh, OperationMetadata> response = await networkServicesClient.CreateMeshAsync(parent, mesh, meshId);

            // Poll until the returned long-running operation is complete
            Operation<Mesh, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Mesh result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Mesh, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceCreateMeshAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Mesh retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMesh</summary>
        public void CreateMeshResourceNames()
        {
            // Snippet: CreateMesh(LocationName, Mesh, string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Mesh mesh = new Mesh();
            string meshId = "";
            // Make the request
            Operation<Mesh, OperationMetadata> response = networkServicesClient.CreateMesh(parent, mesh, meshId);

            // Poll until the returned long-running operation is complete
            Operation<Mesh, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Mesh result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Mesh, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceCreateMesh(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Mesh retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMeshAsync</summary>
        public async Task CreateMeshResourceNamesAsync()
        {
            // Snippet: CreateMeshAsync(LocationName, Mesh, string, CallSettings)
            // Additional: CreateMeshAsync(LocationName, Mesh, string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Mesh mesh = new Mesh();
            string meshId = "";
            // Make the request
            Operation<Mesh, OperationMetadata> response = await networkServicesClient.CreateMeshAsync(parent, mesh, meshId);

            // Poll until the returned long-running operation is complete
            Operation<Mesh, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Mesh result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Mesh, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceCreateMeshAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Mesh retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMesh</summary>
        public void UpdateMeshRequestObject()
        {
            // Snippet: UpdateMesh(UpdateMeshRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            UpdateMeshRequest request = new UpdateMeshRequest
            {
                UpdateMask = new FieldMask(),
                Mesh = new Mesh(),
            };
            // Make the request
            Operation<Mesh, OperationMetadata> response = networkServicesClient.UpdateMesh(request);

            // Poll until the returned long-running operation is complete
            Operation<Mesh, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Mesh result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Mesh, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceUpdateMesh(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Mesh retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMeshAsync</summary>
        public async Task UpdateMeshRequestObjectAsync()
        {
            // Snippet: UpdateMeshAsync(UpdateMeshRequest, CallSettings)
            // Additional: UpdateMeshAsync(UpdateMeshRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            UpdateMeshRequest request = new UpdateMeshRequest
            {
                UpdateMask = new FieldMask(),
                Mesh = new Mesh(),
            };
            // Make the request
            Operation<Mesh, OperationMetadata> response = await networkServicesClient.UpdateMeshAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Mesh, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Mesh result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Mesh, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceUpdateMeshAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Mesh retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMesh</summary>
        public void UpdateMesh()
        {
            // Snippet: UpdateMesh(Mesh, FieldMask, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            Mesh mesh = new Mesh();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Mesh, OperationMetadata> response = networkServicesClient.UpdateMesh(mesh, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Mesh, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Mesh result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Mesh, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceUpdateMesh(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Mesh retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMeshAsync</summary>
        public async Task UpdateMeshAsync()
        {
            // Snippet: UpdateMeshAsync(Mesh, FieldMask, CallSettings)
            // Additional: UpdateMeshAsync(Mesh, FieldMask, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            Mesh mesh = new Mesh();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Mesh, OperationMetadata> response = await networkServicesClient.UpdateMeshAsync(mesh, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Mesh, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Mesh result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Mesh, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceUpdateMeshAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Mesh retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMesh</summary>
        public void DeleteMeshRequestObject()
        {
            // Snippet: DeleteMesh(DeleteMeshRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            DeleteMeshRequest request = new DeleteMeshRequest
            {
                MeshName = MeshName.FromProjectLocationMesh("[PROJECT]", "[LOCATION]", "[MESH]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = networkServicesClient.DeleteMesh(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceDeleteMesh(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMeshAsync</summary>
        public async Task DeleteMeshRequestObjectAsync()
        {
            // Snippet: DeleteMeshAsync(DeleteMeshRequest, CallSettings)
            // Additional: DeleteMeshAsync(DeleteMeshRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteMeshRequest request = new DeleteMeshRequest
            {
                MeshName = MeshName.FromProjectLocationMesh("[PROJECT]", "[LOCATION]", "[MESH]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkServicesClient.DeleteMeshAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceDeleteMeshAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMesh</summary>
        public void DeleteMesh()
        {
            // Snippet: DeleteMesh(string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/meshes/[MESH]";
            // Make the request
            Operation<Empty, OperationMetadata> response = networkServicesClient.DeleteMesh(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceDeleteMesh(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMeshAsync</summary>
        public async Task DeleteMeshAsync()
        {
            // Snippet: DeleteMeshAsync(string, CallSettings)
            // Additional: DeleteMeshAsync(string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/meshes/[MESH]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkServicesClient.DeleteMeshAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceDeleteMeshAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMesh</summary>
        public void DeleteMeshResourceNames()
        {
            // Snippet: DeleteMesh(MeshName, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            MeshName name = MeshName.FromProjectLocationMesh("[PROJECT]", "[LOCATION]", "[MESH]");
            // Make the request
            Operation<Empty, OperationMetadata> response = networkServicesClient.DeleteMesh(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceDeleteMesh(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMeshAsync</summary>
        public async Task DeleteMeshResourceNamesAsync()
        {
            // Snippet: DeleteMeshAsync(MeshName, CallSettings)
            // Additional: DeleteMeshAsync(MeshName, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            MeshName name = MeshName.FromProjectLocationMesh("[PROJECT]", "[LOCATION]", "[MESH]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkServicesClient.DeleteMeshAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceDeleteMeshAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListServiceLbPolicies</summary>
        public void ListServiceLbPoliciesRequestObject()
        {
            // Snippet: ListServiceLbPolicies(ListServiceLbPoliciesRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            ListServiceLbPoliciesRequest request = new ListServiceLbPoliciesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListServiceLbPoliciesResponse, ServiceLbPolicy> response = networkServicesClient.ListServiceLbPolicies(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ServiceLbPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServiceLbPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceLbPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceLbPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceLbPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceLbPoliciesAsync</summary>
        public async Task ListServiceLbPoliciesRequestObjectAsync()
        {
            // Snippet: ListServiceLbPoliciesAsync(ListServiceLbPoliciesRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            ListServiceLbPoliciesRequest request = new ListServiceLbPoliciesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListServiceLbPoliciesResponse, ServiceLbPolicy> response = networkServicesClient.ListServiceLbPoliciesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ServiceLbPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServiceLbPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceLbPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceLbPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceLbPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceLbPolicies</summary>
        public void ListServiceLbPolicies()
        {
            // Snippet: ListServiceLbPolicies(string, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListServiceLbPoliciesResponse, ServiceLbPolicy> response = networkServicesClient.ListServiceLbPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ServiceLbPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServiceLbPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceLbPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceLbPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceLbPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceLbPoliciesAsync</summary>
        public async Task ListServiceLbPoliciesAsync()
        {
            // Snippet: ListServiceLbPoliciesAsync(string, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListServiceLbPoliciesResponse, ServiceLbPolicy> response = networkServicesClient.ListServiceLbPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ServiceLbPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServiceLbPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceLbPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceLbPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceLbPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceLbPolicies</summary>
        public void ListServiceLbPoliciesResourceNames()
        {
            // Snippet: ListServiceLbPolicies(LocationName, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListServiceLbPoliciesResponse, ServiceLbPolicy> response = networkServicesClient.ListServiceLbPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ServiceLbPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServiceLbPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceLbPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceLbPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceLbPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceLbPoliciesAsync</summary>
        public async Task ListServiceLbPoliciesResourceNamesAsync()
        {
            // Snippet: ListServiceLbPoliciesAsync(LocationName, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListServiceLbPoliciesResponse, ServiceLbPolicy> response = networkServicesClient.ListServiceLbPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ServiceLbPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServiceLbPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceLbPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceLbPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceLbPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetServiceLbPolicy</summary>
        public void GetServiceLbPolicyRequestObject()
        {
            // Snippet: GetServiceLbPolicy(GetServiceLbPolicyRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            GetServiceLbPolicyRequest request = new GetServiceLbPolicyRequest
            {
                ServiceLbPolicyName = ServiceLbPolicyName.FromProjectLocationServiceLbPolicy("[PROJECT]", "[LOCATION]", "[SERVICE_LB_POLICY]"),
            };
            // Make the request
            ServiceLbPolicy response = networkServicesClient.GetServiceLbPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetServiceLbPolicyAsync</summary>
        public async Task GetServiceLbPolicyRequestObjectAsync()
        {
            // Snippet: GetServiceLbPolicyAsync(GetServiceLbPolicyRequest, CallSettings)
            // Additional: GetServiceLbPolicyAsync(GetServiceLbPolicyRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            GetServiceLbPolicyRequest request = new GetServiceLbPolicyRequest
            {
                ServiceLbPolicyName = ServiceLbPolicyName.FromProjectLocationServiceLbPolicy("[PROJECT]", "[LOCATION]", "[SERVICE_LB_POLICY]"),
            };
            // Make the request
            ServiceLbPolicy response = await networkServicesClient.GetServiceLbPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetServiceLbPolicy</summary>
        public void GetServiceLbPolicy()
        {
            // Snippet: GetServiceLbPolicy(string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/serviceLbPolicies/[SERVICE_LB_POLICY]";
            // Make the request
            ServiceLbPolicy response = networkServicesClient.GetServiceLbPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceLbPolicyAsync</summary>
        public async Task GetServiceLbPolicyAsync()
        {
            // Snippet: GetServiceLbPolicyAsync(string, CallSettings)
            // Additional: GetServiceLbPolicyAsync(string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/serviceLbPolicies/[SERVICE_LB_POLICY]";
            // Make the request
            ServiceLbPolicy response = await networkServicesClient.GetServiceLbPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceLbPolicy</summary>
        public void GetServiceLbPolicyResourceNames()
        {
            // Snippet: GetServiceLbPolicy(ServiceLbPolicyName, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            ServiceLbPolicyName name = ServiceLbPolicyName.FromProjectLocationServiceLbPolicy("[PROJECT]", "[LOCATION]", "[SERVICE_LB_POLICY]");
            // Make the request
            ServiceLbPolicy response = networkServicesClient.GetServiceLbPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceLbPolicyAsync</summary>
        public async Task GetServiceLbPolicyResourceNamesAsync()
        {
            // Snippet: GetServiceLbPolicyAsync(ServiceLbPolicyName, CallSettings)
            // Additional: GetServiceLbPolicyAsync(ServiceLbPolicyName, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            ServiceLbPolicyName name = ServiceLbPolicyName.FromProjectLocationServiceLbPolicy("[PROJECT]", "[LOCATION]", "[SERVICE_LB_POLICY]");
            // Make the request
            ServiceLbPolicy response = await networkServicesClient.GetServiceLbPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceLbPolicy</summary>
        public void CreateServiceLbPolicyRequestObject()
        {
            // Snippet: CreateServiceLbPolicy(CreateServiceLbPolicyRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            CreateServiceLbPolicyRequest request = new CreateServiceLbPolicyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ServiceLbPolicyId = "",
                ServiceLbPolicy = new ServiceLbPolicy(),
            };
            // Make the request
            Operation<ServiceLbPolicy, OperationMetadata> response = networkServicesClient.CreateServiceLbPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<ServiceLbPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ServiceLbPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceLbPolicy, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceCreateServiceLbPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceLbPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceLbPolicyAsync</summary>
        public async Task CreateServiceLbPolicyRequestObjectAsync()
        {
            // Snippet: CreateServiceLbPolicyAsync(CreateServiceLbPolicyRequest, CallSettings)
            // Additional: CreateServiceLbPolicyAsync(CreateServiceLbPolicyRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            CreateServiceLbPolicyRequest request = new CreateServiceLbPolicyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ServiceLbPolicyId = "",
                ServiceLbPolicy = new ServiceLbPolicy(),
            };
            // Make the request
            Operation<ServiceLbPolicy, OperationMetadata> response = await networkServicesClient.CreateServiceLbPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ServiceLbPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ServiceLbPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceLbPolicy, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceCreateServiceLbPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceLbPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceLbPolicy</summary>
        public void CreateServiceLbPolicy()
        {
            // Snippet: CreateServiceLbPolicy(string, ServiceLbPolicy, string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ServiceLbPolicy serviceLbPolicy = new ServiceLbPolicy();
            string serviceLbPolicyId = "";
            // Make the request
            Operation<ServiceLbPolicy, OperationMetadata> response = networkServicesClient.CreateServiceLbPolicy(parent, serviceLbPolicy, serviceLbPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<ServiceLbPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ServiceLbPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceLbPolicy, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceCreateServiceLbPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceLbPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceLbPolicyAsync</summary>
        public async Task CreateServiceLbPolicyAsync()
        {
            // Snippet: CreateServiceLbPolicyAsync(string, ServiceLbPolicy, string, CallSettings)
            // Additional: CreateServiceLbPolicyAsync(string, ServiceLbPolicy, string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ServiceLbPolicy serviceLbPolicy = new ServiceLbPolicy();
            string serviceLbPolicyId = "";
            // Make the request
            Operation<ServiceLbPolicy, OperationMetadata> response = await networkServicesClient.CreateServiceLbPolicyAsync(parent, serviceLbPolicy, serviceLbPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<ServiceLbPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ServiceLbPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceLbPolicy, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceCreateServiceLbPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceLbPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceLbPolicy</summary>
        public void CreateServiceLbPolicyResourceNames()
        {
            // Snippet: CreateServiceLbPolicy(LocationName, ServiceLbPolicy, string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ServiceLbPolicy serviceLbPolicy = new ServiceLbPolicy();
            string serviceLbPolicyId = "";
            // Make the request
            Operation<ServiceLbPolicy, OperationMetadata> response = networkServicesClient.CreateServiceLbPolicy(parent, serviceLbPolicy, serviceLbPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<ServiceLbPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ServiceLbPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceLbPolicy, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceCreateServiceLbPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceLbPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceLbPolicyAsync</summary>
        public async Task CreateServiceLbPolicyResourceNamesAsync()
        {
            // Snippet: CreateServiceLbPolicyAsync(LocationName, ServiceLbPolicy, string, CallSettings)
            // Additional: CreateServiceLbPolicyAsync(LocationName, ServiceLbPolicy, string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ServiceLbPolicy serviceLbPolicy = new ServiceLbPolicy();
            string serviceLbPolicyId = "";
            // Make the request
            Operation<ServiceLbPolicy, OperationMetadata> response = await networkServicesClient.CreateServiceLbPolicyAsync(parent, serviceLbPolicy, serviceLbPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<ServiceLbPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ServiceLbPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceLbPolicy, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceCreateServiceLbPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceLbPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceLbPolicy</summary>
        public void UpdateServiceLbPolicyRequestObject()
        {
            // Snippet: UpdateServiceLbPolicy(UpdateServiceLbPolicyRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            UpdateServiceLbPolicyRequest request = new UpdateServiceLbPolicyRequest
            {
                UpdateMask = new FieldMask(),
                ServiceLbPolicy = new ServiceLbPolicy(),
            };
            // Make the request
            Operation<ServiceLbPolicy, OperationMetadata> response = networkServicesClient.UpdateServiceLbPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<ServiceLbPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ServiceLbPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceLbPolicy, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceUpdateServiceLbPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceLbPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceLbPolicyAsync</summary>
        public async Task UpdateServiceLbPolicyRequestObjectAsync()
        {
            // Snippet: UpdateServiceLbPolicyAsync(UpdateServiceLbPolicyRequest, CallSettings)
            // Additional: UpdateServiceLbPolicyAsync(UpdateServiceLbPolicyRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            UpdateServiceLbPolicyRequest request = new UpdateServiceLbPolicyRequest
            {
                UpdateMask = new FieldMask(),
                ServiceLbPolicy = new ServiceLbPolicy(),
            };
            // Make the request
            Operation<ServiceLbPolicy, OperationMetadata> response = await networkServicesClient.UpdateServiceLbPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ServiceLbPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ServiceLbPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceLbPolicy, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceUpdateServiceLbPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceLbPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceLbPolicy</summary>
        public void UpdateServiceLbPolicy()
        {
            // Snippet: UpdateServiceLbPolicy(ServiceLbPolicy, FieldMask, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            ServiceLbPolicy serviceLbPolicy = new ServiceLbPolicy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ServiceLbPolicy, OperationMetadata> response = networkServicesClient.UpdateServiceLbPolicy(serviceLbPolicy, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ServiceLbPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ServiceLbPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceLbPolicy, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceUpdateServiceLbPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceLbPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceLbPolicyAsync</summary>
        public async Task UpdateServiceLbPolicyAsync()
        {
            // Snippet: UpdateServiceLbPolicyAsync(ServiceLbPolicy, FieldMask, CallSettings)
            // Additional: UpdateServiceLbPolicyAsync(ServiceLbPolicy, FieldMask, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            ServiceLbPolicy serviceLbPolicy = new ServiceLbPolicy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ServiceLbPolicy, OperationMetadata> response = await networkServicesClient.UpdateServiceLbPolicyAsync(serviceLbPolicy, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ServiceLbPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ServiceLbPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceLbPolicy, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceUpdateServiceLbPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceLbPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceLbPolicy</summary>
        public void DeleteServiceLbPolicyRequestObject()
        {
            // Snippet: DeleteServiceLbPolicy(DeleteServiceLbPolicyRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            DeleteServiceLbPolicyRequest request = new DeleteServiceLbPolicyRequest
            {
                ServiceLbPolicyName = ServiceLbPolicyName.FromProjectLocationServiceLbPolicy("[PROJECT]", "[LOCATION]", "[SERVICE_LB_POLICY]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = networkServicesClient.DeleteServiceLbPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceDeleteServiceLbPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceLbPolicyAsync</summary>
        public async Task DeleteServiceLbPolicyRequestObjectAsync()
        {
            // Snippet: DeleteServiceLbPolicyAsync(DeleteServiceLbPolicyRequest, CallSettings)
            // Additional: DeleteServiceLbPolicyAsync(DeleteServiceLbPolicyRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteServiceLbPolicyRequest request = new DeleteServiceLbPolicyRequest
            {
                ServiceLbPolicyName = ServiceLbPolicyName.FromProjectLocationServiceLbPolicy("[PROJECT]", "[LOCATION]", "[SERVICE_LB_POLICY]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkServicesClient.DeleteServiceLbPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceDeleteServiceLbPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceLbPolicy</summary>
        public void DeleteServiceLbPolicy()
        {
            // Snippet: DeleteServiceLbPolicy(string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/serviceLbPolicies/[SERVICE_LB_POLICY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = networkServicesClient.DeleteServiceLbPolicy(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceDeleteServiceLbPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceLbPolicyAsync</summary>
        public async Task DeleteServiceLbPolicyAsync()
        {
            // Snippet: DeleteServiceLbPolicyAsync(string, CallSettings)
            // Additional: DeleteServiceLbPolicyAsync(string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/serviceLbPolicies/[SERVICE_LB_POLICY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkServicesClient.DeleteServiceLbPolicyAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceDeleteServiceLbPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceLbPolicy</summary>
        public void DeleteServiceLbPolicyResourceNames()
        {
            // Snippet: DeleteServiceLbPolicy(ServiceLbPolicyName, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            ServiceLbPolicyName name = ServiceLbPolicyName.FromProjectLocationServiceLbPolicy("[PROJECT]", "[LOCATION]", "[SERVICE_LB_POLICY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = networkServicesClient.DeleteServiceLbPolicy(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = networkServicesClient.PollOnceDeleteServiceLbPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceLbPolicyAsync</summary>
        public async Task DeleteServiceLbPolicyResourceNamesAsync()
        {
            // Snippet: DeleteServiceLbPolicyAsync(ServiceLbPolicyName, CallSettings)
            // Additional: DeleteServiceLbPolicyAsync(ServiceLbPolicyName, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            ServiceLbPolicyName name = ServiceLbPolicyName.FromProjectLocationServiceLbPolicy("[PROJECT]", "[LOCATION]", "[SERVICE_LB_POLICY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await networkServicesClient.DeleteServiceLbPolicyAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await networkServicesClient.PollOnceDeleteServiceLbPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetGatewayRouteView</summary>
        public void GetGatewayRouteViewRequestObject()
        {
            // Snippet: GetGatewayRouteView(GetGatewayRouteViewRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            GetGatewayRouteViewRequest request = new GetGatewayRouteViewRequest
            {
                GatewayRouteViewName = GatewayRouteViewName.FromProjectLocationGatewayRouteView("[PROJECT]", "[LOCATION]", "[GATEWAY]", "[ROUTE_VIEW]"),
            };
            // Make the request
            GatewayRouteView response = networkServicesClient.GetGatewayRouteView(request);
            // End snippet
        }

        /// <summary>Snippet for GetGatewayRouteViewAsync</summary>
        public async Task GetGatewayRouteViewRequestObjectAsync()
        {
            // Snippet: GetGatewayRouteViewAsync(GetGatewayRouteViewRequest, CallSettings)
            // Additional: GetGatewayRouteViewAsync(GetGatewayRouteViewRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            GetGatewayRouteViewRequest request = new GetGatewayRouteViewRequest
            {
                GatewayRouteViewName = GatewayRouteViewName.FromProjectLocationGatewayRouteView("[PROJECT]", "[LOCATION]", "[GATEWAY]", "[ROUTE_VIEW]"),
            };
            // Make the request
            GatewayRouteView response = await networkServicesClient.GetGatewayRouteViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetGatewayRouteView</summary>
        public void GetGatewayRouteView()
        {
            // Snippet: GetGatewayRouteView(string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/gateways/[GATEWAY]/routeViews/[ROUTE_VIEW]";
            // Make the request
            GatewayRouteView response = networkServicesClient.GetGatewayRouteView(name);
            // End snippet
        }

        /// <summary>Snippet for GetGatewayRouteViewAsync</summary>
        public async Task GetGatewayRouteViewAsync()
        {
            // Snippet: GetGatewayRouteViewAsync(string, CallSettings)
            // Additional: GetGatewayRouteViewAsync(string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/gateways/[GATEWAY]/routeViews/[ROUTE_VIEW]";
            // Make the request
            GatewayRouteView response = await networkServicesClient.GetGatewayRouteViewAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetGatewayRouteView</summary>
        public void GetGatewayRouteViewResourceNames()
        {
            // Snippet: GetGatewayRouteView(GatewayRouteViewName, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            GatewayRouteViewName name = GatewayRouteViewName.FromProjectLocationGatewayRouteView("[PROJECT]", "[LOCATION]", "[GATEWAY]", "[ROUTE_VIEW]");
            // Make the request
            GatewayRouteView response = networkServicesClient.GetGatewayRouteView(name);
            // End snippet
        }

        /// <summary>Snippet for GetGatewayRouteViewAsync</summary>
        public async Task GetGatewayRouteViewResourceNamesAsync()
        {
            // Snippet: GetGatewayRouteViewAsync(GatewayRouteViewName, CallSettings)
            // Additional: GetGatewayRouteViewAsync(GatewayRouteViewName, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            GatewayRouteViewName name = GatewayRouteViewName.FromProjectLocationGatewayRouteView("[PROJECT]", "[LOCATION]", "[GATEWAY]", "[ROUTE_VIEW]");
            // Make the request
            GatewayRouteView response = await networkServicesClient.GetGatewayRouteViewAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMeshRouteView</summary>
        public void GetMeshRouteViewRequestObject()
        {
            // Snippet: GetMeshRouteView(GetMeshRouteViewRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            GetMeshRouteViewRequest request = new GetMeshRouteViewRequest
            {
                MeshRouteViewName = MeshRouteViewName.FromProjectLocationMeshRouteView("[PROJECT]", "[LOCATION]", "[MESH]", "[ROUTE_VIEW]"),
            };
            // Make the request
            MeshRouteView response = networkServicesClient.GetMeshRouteView(request);
            // End snippet
        }

        /// <summary>Snippet for GetMeshRouteViewAsync</summary>
        public async Task GetMeshRouteViewRequestObjectAsync()
        {
            // Snippet: GetMeshRouteViewAsync(GetMeshRouteViewRequest, CallSettings)
            // Additional: GetMeshRouteViewAsync(GetMeshRouteViewRequest, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            GetMeshRouteViewRequest request = new GetMeshRouteViewRequest
            {
                MeshRouteViewName = MeshRouteViewName.FromProjectLocationMeshRouteView("[PROJECT]", "[LOCATION]", "[MESH]", "[ROUTE_VIEW]"),
            };
            // Make the request
            MeshRouteView response = await networkServicesClient.GetMeshRouteViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMeshRouteView</summary>
        public void GetMeshRouteView()
        {
            // Snippet: GetMeshRouteView(string, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/meshes/[MESH]/routeViews/[ROUTE_VIEW]";
            // Make the request
            MeshRouteView response = networkServicesClient.GetMeshRouteView(name);
            // End snippet
        }

        /// <summary>Snippet for GetMeshRouteViewAsync</summary>
        public async Task GetMeshRouteViewAsync()
        {
            // Snippet: GetMeshRouteViewAsync(string, CallSettings)
            // Additional: GetMeshRouteViewAsync(string, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/meshes/[MESH]/routeViews/[ROUTE_VIEW]";
            // Make the request
            MeshRouteView response = await networkServicesClient.GetMeshRouteViewAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMeshRouteView</summary>
        public void GetMeshRouteViewResourceNames()
        {
            // Snippet: GetMeshRouteView(MeshRouteViewName, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            MeshRouteViewName name = MeshRouteViewName.FromProjectLocationMeshRouteView("[PROJECT]", "[LOCATION]", "[MESH]", "[ROUTE_VIEW]");
            // Make the request
            MeshRouteView response = networkServicesClient.GetMeshRouteView(name);
            // End snippet
        }

        /// <summary>Snippet for GetMeshRouteViewAsync</summary>
        public async Task GetMeshRouteViewResourceNamesAsync()
        {
            // Snippet: GetMeshRouteViewAsync(MeshRouteViewName, CallSettings)
            // Additional: GetMeshRouteViewAsync(MeshRouteViewName, CancellationToken)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            MeshRouteViewName name = MeshRouteViewName.FromProjectLocationMeshRouteView("[PROJECT]", "[LOCATION]", "[MESH]", "[ROUTE_VIEW]");
            // Make the request
            MeshRouteView response = await networkServicesClient.GetMeshRouteViewAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListGatewayRouteViews</summary>
        public void ListGatewayRouteViewsRequestObject()
        {
            // Snippet: ListGatewayRouteViews(ListGatewayRouteViewsRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            ListGatewayRouteViewsRequest request = new ListGatewayRouteViewsRequest
            {
                ParentAsGatewayName = GatewayName.FromProjectLocationGateway("[PROJECT]", "[LOCATION]", "[GATEWAY]"),
            };
            // Make the request
            PagedEnumerable<ListGatewayRouteViewsResponse, GatewayRouteView> response = networkServicesClient.ListGatewayRouteViews(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GatewayRouteView item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGatewayRouteViewsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GatewayRouteView item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GatewayRouteView> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GatewayRouteView item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGatewayRouteViewsAsync</summary>
        public async Task ListGatewayRouteViewsRequestObjectAsync()
        {
            // Snippet: ListGatewayRouteViewsAsync(ListGatewayRouteViewsRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            ListGatewayRouteViewsRequest request = new ListGatewayRouteViewsRequest
            {
                ParentAsGatewayName = GatewayName.FromProjectLocationGateway("[PROJECT]", "[LOCATION]", "[GATEWAY]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListGatewayRouteViewsResponse, GatewayRouteView> response = networkServicesClient.ListGatewayRouteViewsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GatewayRouteView item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGatewayRouteViewsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GatewayRouteView item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GatewayRouteView> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GatewayRouteView item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGatewayRouteViews</summary>
        public void ListGatewayRouteViews()
        {
            // Snippet: ListGatewayRouteViews(string, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/gateways/[GATEWAY]";
            // Make the request
            PagedEnumerable<ListGatewayRouteViewsResponse, GatewayRouteView> response = networkServicesClient.ListGatewayRouteViews(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GatewayRouteView item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGatewayRouteViewsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GatewayRouteView item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GatewayRouteView> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GatewayRouteView item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGatewayRouteViewsAsync</summary>
        public async Task ListGatewayRouteViewsAsync()
        {
            // Snippet: ListGatewayRouteViewsAsync(string, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/gateways/[GATEWAY]";
            // Make the request
            PagedAsyncEnumerable<ListGatewayRouteViewsResponse, GatewayRouteView> response = networkServicesClient.ListGatewayRouteViewsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GatewayRouteView item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGatewayRouteViewsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GatewayRouteView item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GatewayRouteView> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GatewayRouteView item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGatewayRouteViews</summary>
        public void ListGatewayRouteViewsResourceNames()
        {
            // Snippet: ListGatewayRouteViews(GatewayName, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            GatewayName parent = GatewayName.FromProjectLocationGateway("[PROJECT]", "[LOCATION]", "[GATEWAY]");
            // Make the request
            PagedEnumerable<ListGatewayRouteViewsResponse, GatewayRouteView> response = networkServicesClient.ListGatewayRouteViews(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GatewayRouteView item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGatewayRouteViewsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GatewayRouteView item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GatewayRouteView> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GatewayRouteView item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGatewayRouteViewsAsync</summary>
        public async Task ListGatewayRouteViewsResourceNamesAsync()
        {
            // Snippet: ListGatewayRouteViewsAsync(GatewayName, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            GatewayName parent = GatewayName.FromProjectLocationGateway("[PROJECT]", "[LOCATION]", "[GATEWAY]");
            // Make the request
            PagedAsyncEnumerable<ListGatewayRouteViewsResponse, GatewayRouteView> response = networkServicesClient.ListGatewayRouteViewsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GatewayRouteView item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGatewayRouteViewsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GatewayRouteView item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GatewayRouteView> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GatewayRouteView item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMeshRouteViews</summary>
        public void ListMeshRouteViewsRequestObject()
        {
            // Snippet: ListMeshRouteViews(ListMeshRouteViewsRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            ListMeshRouteViewsRequest request = new ListMeshRouteViewsRequest
            {
                ParentAsMeshName = MeshName.FromProjectLocationMesh("[PROJECT]", "[LOCATION]", "[MESH]"),
            };
            // Make the request
            PagedEnumerable<ListMeshRouteViewsResponse, MeshRouteView> response = networkServicesClient.ListMeshRouteViews(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MeshRouteView item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMeshRouteViewsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MeshRouteView item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MeshRouteView> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MeshRouteView item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMeshRouteViewsAsync</summary>
        public async Task ListMeshRouteViewsRequestObjectAsync()
        {
            // Snippet: ListMeshRouteViewsAsync(ListMeshRouteViewsRequest, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            ListMeshRouteViewsRequest request = new ListMeshRouteViewsRequest
            {
                ParentAsMeshName = MeshName.FromProjectLocationMesh("[PROJECT]", "[LOCATION]", "[MESH]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListMeshRouteViewsResponse, MeshRouteView> response = networkServicesClient.ListMeshRouteViewsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MeshRouteView item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMeshRouteViewsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MeshRouteView item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MeshRouteView> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MeshRouteView item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMeshRouteViews</summary>
        public void ListMeshRouteViews()
        {
            // Snippet: ListMeshRouteViews(string, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/meshes/[MESH]";
            // Make the request
            PagedEnumerable<ListMeshRouteViewsResponse, MeshRouteView> response = networkServicesClient.ListMeshRouteViews(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MeshRouteView item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMeshRouteViewsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MeshRouteView item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MeshRouteView> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MeshRouteView item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMeshRouteViewsAsync</summary>
        public async Task ListMeshRouteViewsAsync()
        {
            // Snippet: ListMeshRouteViewsAsync(string, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/meshes/[MESH]";
            // Make the request
            PagedAsyncEnumerable<ListMeshRouteViewsResponse, MeshRouteView> response = networkServicesClient.ListMeshRouteViewsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MeshRouteView item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMeshRouteViewsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MeshRouteView item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MeshRouteView> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MeshRouteView item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMeshRouteViews</summary>
        public void ListMeshRouteViewsResourceNames()
        {
            // Snippet: ListMeshRouteViews(MeshName, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = NetworkServicesClient.Create();
            // Initialize request argument(s)
            MeshName parent = MeshName.FromProjectLocationMesh("[PROJECT]", "[LOCATION]", "[MESH]");
            // Make the request
            PagedEnumerable<ListMeshRouteViewsResponse, MeshRouteView> response = networkServicesClient.ListMeshRouteViews(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MeshRouteView item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMeshRouteViewsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MeshRouteView item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MeshRouteView> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MeshRouteView item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMeshRouteViewsAsync</summary>
        public async Task ListMeshRouteViewsResourceNamesAsync()
        {
            // Snippet: ListMeshRouteViewsAsync(MeshName, string, int?, CallSettings)
            // Create client
            NetworkServicesClient networkServicesClient = await NetworkServicesClient.CreateAsync();
            // Initialize request argument(s)
            MeshName parent = MeshName.FromProjectLocationMesh("[PROJECT]", "[LOCATION]", "[MESH]");
            // Make the request
            PagedAsyncEnumerable<ListMeshRouteViewsResponse, MeshRouteView> response = networkServicesClient.ListMeshRouteViewsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MeshRouteView item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMeshRouteViewsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MeshRouteView item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MeshRouteView> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MeshRouteView item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}
