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
using System.Linq;
using System.Text;

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
            var returnTypeName = _inputOperation.AssociatedRequest.RequestReturnTypeName;
            var apiaryOperationName = _inputOperation.OperationName;
            var cloudOperationName = _inputOperation.OperationName.Equals("Get")?
                GenerateGetOperationName(returnTypeName):
                _inputOperation.OperationName;

            var sortedRequiredParameters =
                (from reqParam in _inputOperation.SortedRequiredParameters
                 select new Tuple<string, string>(reqParam.TypeName, reqParam.NameInService)).ToArray();

            // The body parameter can be null
            var bodyParameterTypeName = _inputOperation.AssociatedRequest.BodyParameter?.TypeName;
            // The name on apiary is Body, so we build a better one based on the type.
            var bodyParameterName = GenerateBodyParameterName(bodyParameterTypeName);

            var optionsParameterType = _options.ClassName;
            var associatedRequestTypeName = _inputOperation.AssociatedRequest.FullyQualifiedName;
            var apiaryParentResourcePropertyName = _inputOperation.ParentResource.PluralResourceName;

            var syntaxNode = CSharpSyntaxTree
                .ParseText(Templates.GetStandardOperationTemplate(
                    returnTypeName, cloudOperationName, apiaryOperationName,
                    sortedRequiredParameters,
                    bodyParameterName, bodyParameterTypeName,
                    optionsParameterType,
                    associatedRequestTypeName, apiaryParentResourcePropertyName))
                .GetRoot().ChildNodes().Single() as MethodDeclarationSyntax;

            return syntaxNode;
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
    }
}