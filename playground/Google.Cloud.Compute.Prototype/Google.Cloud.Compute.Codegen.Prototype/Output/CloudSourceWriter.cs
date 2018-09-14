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
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Google.Cloud.Compute.Codegen.Prototype.Output
{
    internal class CloudSourceWriter
    {
        private SyntaxNode _resources;
        private SyntaxNode _client;

        internal CloudSourceWriter()
        {
            _resources = GetResourcesCompilationUnit();
            _client = GetClientcompilationUnit();
        }

        public void AddResource(ClassDeclarationSyntax resource)
        {
            //_resources is a CompilationUnit
            // Namespace, we know it's just one.
            var oldNamespace = (from ns in _resources.ChildNodes().OfType<NamespaceDeclarationSyntax>()
                                select ns).Single();

            var newNamespace = oldNamespace.AddMembers(resource);

            // Always update our root SyntaxNode because the whole structure is inmutable.
            _resources = _resources.ReplaceNode(oldNamespace, newNamespace);
        }

        public void AddResourcePropertyInClient(PropertyDeclarationSyntax property, StatementSyntax propertyInit)
        {
            //_client is a CompilationUnit
            // We know it's just one namespace and one client class.
            var oldClientClass = (from ns in _client.ChildNodes().OfType<NamespaceDeclarationSyntax>()
                                  from c in ns.Members.OfType<ClassDeclarationSyntax>()
                                  select c).Single();

            var newClientClass = oldClientClass.AddMembers(property);

            var oldInitializeMethod = (from method in newClientClass.Members.OfType<MethodDeclarationSyntax>()
                                       where method.Identifier.ValueText == CodegenConfig.Current.CloudClientInitResourcesMethodName
                                       select method).Single();

            var newInitializeMethod = oldInitializeMethod.AddBodyStatements(propertyInit);

            newClientClass = newClientClass.ReplaceNode(oldInitializeMethod, newInitializeMethod);

            // Always update our root SyntaxNode because the whole structure is inmutable.
            _client = _client.ReplaceNode(oldClientClass, newClientClass);
        }

        public async Task Save()
        {
            var workspace = MSBuildWorkspace.Create();
            var solutionTask = workspace.OpenSolutionAsync(
                CodegenConfig.Current.CloudSolutionFilePath);

            _resources = _resources.Format(workspace);
            _client = _client.Format(workspace);

            var solution = await solutionTask;
            var project = solution.GetProject(CodegenConfig.Current.CloudProjectName);

            var resourcesDocument = project.CreateOrReplaceDocument(
                CodegenConfig.Current.CloudResourcesFileName, _resources);

            // Update our local project reference because the whole structure is inmutable.
            project = resourcesDocument.Project;

            var clientDocument = project.CreateOrReplaceDocument(
                CodegenConfig.Current.CloudClientFileName, _client);
            // Update our local project reference because the whole structure is inmutable.
            project = clientDocument.Project;

            workspace.TryApplyChanges(project.Solution);
        }

        private CompilationUnitSyntax GetResourcesCompilationUnit()
        {
            CompilationUnitSyntax resources =
                CompilationUnit()
                .WithMembers(SingletonList<MemberDeclarationSyntax>(
                        NamespaceDeclaration(
                            IdentifierName(CodegenConfig.Current.CloudResourcesNamespace))
                        .WithLeadingTrivia(License.TriviaList)));
                        
            return resources;
        }

        private CompilationUnitSyntax GetClientcompilationUnit()
        {
            CompilationUnitSyntax client =
                CompilationUnit()
                .WithMembers(SingletonList<MemberDeclarationSyntax>(
                        NamespaceDeclaration(
                            IdentifierName(CodegenConfig.Current.CloudClientNamespace))
                        .WithLeadingTrivia(License.TriviaList)
                        .WithMembers(SingletonList<MemberDeclarationSyntax>(
                            ClassDeclaration(CodegenConfig.Current.CloudClientClassName)
                            .WithModifiers(TokenList(
                                Token(SyntaxKind.PublicKeyword),
                                Token(SyntaxKind.PartialKeyword)))
                            .WithMembers(SingletonList<MemberDeclarationSyntax>(
                                MethodDeclaration(
                                    PredefinedType(Token(SyntaxKind.VoidKeyword)),
                                    CodegenConfig.Current.CloudClientInitResourcesMethodName)
                                .WithModifiers(TokenList(
                                    Token(SyntaxKind.PartialKeyword)))
                                .WithBody(Block())))))));

            return client;
        }
    }
}
