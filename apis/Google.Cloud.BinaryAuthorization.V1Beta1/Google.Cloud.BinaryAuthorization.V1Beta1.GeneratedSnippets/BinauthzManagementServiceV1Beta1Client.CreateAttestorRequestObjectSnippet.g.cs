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
    // [START binaryauthorization_v1beta1_generated_BinauthzManagementServiceV1Beta1_CreateAttestor_sync]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.BinaryAuthorization.V1Beta1;

    public sealed partial class GeneratedBinauthzManagementServiceV1Beta1ClientSnippets
    {
        /// <summary>Snippet for CreateAttestor</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void CreateAttestorRequestObject()
        {
            // Create client
            BinauthzManagementServiceV1Beta1Client binauthzManagementServiceV1Beta1Client = BinauthzManagementServiceV1Beta1Client.Create();
            // Initialize request argument(s)
            CreateAttestorRequest request = new CreateAttestorRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                AttestorId = "",
                Attestor = new Attestor(),
            };
            // Make the request
            Attestor response = binauthzManagementServiceV1Beta1Client.CreateAttestor(request);
        }
    }
    // [END binaryauthorization_v1beta1_generated_BinauthzManagementServiceV1Beta1_CreateAttestor_sync]
}
