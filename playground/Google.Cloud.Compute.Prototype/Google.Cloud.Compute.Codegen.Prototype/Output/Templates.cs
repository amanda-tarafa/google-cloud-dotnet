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
using System.Text;

namespace Google.Cloud.Compute.Codegen.Prototype.Output
{
    //TODO(atarafamas): Consider storing these templates as .cs files.
    internal static class Templates
    {
        public static string Disclaimer =>
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
// limitations under the License.";

        public static string ResourcesFileTemplate =>
            $@"{Disclaimer}

namespace {CodegenConfig.Current.OutputResourcesNamespace}
{{

}}";

        public static string ClientInitResourcesMethodName => "InitResources";

        public static string ClientClassName => $"{CodegenConfig.Current.ApiName}Client";
        public static string FullyQualifiedClientClassName => $"{CodegenConfig.Current.OutputClientNamespace}.{ClientClassName}";

        public static string ClientFileTemplate =>
                    $@"{Disclaimer}

namespace {CodegenConfig.Current.OutputClientNamespace}
{{
    public partial class {ClientClassName}
    {{
        partial void {ClientInitResourcesMethodName}()
        {{

        }}

    }}
}}";

        public static string GetResourceClassTemplate(string pluralResourceName)
        {
            return $@"public class {pluralResourceName}Client 
{{

public {FullyQualifiedClientClassName} Client {{ get; private set; }}

internal {pluralResourceName}Client({FullyQualifiedClientClassName} client)
{{
Client = client;
}}

}}";
        }

        public static string GetResourcePropertyTemplate(string resourceClassName, string resourcePropertyName)
        {
            return $"public {CodegenConfig.Current.OutputResourcesNamespace}.{resourceClassName} {resourcePropertyName} {{ get; private set; }}";
        }

        public static string GetResourcePropertyInitializeTemplate(string resourceClassName, string resourcePropertyName)
        {
            return $@"{resourcePropertyName} = new {CodegenConfig.Current.OutputResourcesNamespace}.{resourceClassName}(this);
";
        }

        public static string OptionsTemplateModifyRequestParamName => "request";

        public static string GetOptionsTemplate(string classNamePrefix, string requestTypeName)
        {
            return $@"public class {classNamePrefix}Options
{{
internal void ModifyRequest({requestTypeName} {OptionsTemplateModifyRequestParamName})
{{

}}
}}";
        }

        public static string GetOptionsPropertyTemplate(string propertyName, string propertyTypeName)
        {
            return $"public {propertyTypeName} {propertyName} {{ get; set; }}";
        }

        public static string GetOptionsPropertyModifyRequestTemplate(string propertyName)
        {
            return $@"if ({propertyName} != null)
{{
{OptionsTemplateModifyRequestParamName}.{propertyName} = {propertyName};
}}";
        }

        public static string GetOptionsNullablePropertyModifyRequestTemplate(string propertyName)
        {
            return $@"if ({propertyName}.HasValue)
{{
{OptionsTemplateModifyRequestParamName}.{propertyName} = {propertyName}.Value;
}}";
        }

        public static string GetStandardOperationTemplate(
            string returnClassName, string cloudOperationName, string apiaryOperationName,
            Tuple<string, string>[] sortedRequireshParameters,
            string bodyParameterName, string bodyParameterType, string optionsParameterType,
            string requestTypeName, string apiaryResourcePropertyName)
        {
            string receivingParamsPattern = "{0} {1},";
            string passingParamsPattern = "{0},";

            StringBuilder receiving = new StringBuilder();
            StringBuilder passing = new StringBuilder();

            // This assumes that the body parameter always comes before the path parameters.
            if (bodyParameterName != null)
            {
                receiving.AppendFormat(receivingParamsPattern, bodyParameterType, bodyParameterName);
                passing.AppendFormat(passingParamsPattern, bodyParameterName);
            }

            for (int i = 0; i < sortedRequireshParameters.Length; i++)
            {
                receiving.AppendFormat(receivingParamsPattern, sortedRequireshParameters[i].Item1, sortedRequireshParameters[i].Item2);
                passing.AppendFormat(passingParamsPattern, sortedRequireshParameters[i].Item2);
            }
            
            // Remove the last comma from passing,
            // no need to do so for receiving because the options parameter is always there.
            if(passing.Length > 0)
            {
                passing.Remove(passing.Length - 1, 1);
            }

            return $@"public {returnClassName} {cloudOperationName}({receiving} {optionsParameterType} options = null)
{{
{requestTypeName} request = Client.InternalService.{apiaryResourcePropertyName}.{apiaryOperationName}({passing});
options?.ModifyRequest(request);
return request.Execute();
}}";
        }
    }
}
