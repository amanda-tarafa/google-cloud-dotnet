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
using static Google.Cloud.Compute.Codegen.Prototype.RoslynSyntaxFactory;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Google.Cloud.Compute.Codegen.Prototype.Output
{
    internal class CloudOperationOptions
    {
        private const string ModifyRequestMethodName = "ModifyRequest";

        private readonly ApiaryOperation _inputOperation;
        private readonly Lazy<ClassDeclarationSyntax> _optionsClass;
        internal CloudOperationOptions(ApiaryOperation inputOperation)
        {
            _inputOperation = inputOperation ?? throw new ArgumentNullException(nameof(inputOperation));
            _optionsClass = new Lazy<ClassDeclarationSyntax>(InitOptionsClass);
        }

        public string ClassName => OptionsClass.GetName();

        public ClassDeclarationSyntax OptionsClass => _optionsClass.Value;

        private ClassDeclarationSyntax InitOptionsClass()
        {
            var optionsClass = BuildOptionsClassShell();

            foreach (ApiaryRequestParameter queryParam in _inputOperation.AssociatedRequest.OptionalParameters)
            {
                var property = new CloudOperationOptionalParam(queryParam);

                var oldModifyRequestNode = optionsClass.FindMethod(ModifyRequestMethodName);
                var newModifyRequestNode = oldModifyRequestNode.AddBodyStatements(property.OptionsModifyRequestStatement);
                optionsClass = optionsClass.ReplaceNode(oldModifyRequestNode, newModifyRequestNode);

                optionsClass = optionsClass.AddMembers(property.OptionsOptionalParamProperty);
            }

            return optionsClass;
        }

        private ClassDeclarationSyntax BuildOptionsClassShell()
        {
            var modifyRequestMethod =
                VoidMethodDeclaration(ModifyRequestMethodName, SyntaxKind.InternalKeyword)
                .AddParameters(
                    (typeName: _inputOperation.AssociatedRequest.FullyQualifiedName,
                    identifier: CodegenConfig.Current.CloudOptionsModifyRequestParamName))
                .WithEmptyBody();

            var optionsClassNameBase = _inputOperation.OperationName.Equals("Get") ?
                Utils.GenerateGetOperationName(_inputOperation.AssociatedRequest.RequestReturnTypeName) :
                _inputOperation.OperationName;

            return ClassDeclaration($"{optionsClassNameBase}Options", SyntaxKind.PublicKeyword)
                .AddMembers(modifyRequestMethod);
        }
    }
}