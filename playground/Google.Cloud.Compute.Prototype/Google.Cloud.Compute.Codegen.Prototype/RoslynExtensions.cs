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
using System;
using System.Linq;

namespace Google.Cloud.Compute.Codegen.Prototype
{
    internal static class RoslynExtensions
    {
        public static NamespaceDeclarationSyntax GetNamespace(this SyntaxNode node, string namespaceFullName)
        {
            if (namespaceFullName == null)
            {
                throw new ArgumentNullException(nameof(namespaceFullName));
            }

            return (from ns in node?.DescendantNodes().OfType<NamespaceDeclarationSyntax>()
                    where ns.Name.ToString() == namespaceFullName
                    select ns).FirstOrDefault();
        }

        public static Project GetProject(this Workspace workspace, string projectName)
        {
            if (projectName == null)
            {
                throw new ArgumentNullException(nameof(projectName));
            }

            return workspace?.CurrentSolution?.GetProject(projectName);
        }

        public static Project GetProject(this Solution solution, string projectName)
        {
            if (projectName == null)
            {
                throw new ArgumentNullException(nameof(projectName));
            }

            return (from project in solution?.Projects
                    where project.Name == projectName
                    select project).FirstOrDefault();
        }

        public static Document GetDocument(this Project project, string documentName)
        {
            if (documentName == null)
            {
                throw new ArgumentNullException(nameof(documentName));
            }

            return (from document in project?.Documents
                    where document.Name == documentName
                    select document).FirstOrDefault();
        }

        public static Document CreateOrReplaceDocument(this Project project, string documentName, SyntaxNode syntaxRoot)
        {
            return project.GetDocument(documentName)?.WithSyntaxRoot(syntaxRoot) ??
                project.AddDocument(documentName, syntaxRoot);
        }

        public static SyntaxNode Format(this SyntaxNode node, Workspace workspace)
        {
            node = node.WithAdditionalAnnotations(Formatter.Annotation);
            return Formatter.Format(node, workspace);
        }
    }
}
