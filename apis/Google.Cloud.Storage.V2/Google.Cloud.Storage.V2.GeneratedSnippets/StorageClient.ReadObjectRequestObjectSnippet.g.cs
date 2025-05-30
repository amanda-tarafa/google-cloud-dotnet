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
    // [START storage_v2_generated_Storage_ReadObject_sync]
    using Google.Api.Gax.Grpc;
    using Google.Cloud.Storage.V2;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedStorageClientSnippets
    {
        /// <summary>Snippet for ReadObject</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task ReadObjectRequestObject()
        {
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            ReadObjectRequest request = new ReadObjectRequest
            {
                BucketAsBucketName = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                Object = "",
                Generation = 0L,
                ReadOffset = 0L,
                ReadLimit = 0L,
                IfGenerationMatch = 0L,
                IfGenerationNotMatch = 0L,
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
                CommonObjectRequestParams = new CommonObjectRequestParams(),
                ReadMask = new FieldMask(),
            };
            // Make the request, returning a streaming response
            using StorageClient.ReadObjectStream response = storageClient.ReadObject(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<ReadObjectResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                ReadObjectResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
        }
    }
    // [END storage_v2_generated_Storage_ReadObject_sync]
}
