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
using System.Collections.Generic;
using System.Linq;
using static Google.Cloud.Compute.Codegen.Prototype.RoslynSyntaxFactory;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Google.Cloud.Compute.Codegen.Prototype.Output
{
    internal class CloudOperation
    {
        private readonly ApiaryOperation _inputOperation;
        private readonly CloudOperationOptions _options;
        private readonly Lazy<MethodDeclarationSyntax> _method;

        internal CloudOperation(ApiaryOperation inputOperation, CloudOperationOptions options)
        {
            _inputOperation = inputOperation ?? throw new ArgumentNullException(nameof(inputOperation));
            _options = options ?? throw new ArgumentNullException(nameof(options));
            _method = new Lazy<MethodDeclarationSyntax>(InitiMethodDeclaration);
        }

        public MethodDeclarationSyntax MethodDeclaration => _method.Value;

        private MethodDeclarationSyntax InitiMethodDeclaration()
        {
            string returnTypeName = _inputOperation.AssociatedRequest.RequestReturnTypeName;
            string apiaryOperationName = _inputOperation.OperationName;
            string cloudOperationName = apiaryOperationName.Equals("Get") ?
                Utils.GenerateGetOperationName(returnTypeName):
                _inputOperation.OperationName;

            List<(string typeName, string identifier)> parameters = new List<(string typeName, string identifier)>();
            List<string> arguments = new List<string>();

            // If there is one, add body as parameter and argument.
            if (_inputOperation.AssociatedRequest.BodyParameter != null)
            {
                string bodyParameterTypeName = _inputOperation.AssociatedRequest.BodyParameter.TypeName;
                string bodyParameterName = Utils.GenerateBodyParameterName(bodyParameterTypeName);
                parameters.Add((typeName: bodyParameterTypeName, identifier: bodyParameterName));
                arguments.Add(bodyParameterName);
            }

            // Then add all the requiered parameters/arguments.
            foreach (ApiaryRequestParameter reqParam in _inputOperation.SortedRequiredParameters)
            {
                parameters.Add((typeName: reqParam.TypeName, identifier: reqParam.NameInService));
                arguments.Add(reqParam.NameInService);
            }

            // Creating the options parameter on it's own because of the default value.
            var optionsParameter =
                Parameters((typeName: _options.ClassName, identifier: "options")).First()
                .WithDefault(EqualsValueClause(LiteralExpression(SyntaxKind.NullLiteralExpression)));

            // Operation method declaration. No method body at this point.
            var method =
                MethodDeclaration(
                    returnTypeName,
                    cloudOperationName,
                    SyntaxKind.PublicKeyword)
                .AddParameters(parameters.ToArray())
                .AddParameterListParameters(optionsParameter);

            // The method body is composed of 3 statements.
            // The fist one is the declaration of the request object.
            var requestDeclaration =
                LocalVariableDeclarationStatement(
                    _inputOperation.AssociatedRequest.FullyQualifiedName,
                    "request",
                    InvocationExpression(
                        SimpleMemberAccessExpression(
                            "Client",
                            "InternalService",
                            _inputOperation.ParentResource.PluralResourceName,
                            apiaryOperationName))
                    .AddArguments(arguments.ToArray()));

            // The second one is the one that modifies the request if there are options set.
            var modifyRequest =
                CondionalSimpleInvocationStatement(
                    "options",
                    "ModifyRequest",
                    "request");

            //The third one simply returns the result of executing the request.
            var returnExecute =
                ReturnStatement(
                    InvocationExpression(
                        SimpleMemberAccessExpression(
                            "request",
                            "Execute")));

            //Now we can add the three statements to the method body.
            return method.AddBodyStatements(
                requestDeclaration,
                modifyRequest,
                returnExecute);
        }
    }
}