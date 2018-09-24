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
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Formatting;
using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.Compute.Codegen.Prototype
{
    internal static class RoslynExtensions
    {
        public static NamespaceDeclarationSyntax FindNamespace(this SyntaxNode node, string namespaceFullName) =>
            (from ns in node?.DescendantNodes().OfType<NamespaceDeclarationSyntax>()
             where ns.Name.ToString() == namespaceFullName
             select ns).SingleOrDefault();

        public static IEnumerable<ClassDeclarationSyntax> FindClassesWithSuffix(this NamespaceDeclarationSyntax @namespace, string suffix) =>
            from c in @namespace?.Members.OfType<ClassDeclarationSyntax>()
            where c.GetName().EndsWith(suffix)
            select c;

        public static string GetName(this ClassDeclarationSyntax @class) =>
            @class.Identifier.ValueText;

        public static IEnumerable<MethodDeclarationSyntax> GetMethods(this ClassDeclarationSyntax @class) =>
            @class.Members.OfType<MethodDeclarationSyntax>();

        public static MethodDeclarationSyntax FindMethod(this ClassDeclarationSyntax @class, string methodName) =>
            (from m in @class.GetMethods()
             where m.GetName() == methodName
             select m).SingleOrDefault();

        public static PropertyDeclarationSyntax FindProperty(this ClassDeclarationSyntax @class, string propertyName) =>
            (from property in @class.Members.OfType<PropertyDeclarationSyntax>()
             where property.GetName() == propertyName
             select property).SingleOrDefault();

        public static IEnumerable<(PropertyDeclarationSyntax property, AttributeSyntax attribute)> FindPropertiesWithAttribute(this ClassDeclarationSyntax @class, string attributeName) =>
            from property in @class.Members.OfType<PropertyDeclarationSyntax>()
            from attributes in property.AttributeLists
            from attribute in attributes.Attributes
            where attribute.Name.ToString() == attributeName
            select (property, attribute);

        public static IEnumerable<ClassDeclarationSyntax> GetInnerClasses(this ClassDeclarationSyntax @class) =>
            @class.Members.OfType<ClassDeclarationSyntax>();

        public static GenericNameSyntax FindGenericBaseType(this ClassDeclarationSyntax @class, string typeName) =>
            (from baseType in @class.BaseList.Types
             from genericType in baseType.ChildNodes().OfType<GenericNameSyntax>()
             where genericType.GetName() == typeName
             select genericType).SingleOrDefault();

        public static string GetName(this MethodDeclarationSyntax method) =>
            method.Identifier.ValueText;

        public static string GetReturnTypeName(this MethodDeclarationSyntax method) =>
            method.ReturnType.GetName();

        public static IEnumerable<ParameterSyntax> GetParameters(this MethodDeclarationSyntax method)
            => method.ParameterList.Parameters;

        public static string GetName(this PropertyDeclarationSyntax property) =>
            property.Identifier.ValueText;

        public static IEnumerable<TypeSyntax> GetTypeArguments(this GenericNameSyntax genericName) =>
            genericName.TypeArgumentList.Arguments;

        public static string GetName(this GenericNameSyntax genericName) =>
            genericName.Identifier.ValueText;

        public static string GetName(this TypeSyntax type) =>
            type.ToString();

        public static string GetName(this ParameterSyntax parameter) =>
            parameter.Identifier.ValueText;

        public static string GetFirstArgumentTextLiteral(this AttributeSyntax attribute) =>
            (attribute.ArgumentList.Arguments.FirstOrDefault()?.Expression as LiteralExpressionSyntax).Token.ValueText;

        public static string GetFirstArgumentTextLiteral(this InvocationExpressionSyntax invocation) =>
            (invocation.ArgumentList.Arguments.FirstOrDefault()?.Expression as LiteralExpressionSyntax).Token.ValueText;

        public static T GetFirstArgumentOfType<T>(this InvocationExpressionSyntax invocation) =>
            (from argument in invocation.ArgumentList.Arguments
            from node in argument.ChildNodes().OfType<T>()
            select node).FirstOrDefault();

        public static string GetAssignedTextValueFor(this InitializerExpressionSyntax initializer, string propertyName) =>
            (from assignment in initializer.Expressions.OfType<AssignmentExpressionSyntax>()
             where assignment.Left.ToString() == propertyName
             select assignment.Right.ToString()).SingleOrDefault();

        public static Project GetProject(this Workspace workspace, string projectName) =>
            workspace?.CurrentSolution?.GetProject(projectName);

        public static Project GetProject(this Solution solution, string projectName) =>
            (from project in solution?.Projects
             where project.Name == projectName
             select project).FirstOrDefault();

        public static Document GetDocument(this Project project, string documentName) =>
            (from document in project?.Documents
             where document.Name == documentName
             select document).FirstOrDefault();

        public static Document CreateOrReplaceDocument(this Project project, string documentName, SyntaxNode syntaxRoot) =>
            project.GetDocument(documentName)?.WithSyntaxRoot(syntaxRoot) ??
            project.AddDocument(documentName, syntaxRoot);

        public static SyntaxNode Format(this SyntaxNode node, Workspace workspace)
        {
            node = node.WithAdditionalAnnotations(Formatter.Annotation);
            return Formatter.Format(node, workspace);
        }
    }
}
