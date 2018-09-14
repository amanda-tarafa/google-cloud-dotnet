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

using System;

namespace Google.Cloud.Compute.Codegen.Prototype
{
    /// <summary>
    /// This class will read from some config file probably.
    /// </summary>
    public class CodegenConfig
    {
        private CodegenConfig()
        { }

        private static Lazy<CodegenConfig> _current = new Lazy<CodegenConfig>(() => new CodegenConfig());
        public static CodegenConfig Current => _current.Value;

        public string License =>
            $@"// Copyright {DateTime.UtcNow.Year} Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the ""License"");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an ""AS IS"" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

";

        public string ApiName => "Compute";
        public string ApiaryApiVersion => "v1";
        public string ApiarySourcePath => $@"ApiarySource/Google.Apis.{ApiName}.{ApiaryApiVersion}.cs";
        public string ApiaryResourceNamespace => $"Google.Apis.{ApiName}.{ApiaryApiVersion}";
        public string ApiaryResourceSuffix => "Resource";
        public string ApiaryDataNamespace => $"Google.Apis.{ApiName}.{ApiaryApiVersion}.Data";
        public string ApiaryRequestBaseTypeIdentifier => $"{ApiName}BaseServiceRequest";
        public string ApiaryLongRunningOperationTypeIdentifier => $"{ApiaryRequestBaseTypeIdentifier}<{ApiaryDataNamespace}.Operation>";
        public string ApiaryListOperationPropertyIdentifier => "PageToken";
        public string ApiaryBodyParameterPropertyIdentifier => "Body";
        public string ApiaryParameterAttributeIdentifier => "Google.Apis.Util.RequestParameterAttribute";
        public string ApiaryInitParameterMethodIdentifier => "InitParameters";
        public string ApiaryInitParameterStatementIdentifier = "RequestParameters.Add";
        public string ApiaryParameterIsRequiredPropertyIdentifier = "IsRequired";
        public string ApiaryParameterQueryTypeIdentifier => "Google.Apis.Util.RequestParameterType.Query";
        public string ApiaryParameterPathTypeIdentifier => "Google.Apis.Util.RequestParameterType.Path";
        public string CloudSolutionFilePath => $@"../../../../Google.Cloud.{ApiName}.Protoype.sln";
        public string CloudProjectName => $"Google.Cloud.{ApiName}.Prototype";
        public string CloudResourcesNamespace => $"Google.Cloud.{ApiName}.Prototype";
        public string CloudResourcesFileName => "Resources.cs";
        public string CloudClientNamespace => $"Google.Cloud.{ApiName}.Prototype";
        public string CloudClientFileName => $"{ApiName}Client.Resources.cs";
        public string CloudClientClassName => $"{ApiName}Client";
        public string CloudClientInitResourcesMethodName => "InitResources";
        public string CloudOptionsModifyRequestParamName => "request";
    }
}
