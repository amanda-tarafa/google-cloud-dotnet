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

using Microsoft.CodeAnalysis;
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
        private readonly Lazy<ApiaryRequestBody> _body;
        internal ApiaryRequest(ClassDeclarationSyntax requestNode, ApiaryResource parent)
        {
            _requestNode = requestNode ?? throw new ArgumentNullException(nameof(requestNode));
            _parent = parent ?? throw new ArgumentNullException(nameof(parent));
            _allParameters = new Lazy<IList<ApiaryRequestParameter>>(InitAllParameters);
            _body = new Lazy<ApiaryRequestBody>(InitBody);
        }

        public string ClassName => _requestNode.Identifier.ValueText;
        public string FullyQualifiedName => $"{_parent.FullyQualifiedName}.{ClassName}";

        public string RequestReturnTypeName =>
            // This assumes that the first type parameter of the apiary request base type
            // is the type return by executing the request.
            (from baseType in _requestNode.BaseList.Types
             from genericType in baseType.ChildNodes().OfType<GenericNameSyntax>()
             from typeArgument in genericType.TypeArgumentList.Arguments
             where genericType.ToString().StartsWith(CodegenConfig.Current.ApiaryRequestBaseTypeIdentifier)
             select typeArgument.ToString()).Single();

        public IEnumerable<ApiaryRequestParameter> RequieredParameters =>
            from parameter in _allParameters.Value
            where parameter.IsRequired
            select parameter;

        public IEnumerable<ApiaryRequestParameter> OptionalParameters =>
            from parameter in _allParameters.Value
            where !parameter.IsRequired
            select parameter;

        public ApiaryRequestBody BodyParameter => _body.Value;

        public bool IsLongRunning =>
            (from baseType in _requestNode.BaseList.Types
             where baseType.ToString().Contains(CodegenConfig.Current.ApiaryLongRunningOperationTypeIdentifier)
             select baseType).Any();

        public bool IsList =>
            (from property in _requestNode.Members.OfType<PropertyDeclarationSyntax>()
             where property.Identifier.ValueText == CodegenConfig.Current.ApiaryListOperationPropertyIdentifier
             select property).Any();

        public bool IsStandard => !IsList && !IsLongRunning;

        private IList<ApiaryRequestParameter> InitAllParameters()
        {
            var propertyInitStatements =
                from method in _requestNode.Members.OfType<MethodDeclarationSyntax>()
                from statement in method.Body.Statements
                from invocation in statement.DescendantNodes().OfType<InvocationExpressionSyntax>()
                where method.Identifier.ToString() == CodegenConfig.Current.ApiaryInitParameterMethodIdentifier
                && invocation.Expression.ToString() == CodegenConfig.Current.ApiaryInitParameterStatementIdentifier
                select invocation;

            return (from property in _requestNode.Members.OfType<PropertyDeclarationSyntax>()
                    from attributes in property.AttributeLists
                    from attribute in attributes.Attributes
                    from argument in attribute.ArgumentList.Arguments
                    join propertyInit in propertyInitStatements on argument.Expression.ToString() equals propertyInit.ArgumentList.Arguments.First().Expression.ToString()
                    where attribute.Name.ToString() == CodegenConfig.Current.ApiaryParameterAttributeIdentifier
                    select new ApiaryRequestParameter(property, propertyInit)).ToList();
        }

        private ApiaryRequestBody InitBody()
        {
            return (from property in _requestNode.Members.OfType<PropertyDeclarationSyntax>()
                    where property.Identifier.ToString() == CodegenConfig.Current.ApiaryBodyParameterPropertyIdentifier
                    select new ApiaryRequestBody(property)).SingleOrDefault();
        }
    }
}
