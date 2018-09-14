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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Google.Cloud.Compute.Codegen.Prototype.Output
{
    internal class CloudOperation
    {
        private readonly ApiaryOperation _inputOperation;
        private readonly CloudOperationOptions _options;
        private readonly Lazy<MethodDeclarationSyntax> _syntaxNode;

        internal CloudOperation(ApiaryOperation inputOperation, CloudOperationOptions options)
        {
            _inputOperation = inputOperation ?? throw new ArgumentNullException(nameof(inputOperation));
            _options = options ?? throw new ArgumentNullException(nameof(options));
            _syntaxNode = new Lazy<MethodDeclarationSyntax>(InitSyntaxNode);
        }

        public MethodDeclarationSyntax SyntaxNode => _syntaxNode.Value;

        private MethodDeclarationSyntax InitSyntaxNode()
        {
            string returnTypeName = _inputOperation.AssociatedRequest.RequestReturnTypeName;
            string apiaryOperationName = _inputOperation.OperationName;
            string cloudOperationName = apiaryOperationName.Equals("Get") ?
                GenerateGetOperationName(returnTypeName):
                _inputOperation.OperationName;
            string optionsParameterTypeName = _options.ClassName;
            string requestTypeName = _inputOperation.AssociatedRequest.FullyQualifiedName;
            string apiaryResourcePropertyName = _inputOperation.ParentResource.PluralResourceName;

            List<SyntaxNodeOrToken> parameters = new List<SyntaxNodeOrToken>();
            List<SyntaxNodeOrToken> arguments = new List<SyntaxNodeOrToken>();

            if (_inputOperation.AssociatedRequest.BodyParameter != null)
            {
                string bodyParameterTypeName = _inputOperation.AssociatedRequest.BodyParameter.TypeName;
                string bodyParameterName = GenerateBodyParameterName(bodyParameterTypeName);
                AddParameter(parameters, bodyParameterName, bodyParameterTypeName);
                AddArgument(arguments, bodyParameterName);
            }

            foreach (ApiaryRequestParameter reqParam in _inputOperation.SortedRequiredParameters)
            {
                AddParameter(parameters, reqParam.NameInService, reqParam.TypeName);
                AddArgument(arguments, reqParam.NameInService);
            }

            // Remove the last comma from arguments,
            // no need to do so for receiving because the options parameter is always there.
            if (arguments.Count > 0)
            {
                arguments.RemoveAt(arguments.Count - 1);
            }

            parameters.Add(
                Parameter(
                    Identifier("options"))
                .WithType(
                    IdentifierName(optionsParameterTypeName))
                .WithDefault(
                    EqualsValueClause(
                        LiteralExpression(SyntaxKind.NullLiteralExpression))));

            MethodDeclarationSyntax method =
                MethodDeclaration(
                    IdentifierName(returnTypeName),
                    Identifier(cloudOperationName))
                .WithModifiers(TokenList(
                    Token(SyntaxKind.PublicKeyword)))
                .WithParameterList(ParameterList(SeparatedList<ParameterSyntax>(
                    parameters)))
                .WithBody(
                    Block(
                        LocalDeclarationStatement(
                            VariableDeclaration(
                                IdentifierName(requestTypeName))
                            .WithVariables(SingletonSeparatedList(
                                VariableDeclarator(
                                    Identifier("request"))
                                .WithInitializer(
                                    EqualsValueClause(
                                        InvocationExpression(
                                            MemberAccessExpression(
                                                SyntaxKind.SimpleMemberAccessExpression,
                                                MemberAccessExpression(
                                                    SyntaxKind.SimpleMemberAccessExpression,
                                                    MemberAccessExpression(
                                                        SyntaxKind.SimpleMemberAccessExpression,
                                                        IdentifierName("Client"),
                                                        IdentifierName("InternalService")),
                                                    IdentifierName(apiaryResourcePropertyName)),
                                                IdentifierName(apiaryOperationName)))
                                        .WithArgumentList(ArgumentList(SeparatedList<ArgumentSyntax>(
                                                arguments)))))))),
                        ExpressionStatement(
                            ConditionalAccessExpression(
                                IdentifierName("options"),
                                InvocationExpression(
                                    MemberBindingExpression(
                                        IdentifierName("ModifyRequest")))
                                .WithArgumentList(ArgumentList(SingletonSeparatedList(
                                    Argument(
                                        IdentifierName("request"))))))),
                        ReturnStatement(
                            InvocationExpression(
                                MemberAccessExpression(
                                    SyntaxKind.SimpleMemberAccessExpression,
                                    IdentifierName("request"),
                                    IdentifierName("Execute"))))));

            return method;
        }

        private static string GenerateGetOperationName(string getOperationReturnTypeName)
        {
            //Keep just the class name
            var typeClassName = GetClassNameOnly(getOperationReturnTypeName);
            return $"Get{typeClassName}";
        }

        private static string GenerateBodyParameterName(string bodyParameterTypeName)
        {
            if (bodyParameterTypeName == null)
            {
                return null;
            }
            // Keep just the class name
            var typeClassName = GetClassNameOnly(bodyParameterTypeName);
            var oldFirstLetter = typeClassName.First().ToString();
            var newFirstLetter = oldFirstLetter.ToLower();
            var newName = new StringBuilder(typeClassName);
            newName.Replace(oldFirstLetter, newFirstLetter, 0, 1);
            // Adding this because there was some name clashing with required parameters.
            newName.Append("Entity");
            return newName.ToString();
        }

        private static string GetClassNameOnly(string typeName)
        {
            return typeName.Split('.').Last();
        }

        private static void AddParameter(List<SyntaxNodeOrToken> parameters, string paramName, string paramTypeName)
        {
            parameters.Add(
                Parameter(
                    Identifier(paramName))
                .WithType(
                    IdentifierName(paramTypeName)));
            parameters.Add(
                Token(SyntaxKind.CommaToken));
        }

        private static void AddArgument(List<SyntaxNodeOrToken> arguments, string argName)
        {
            arguments.Add(
                Argument(
                    IdentifierName(argName)));
            arguments.Add(
                Token(SyntaxKind.CommaToken));
        }
    }
}