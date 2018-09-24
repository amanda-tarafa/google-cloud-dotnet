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
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Google.Cloud.Compute.Codegen.Prototype.RoslynSyntaxFactory;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Google.Cloud.Compute.Codegen.Prototype.Output
{
    internal class CloudSourceParser
    {
        private readonly IList<ClassDeclarationSyntax> _resources;
        private readonly IList<PropertyDeclarationSyntax> _resourceProperties;
        private readonly IList<StatementSyntax> _resourcePropertiesInit;

        internal CloudSourceParser()
        {
            _resources = new List<ClassDeclarationSyntax>();
            _resourceProperties = new List<PropertyDeclarationSyntax>();
            _resourcePropertiesInit = new List<StatementSyntax>();
        }

        public void AddResource(ApiaryResource inputResource)
        {
            var outputResource = new CloudResource(inputResource);
            var outputResourceProperty = new CloudResourceProperty(inputResource, outputResource);

            _resources.Add(outputResource.ResourceClass);
            _resourceProperties.Add(outputResourceProperty.ResourcePropertyDeclaration);
            _resourcePropertiesInit.Add(outputResourceProperty.ResourcePropertyInit);
        }

        public async Task Save()
        {
            var resourcesNode = BuildResouresNode();
            var clientNode = BuildClientNode();

            CloudSourceWriter _writer = new CloudSourceWriter();
            await _writer.Save(resourcesNode, clientNode);
        }

        private CompilationUnitSyntax BuildResouresNode()
        {
            NamespaceDeclarationSyntax resourcesNamespace =
                NamespaceDeclaration(CodegenConfig.Current.CloudResourcesNamespace)
                .WithLeadingTrivia(License.TriviaList)
                .AddMembers(_resources.ToArray());

            return CompilationUnit()
                .AddMembers(resourcesNamespace);
        }

        private CompilationUnitSyntax BuildClientNode()
        {
            MethodDeclarationSyntax propertyInitMethod =
                VoidMethodDeclaration(
                    CodegenConfig.Current.CloudClientInitResourcesMethodName,
                    SyntaxKind.PartialKeyword)
                .AddBodyStatements(_resourcePropertiesInit.ToArray());

            ClassDeclarationSyntax clientClass =
                ClassDeclaration(
                    CodegenConfig.Current.CloudClientClassName,
                    SyntaxKind.PublicKeyword,
                    SyntaxKind.PartialKeyword)
                .AddMembers(_resourceProperties.ToArray())
                .AddMembers(propertyInitMethod);

            NamespaceDeclarationSyntax clientNamespace =
                NamespaceDeclaration(CodegenConfig.Current.CloudClientNamespace)
                .WithLeadingTrivia(License.TriviaList)
                .AddMembers(clientClass);

            return CompilationUnit()
                .AddMembers(clientNamespace);
        }
    }
}
