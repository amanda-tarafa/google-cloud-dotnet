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
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Google.Cloud.Compute.Codegen.Prototype.Output
{
    internal class CloudResource
    {
        private readonly ApiaryResource _inputResource;
        private Lazy<ClassDeclarationSyntax> _syntaxNode;
        internal CloudResource(ApiaryResource inputResource)
        {
            _inputResource = inputResource ?? throw new ArgumentNullException(nameof(inputResource));
            _syntaxNode = new Lazy<ClassDeclarationSyntax>(InitSyntaxNode);
        }

        public ClassDeclarationSyntax SyntaxNode => _syntaxNode.Value;

        public string ClassName => SyntaxNode.Identifier.ValueText;

        private ClassDeclarationSyntax InitSyntaxNode()
        {
            ClassDeclarationSyntax syntaxNode = GetResourceClassDeclaration();

            foreach (ApiaryOperation inputMethod in _inputResource.StandardOperations)
            {
                var outputOptions = new CloudOperationOptions(inputMethod);
                var outputOperation = new CloudOperation(inputMethod, outputOptions);
                syntaxNode = syntaxNode.AddMembers(outputOptions.SyntaxNode, outputOperation.SyntaxNode);
            }

            return syntaxNode;
        }

        private ClassDeclarationSyntax GetResourceClassDeclaration()
        {
            string resourceClassName = $"{_inputResource.PluralResourceName}Client";
            string fullyQualifiedClientClassName = $"{CodegenConfig.Current.CloudClientNamespace}.{CodegenConfig.Current.CloudClientClassName}";
            ClassDeclarationSyntax classDeclaration =
                ClassDeclaration(resourceClassName)
                .WithModifiers(TokenList(
                    Token(SyntaxKind.PublicKeyword)))
                .WithMembers(List(new MemberDeclarationSyntax[] {
                    PropertyDeclaration(
                        IdentifierName(fullyQualifiedClientClassName),
                        Identifier("Client"))
                    .WithModifiers(TokenList(
                        Token(SyntaxKind.PublicKeyword)))
                    .WithAccessorList(AccessorList(List(new AccessorDeclarationSyntax[]{
                        AccessorDeclaration(
                            SyntaxKind.GetAccessorDeclaration)
                        .WithSemicolonToken(Token(SyntaxKind.SemicolonToken)),
                        AccessorDeclaration(
                            SyntaxKind.SetAccessorDeclaration)
                        .WithModifiers(TokenList(
                            Token(SyntaxKind.PrivateKeyword)))
                        .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))}))),
                    ConstructorDeclaration(
                        Identifier(resourceClassName))
                    .WithModifiers(TokenList(
                        Token(SyntaxKind.InternalKeyword)))
                    .WithParameterList(ParameterList(SingletonSeparatedList<ParameterSyntax>(
                        Parameter(
                            Identifier("client"))
                        .WithType(
                            IdentifierName(fullyQualifiedClientClassName)))))
                    .WithBody(Block(SingletonList<StatementSyntax>(
                        ExpressionStatement(
                            AssignmentExpression(
                                SyntaxKind.SimpleAssignmentExpression,
                                IdentifierName("Client"),
                                IdentifierName("client"))))))}));
            return classDeclaration;
        }
    }
}
