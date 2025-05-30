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

#pragma warning disable CS8981
using gaxgrpc = Google.Api.Gax.Grpc;
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
using gpr = Google.Protobuf.Reflection;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;

namespace Google.Cloud.Dataform.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.Dataform.V1", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.cloud.location.Locations.GetLocation",
                    // { "get": "/v1/{name=projects/*/locations/*}" }
                    proto::ByteString.FromBase64("EiEvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKn0=")
                },
                {
                    "google.cloud.location.Locations.ListLocations",
                    // { "get": "/v1/{name=projects/*}/locations" }
                    proto::ByteString.FromBase64("Eh8vdjEve25hbWU9cHJvamVjdHMvKn0vbG9jYXRpb25z")
                },
                {
                    "google.iam.v1.IAMPolicy.GetIamPolicy",
                    // { "get": "/v1/{resource=projects/*/locations/*/repositories/*}:getIamPolicy", "additionalBindings": [ { "get": "/v1/{resource=projects/*/locations/*/repositories/*/workspaces/*}:getIamPolicy" } ] }
                    proto::ByteString.FromBase64("EkEvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovcmVwb3NpdG9yaWVzLyp9OmdldElhbVBvbGljeVpQEk4vdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovcmVwb3NpdG9yaWVzLyovd29ya3NwYWNlcy8qfTpnZXRJYW1Qb2xpY3k=")
                },
                {
                    "google.iam.v1.IAMPolicy.SetIamPolicy",
                    // { "post": "/v1/{resource=projects/*/locations/*/repositories/*}:setIamPolicy", "body": "*", "additionalBindings": [ { "post": "/v1/{resource=projects/*/locations/*/repositories/*/workspaces/*}:setIamPolicy", "body": "*" } ] }
                    proto::ByteString.FromBase64("IkEvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovcmVwb3NpdG9yaWVzLyp9OnNldElhbVBvbGljeToBKlpTIk4vdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovcmVwb3NpdG9yaWVzLyovd29ya3NwYWNlcy8qfTpzZXRJYW1Qb2xpY3k6ASo=")
                },
                {
                    "google.iam.v1.IAMPolicy.TestIamPermissions",
                    // { "post": "/v1/{resource=projects/*/locations/*/repositories/*}:testIamPermissions", "body": "*", "additionalBindings": [ { "post": "/v1/{resource=projects/*/locations/*/repositories/*/workspaces/*}:testIamPermissions", "body": "*" } ] }
                    proto::ByteString.FromBase64("IkcvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovcmVwb3NpdG9yaWVzLyp9OnRlc3RJYW1QZXJtaXNzaW9uczoBKlpZIlQvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovcmVwb3NpdG9yaWVzLyovd29ya3NwYWNlcy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASo=")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return DataformReflection.Descriptor;
            yield return gciv::IamPolicyReflection.Descriptor;
            yield return gciv::OptionsReflection.Descriptor;
            yield return gciv::PolicyReflection.Descriptor;
            yield return gcl::LocationsReflection.Descriptor;
        }
    }
}
