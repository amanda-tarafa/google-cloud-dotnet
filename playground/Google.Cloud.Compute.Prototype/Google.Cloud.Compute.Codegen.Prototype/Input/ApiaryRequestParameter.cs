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

        public string NameInRequest => _propertyNode.GetName();

        public string NameInService => _propertyInit.GetFirstArgumentTextLiteral();

        public string TypeName => _propertyNode.Type.GetName();

        public bool IsNullable => TypeName.EndsWith("?") || TypeName.StartsWith("System.Nullable");

        public bool IsRequired
        {
            get
            {
                var paramCreationExpresion = _propertyInit.GetFirstArgumentOfType<ObjectCreationExpressionSyntax>();
                return bool.Parse(paramCreationExpresion.Initializer.GetAssignedTextValueFor(CodegenConfig.Current.ApiaryParameterIsRequiredPropertyIdentifier));
            }
        }
    }
}
