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

using Google.Cloud.Compute.Codegen.Prototype.Input;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using static Google.Cloud.Compute.Codegen.Prototype.RoslynSyntaxFactory;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Google.Cloud.Compute.Codegen.Prototype.Output
{
    internal class CloudResourceProperty
    {
        private readonly string _fullyQualifiedResourceClassName;
        private readonly CloudResource _resource;
        private readonly ApiaryResource _inputResource;
        private readonly Lazy<PropertyDeclarationSyntax> _property;
        private readonly Lazy<StatementSyntax> _propertyInit;

        internal CloudResourceProperty(ApiaryResource inputResource, CloudResource outputResource)
        {
            _inputResource = inputResource ?? throw new ArgumentNullException(nameof(inputResource));
            _resource = outputResource ?? throw new ArgumentNullException(nameof(outputResource));

            _fullyQualifiedResourceClassName = $"{CodegenConfig.Current.CloudResourcesNamespace}.{_resource.ResourceClassName}";

            _property = new Lazy<PropertyDeclarationSyntax>(InitResourcePropertyDeclaration);
            _propertyInit = new Lazy<StatementSyntax>(InitResourcePropertyInitStatement);
        }

        public PropertyDeclarationSyntax ResourcePropertyDeclaration => _property.Value;

        public StatementSyntax ResourcePropertyInit => _propertyInit.Value;

        private PropertyDeclarationSyntax InitResourcePropertyDeclaration() =>
            PropertyDeclaration(
                _fullyQualifiedResourceClassName,
                _inputResource.PluralResourceName,
                SyntaxKind.PublicKeyword)
            .WithGet()
            .WithSet(modifiers: SyntaxKind.PrivateKeyword);

        private StatementSyntax InitResourcePropertyInitStatement()
        {
            var resourceCration =
                ObjectCreationExpression(_fullyQualifiedResourceClassName)
                .AddArgumentListArguments(Argument(ThisExpression()));
            return SimpleAssignmentStatement(
                _inputResource.PluralResourceName,
                resourceCration);
        }
    }
}
