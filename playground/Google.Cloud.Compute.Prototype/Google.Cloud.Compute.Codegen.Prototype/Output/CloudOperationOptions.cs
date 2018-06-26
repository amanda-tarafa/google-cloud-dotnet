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
using System.Linq;

namespace Google.Cloud.Compute.Codegen.Prototype.Output
{
    internal class CloudOperationOptions
    {
        private readonly ApiaryOperation _inputOperation;
        private readonly Lazy<ClassDeclarationSyntax> _syntaxNode;
        internal CloudOperationOptions(ApiaryOperation inputOperation)
        {
            _inputOperation = inputOperation ?? throw new ArgumentNullException(nameof(inputOperation));
            _syntaxNode = new Lazy<ClassDeclarationSyntax>(InitSyntaxNode);
        }

        public string ClassName => _syntaxNode.Value.Identifier.ValueText;

        public ClassDeclarationSyntax SyntaxNode => _syntaxNode.Value;

        private ClassDeclarationSyntax InitSyntaxNode()
        {
            var syntaxNode = CSharpSyntaxTree
                .ParseText(Templates.GetOptionsTemplate(_inputOperation.OperationName, _inputOperation.AssociatedRequest.FullyQualifiedName))
                .GetRoot().ChildNodes().Single() as ClassDeclarationSyntax;

            foreach (ApiaryRequestParameter queryParam in _inputOperation.AssociatedRequest.OptionalParameters)
            {
                var property = new CloudOperationOptionsProperty(queryParam);

                var oldModifyRequestNode = (from method in syntaxNode.Members.OfType<MethodDeclarationSyntax>()
                                            select method).Single();
                var newModifyRequestNode = oldModifyRequestNode.AddBodyStatements(property.PropertyModifyRequestSyntax);
                syntaxNode = syntaxNode.ReplaceNode(oldModifyRequestNode, newModifyRequestNode);

                syntaxNode = syntaxNode.AddMembers(property.PropertySyntaxNode);
            }

            return syntaxNode;
        }
    }
}