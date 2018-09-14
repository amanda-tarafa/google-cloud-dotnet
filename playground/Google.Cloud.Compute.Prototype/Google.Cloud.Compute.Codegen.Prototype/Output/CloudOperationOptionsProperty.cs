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
    internal class CloudOperationOptionsProperty
    {
        private readonly ApiaryRequestParameter _inputParameter;

        internal CloudOperationOptionsProperty(ApiaryRequestParameter inputParameter)
        {
            _inputParameter = inputParameter ?? throw new ArgumentNullException(nameof(inputParameter));
        }

        public PropertyDeclarationSyntax PropertySyntaxNode =>
            GetPropertyDeclaration();

        public StatementSyntax PropertyModifyRequestSyntax
            => GetModifyPropertyStatement();

        private PropertyDeclarationSyntax GetPropertyDeclaration()
        {
            PropertyDeclarationSyntax property =
                PropertyDeclaration(
                    IdentifierName(_inputParameter.TypeName),
                    Identifier(_inputParameter.NameInRequest))
                .WithModifiers(TokenList(
                    Token(SyntaxKind.PublicKeyword)))
                .WithAccessorList(AccessorList(List(new AccessorDeclarationSyntax[]{
                    AccessorDeclaration(
                        SyntaxKind.GetAccessorDeclaration)
                    .WithSemicolonToken(Token(SyntaxKind.SemicolonToken)),
                    AccessorDeclaration(
                        SyntaxKind.SetAccessorDeclaration)
                    .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))})));
            return property;
        }

        private StatementSyntax GetModifyPropertyStatement()
        {
            ExpressionSyntax condition = _inputParameter.IsNullable ?
                MemberAccessExpression(
                    SyntaxKind.SimpleMemberAccessExpression,
                    IdentifierName(_inputParameter.NameInRequest),
                    IdentifierName("HasValue")) as ExpressionSyntax:
                BinaryExpression(
                    SyntaxKind.NotEqualsExpression,
                    IdentifierName(_inputParameter.NameInRequest),
                    LiteralExpression(SyntaxKind.NullLiteralExpression));

            IfStatementSyntax statement =
                IfStatement(
                    condition,
                    Block(SingletonList<StatementSyntax>(
                        ExpressionStatement(
                            AssignmentExpression(
                                SyntaxKind.SimpleAssignmentExpression,
                                    MemberAccessExpression(
                                        SyntaxKind.SimpleMemberAccessExpression,
                                        IdentifierName(CodegenConfig.Current.CloudOptionsModifyRequestParamName),
                                        IdentifierName(_inputParameter.NameInRequest)),
                                    IdentifierName(_inputParameter.NameInRequest))))));
            return statement;
        }
    }
}
