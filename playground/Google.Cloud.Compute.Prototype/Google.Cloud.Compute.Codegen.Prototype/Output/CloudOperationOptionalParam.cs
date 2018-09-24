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
using static Google.Cloud.Compute.Codegen.Prototype.RoslynSyntaxFactory;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Google.Cloud.Compute.Codegen.Prototype.Output
{
    internal class CloudOperationOptionalParam
    {
        private readonly ApiaryRequestParameter _inputParameter;
        private readonly Lazy<PropertyDeclarationSyntax> _property;
        private readonly Lazy<StatementSyntax> _modifyRequest;

        internal CloudOperationOptionalParam(ApiaryRequestParameter inputParameter)
        {
            _inputParameter = inputParameter ?? throw new ArgumentNullException(nameof(inputParameter));

            _property = new Lazy<PropertyDeclarationSyntax>(InitiOptionsProperty);
            _modifyRequest = new Lazy<StatementSyntax>(InitModifyRequestStatement);
        }

        public PropertyDeclarationSyntax OptionsOptionalParamProperty =>
            _property.Value;

        public StatementSyntax OptionsModifyRequestStatement =>
            _modifyRequest.Value;

        private PropertyDeclarationSyntax InitiOptionsProperty()
        {
            return 
                PropertyDeclaration(
                    _inputParameter.TypeName,
                    _inputParameter.NameInRequest,
                    SyntaxKind.PublicKeyword)
                .WithGet()
                .WithSet();
        }

        private StatementSyntax InitModifyRequestStatement()
        {
            ExpressionSyntax notNullCheck = _inputParameter.IsNullable ?
                SimpleMemberAccessExpression(_inputParameter.NameInRequest, "HasValue") as ExpressionSyntax :
                NotNullExpression(_inputParameter.NameInRequest);

            IfStatementSyntax statement =
                IfStatement(
                    notNullCheck,
                    Block(
                        SimpleAssignmentStatement(
                            SimpleMemberAccessExpression(
                                CodegenConfig.Current.CloudOptionsModifyRequestParamName,
                                _inputParameter.NameInRequest),
                            _inputParameter.NameInRequest)));

            return statement;
        }
    }
}
