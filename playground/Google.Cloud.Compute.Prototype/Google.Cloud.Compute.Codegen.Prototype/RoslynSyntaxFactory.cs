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
using System.Linq;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Google.Cloud.Compute.Codegen.Prototype
{
    public static class RoslynSyntaxFactory
    {
        public static NamespaceDeclarationSyntax NamespaceDeclaration(string namespaceName) =>
            SyntaxFactory.NamespaceDeclaration(IdentifierName(namespaceName));

        public static ClassDeclarationSyntax ClassDeclaration(string className, params SyntaxKind[] modifiers)
        {
            var @class = SyntaxFactory.ClassDeclaration(className);
            return modifiers.Length == 0 ? @class : @class.AddModifiers(Tokens(modifiers));
        }

        public static ConstructorDeclarationSyntax ConstructorDeclaration(string constructorName, params SyntaxKind[] modifiers)
        {
            var constructor = SyntaxFactory.ConstructorDeclaration(constructorName);
            return modifiers.Length == 0 ? constructor : constructor.AddModifiers(Tokens(modifiers));
        }

        public static ConstructorDeclarationSyntax AddParameters(this ConstructorDeclarationSyntax constructor, params (string typeName, string identifier)[] parameters) =>
            parameters.Length == 0 ? constructor : constructor.AddParameterListParameters(Parameters(parameters));

        public static MethodDeclarationSyntax VoidMethodDeclaration(string methodName, params SyntaxKind[] modifiers)
        {
            var method = SyntaxFactory.MethodDeclaration(PredefinedType(Token(SyntaxKind.VoidKeyword)), methodName);
            return modifiers.Length == 0 ? method : method.AddModifiers(Tokens(modifiers));
        }

        public static MethodDeclarationSyntax MethodDeclaration(string returnTypeName, string methodName, params SyntaxKind[] modifiers)
        {
            var method = SyntaxFactory.MethodDeclaration(IdentifierName(returnTypeName), methodName);
            return modifiers.Length == 0 ? method : method.AddModifiers(Tokens(modifiers));
        }

        public static MethodDeclarationSyntax WithEmptyBody(this MethodDeclarationSyntax method) =>
            method.WithBody(Block());

        public static MethodDeclarationSyntax AddParameters(this MethodDeclarationSyntax method, params (string typeName, string identifier)[] parameters) =>
            parameters.Length == 0 ? method : method.AddParameterListParameters(Parameters(parameters));

        public static PropertyDeclarationSyntax PropertyDeclaration(string typeName, string propertyName, params SyntaxKind[] modifiers)
        {
            var property = SyntaxFactory.PropertyDeclaration(IdentifierName(typeName), Identifier(propertyName));
            return modifiers.Length == 0 ? property : property.AddModifiers(Tokens(modifiers));
        }

        public static PropertyDeclarationSyntax WithGet(this PropertyDeclarationSyntax property, StatementSyntax[] statements = null, params SyntaxKind[] modifiers) =>
            property.WithAccessor(
                AccessorDeclaration(SyntaxKind.GetAccessorDeclaration),
                statements,
                modifiers);

        public static PropertyDeclarationSyntax WithSet(this PropertyDeclarationSyntax property, StatementSyntax[] statements = null, params SyntaxKind[] modifiers) =>
            property.WithAccessor(
                AccessorDeclaration(SyntaxKind.SetAccessorDeclaration),
                statements,
                modifiers);

        private static PropertyDeclarationSyntax WithAccessor(
            this PropertyDeclarationSyntax property, AccessorDeclarationSyntax accessor, 
            StatementSyntax[] statements = null, params SyntaxKind[] modifiers)
        {
            accessor = (statements == null || statements.Length == 0) ?
                accessor.WithSemicolonToken(Token(SyntaxKind.SemicolonToken)) :
                accessor.AddBodyStatements(statements);

            accessor = modifiers.Length == 0 ? accessor : accessor.AddModifiers(Tokens(modifiers));

            return property.AddAccessorListAccessors(accessor);
        }

        public static StatementSyntax SimpleAssignmentStatement(string left, string right) =>
            SimpleAssignmentStatement(IdentifierName(left), IdentifierName(right));

        public static StatementSyntax SimpleAssignmentStatement(string left, ExpressionSyntax right) =>
            SimpleAssignmentStatement(IdentifierName(left), right);

        public static StatementSyntax SimpleAssignmentStatement(ExpressionSyntax left, string right) =>
            SimpleAssignmentStatement(left, IdentifierName(right));

        public static StatementSyntax SimpleAssignmentStatement(ExpressionSyntax left, ExpressionSyntax right) =>
            ExpressionStatement(
                AssignmentExpression(
                    SyntaxKind.SimpleAssignmentExpression,
                    left,
                    right));

        public static MemberAccessExpressionSyntax SimpleMemberAccessExpression(string first, string second, params string[] rest)
        {
            var accessExpression = 
                MemberAccessExpression(
                    SyntaxKind.SimpleMemberAccessExpression,
                    IdentifierName(first),
                    IdentifierName(second));
            foreach(string part in rest)
            {
                accessExpression =
                    MemberAccessExpression(
                        SyntaxKind.SimpleMemberAccessExpression,
                        accessExpression,
                        IdentifierName(part));
            }

            return accessExpression;
        }

        public static InvocationExpressionSyntax AddArguments(this InvocationExpressionSyntax invocation, params string[] arguments) =>
            invocation.AddArgumentListArguments(
                (from arg in arguments
                select Argument(IdentifierName(arg))).ToArray());

        public static ExpressionStatementSyntax CondionalSimpleInvocationStatement(string checkNotNull, string invokeIfNotNull, params string[] invocationArguments)
        {
            var invocation =
                InvocationExpression(
                    MemberBindingExpression(
                        IdentifierName(invokeIfNotNull)));
            if(invocationArguments.Length > 0)
            {
                invocation = invocation.AddArguments(invocationArguments);
            }

            return
                ExpressionStatement(
                    ConditionalAccessExpression(
                        IdentifierName(checkNotNull),
                        invocation));
        }

        public static LocalDeclarationStatementSyntax LocalVariableDeclarationStatement(
            string typeName, string varName, ExpressionSyntax initializer) =>
            LocalDeclarationStatement(
                VariableDeclaration(
                    IdentifierName(typeName),
                    SingletonSeparatedList(
                        VariableDeclarator(varName)
                        .WithInitializer(EqualsValueClause(initializer)))));
                            
        
        public static ObjectCreationExpressionSyntax ObjectCreationExpression(string typeName) =>
            SyntaxFactory.ObjectCreationExpression(IdentifierName(typeName));

        public static BinaryExpressionSyntax NotNullExpression(string nullableName) =>
            BinaryExpression(
                    SyntaxKind.NotEqualsExpression,
                    IdentifierName(nullableName),
                    LiteralExpression(SyntaxKind.NullLiteralExpression));

        public static ParameterSyntax[] Parameters(params (string typeName, string identifier)[] parameters) =>
            (from parameter in parameters
             select 
             Parameter(Identifier(parameter.identifier))
             .WithType(IdentifierName(parameter.typeName))).ToArray();

        private static SyntaxToken[] Tokens(SyntaxKind[] tokenValues) =>
            (from v in tokenValues
             select Token(v)).ToArray();
    }
}
