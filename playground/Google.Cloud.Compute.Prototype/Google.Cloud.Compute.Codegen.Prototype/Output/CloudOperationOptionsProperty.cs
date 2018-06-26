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
            CSharpSyntaxTree
            .ParseText(Templates.GetOptionsPropertyTemplate(_inputParameter.NameInRequest, _inputParameter.TypeName))
            .GetRoot().ChildNodes().Single() as PropertyDeclarationSyntax;

        public StatementSyntax PropertyModifyRequestSyntax
        {
            get
            {
                string template = _inputParameter.IsNullable ?
                    Templates.GetOptionsNullablePropertyModifyRequestTemplate(_inputParameter.NameInRequest) :
                    Templates.GetOptionsPropertyModifyRequestTemplate(_inputParameter.NameInRequest);

                return SyntaxFactory.ParseStatement(template);
            }
        }
    }
}
