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
    internal class CloudResource
    {
        private readonly ApiaryResource _inputResource;
        private Lazy<ClassDeclarationSyntax> _resourceClass;
        internal CloudResource(ApiaryResource inputResource)
        {
            _inputResource = inputResource ?? throw new ArgumentNullException(nameof(inputResource));
            _resourceClass = new Lazy<ClassDeclarationSyntax>(InitResourceClass);
        }

        public ClassDeclarationSyntax ResourceClass => _resourceClass.Value;

        public string ResourceClassName => ResourceClass.GetName();

        private ClassDeclarationSyntax InitResourceClass()
        {
            ClassDeclarationSyntax @class = BuildResourceClassShell();

            foreach (ApiaryOperation inputMethod in _inputResource.StandardOperations)
            {
                var outputOptions = new CloudOperationOptions(inputMethod);
                var outputOperation = new CloudOperation(inputMethod, outputOptions);
                @class = @class.AddMembers(outputOptions.OptionsClass, outputOperation.MethodDeclaration);
            }

            return @class;
        }

        private ClassDeclarationSyntax BuildResourceClassShell()
        {
            string resourceClassName = $"{_inputResource.PluralResourceName}Client";
            string fullyQualifiedClientClassName = $"{CodegenConfig.Current.CloudClientNamespace}.{CodegenConfig.Current.CloudClientClassName}";

            var constructor =
                ConstructorDeclaration(resourceClassName, SyntaxKind.InternalKeyword)
                .AddParameters(
                    (typeName: fullyQualifiedClientClassName, identifier: "client"))
                .AddBodyStatements(
                    SimpleAssignmentStatement("Client", "client"));

            var clientProperty =
                PropertyDeclaration(
                    fullyQualifiedClientClassName,
                    "Client",
                    SyntaxKind.PublicKeyword)
                .WithGet();

            return ClassDeclaration(resourceClassName, SyntaxKind.PublicKeyword)
                .AddMembers(clientProperty, constructor);
        }
    }
}
