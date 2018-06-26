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
using System;
using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.Compute.Codegen.Prototype.Input
{
    internal class ApiaryOperation
    {
        private readonly MethodDeclarationSyntax _methodNode;

        internal ApiaryOperation(MethodDeclarationSyntax methodNode, ApiaryResource parentResource)
        {
            _methodNode = methodNode ?? throw new ArgumentNullException(nameof(methodNode));
            ParentResource = parentResource ?? throw new ArgumentNullException(nameof(parentResource));

            var associatedRequestTypeName = _methodNode.ReturnType.ToString();
            AssociatedRequest = parentResource.FindRequestClass(associatedRequestTypeName);
        }

        public IEnumerable<ApiaryRequestParameter> SortedRequiredParameters =>
            from param in _methodNode.ParameterList.Parameters
            join reqParam in AssociatedRequest.RequieredParameters on param.Identifier.ToString() equals reqParam.NameInService
            select reqParam;

        public ApiaryRequest AssociatedRequest { get; }

        public ApiaryResource ParentResource { get; }

        public string OperationName => _methodNode.Identifier.ValueText;

        public bool IsLongRunningOperation => AssociatedRequest.IsLongRunning;

        public bool IsListOperation => AssociatedRequest.IsList;

        public bool IsStandardOperation => AssociatedRequest.IsStandard;
    }
}
