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

using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.Compute.Codegen.Prototype.Input
{
    internal class ApiaryRequest
    {
        private readonly ClassDeclarationSyntax _requestNode;
        private readonly ApiaryResource _parent;
        private readonly Lazy<IList<ApiaryRequestParameter>> _allParameters;
        private readonly Lazy<ApiaryRequestBody> _bodyParameter;
        internal ApiaryRequest(ClassDeclarationSyntax requestNode, ApiaryResource parent)
        {
            _requestNode = requestNode ?? throw new ArgumentNullException(nameof(requestNode));
            _parent = parent ?? throw new ArgumentNullException(nameof(parent));
            _allParameters = new Lazy<IList<ApiaryRequestParameter>>(InitAllParameters);
            _bodyParameter = new Lazy<ApiaryRequestBody>(InitBodyParameter);
        }

        public string ClassName => _requestNode.GetName();
        public string FullyQualifiedName => $"{_parent.FullyQualifiedName}.{ClassName}";

        public string RequestReturnTypeName =>
            // This assumes that the only type parameter of the apiary request base type
            // is the type returned by executing the request.
            _requestNode.
            FindGenericBaseType(CodegenConfig.Current.ApiaryRequestBaseTypeIdentifier).
            GetTypeArguments().Single()
            .GetName();

        public IEnumerable<ApiaryRequestParameter> RequieredParameters =>
            from parameter in _allParameters.Value
            where parameter.IsRequired
            select parameter;

        public IEnumerable<ApiaryRequestParameter> OptionalParameters =>
            from parameter in _allParameters.Value
            where !parameter.IsRequired
            select parameter;

        public ApiaryRequestBody BodyParameter => _bodyParameter.Value;

        public bool IsLongRunning =>
            RequestReturnTypeName.Equals(CodegenConfig.Current.ApiaryLongRunningOperationTypeIdentifier);

        public bool IsList =>
            _requestNode.FindProperty(CodegenConfig.Current.ApiaryListOperationPropertyIdentifier) != null;

        public bool IsStandard => !IsList && !IsLongRunning;

        private IList<ApiaryRequestParameter> InitAllParameters()
        {
            // Only way to know if a request parameter is required is by examining
            // the paramater initialization statement.
            // Here we are grabbing all paramenter initialization statements.
            var initParamMethod = _requestNode.FindMethod(CodegenConfig.Current.ApiaryInitParameterMethodIdentifier);
            var paramPropertyInitStatements =
                from statement in initParamMethod.Body.Statements
                from invocation in statement.DescendantNodes().OfType<InvocationExpressionSyntax>()
                where invocation.Expression.ToString() == CodegenConfig.Current.ApiaryInitParameterStatementIdentifier
                select invocation;

            // Get all properties that are marked as request parameters.
            var paramProperties = _requestNode.FindPropertiesWithAttribute(CodegenConfig.Current.ApiaryParameterAttributeIdentifier);

            // Cross each property with their init statement so as to obtain all info neccesary
            // to build and ApiaryRequestParameter instance.
            return (from markedProperty in paramProperties
                    join propertyInit in paramPropertyInitStatements
                    on markedProperty.attribute.GetFirstArgumentTextLiteral()
                    equals propertyInit.GetFirstArgumentTextLiteral()
                    select new ApiaryRequestParameter(markedProperty.property, propertyInit)).ToList();
        }

        private ApiaryRequestBody InitBodyParameter()
        {
            var bodyProperty = _requestNode.FindProperty(CodegenConfig.Current.ApiaryBodyParameterPropertyIdentifier);
            return bodyProperty == null ? null : new ApiaryRequestBody(bodyProperty);
        }
    }
}
