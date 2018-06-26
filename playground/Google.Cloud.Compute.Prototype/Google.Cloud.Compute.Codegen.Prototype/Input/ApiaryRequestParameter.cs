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
using System.Linq;

namespace Google.Cloud.Compute.Codegen.Prototype.Input
{
    internal class ApiaryRequestParameter
    {
        private readonly PropertyDeclarationSyntax _propertyNode;
        private readonly InvocationExpressionSyntax _propertyInit;

        internal ApiaryRequestParameter(PropertyDeclarationSyntax propertyNode, InvocationExpressionSyntax propertyInit)
        {
            _propertyNode = propertyNode ?? throw new ArgumentNullException(nameof(propertyNode));
            _propertyInit = propertyInit ?? throw new ArgumentNullException(nameof(propertyInit));
        }

        public string NameInRequest => _propertyNode.Identifier.ValueText;
        public string NameInService =>
            (from attributes in _propertyNode.AttributeLists
             from attribute in attributes.Attributes
             from argument in attribute.ArgumentList.Arguments
             from value in argument.ChildNodes().OfType<LiteralExpressionSyntax>()
             where attribute.Name.ToString() == CodegenConfig.Current.ApiaryParameterAttributeIdentifier
             && value.Token.ValueText.Equals(NameInRequest, StringComparison.OrdinalIgnoreCase)
             select value.Token.ValueText).Single();

        public string TypeName => _propertyNode.Type.ToString();

        public bool IsNullable => TypeName.EndsWith("?") || TypeName.StartsWith("System.Nullable");

        public bool IsRequired =>
            (from argument in _propertyInit.ArgumentList.Arguments
             from paramCreationExpression in argument.ChildNodes().OfType<ObjectCreationExpressionSyntax>()
             from paramProperty in paramCreationExpression.Initializer.Expressions.OfType<AssignmentExpressionSyntax>()
             where paramProperty.Left.ToString() == CodegenConfig.Current.ApiaryParameterIsRequiredPropertyIdentifier
             select bool.Parse(paramProperty.Right.ToString())).Single();
    }
}
