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

using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.Compute.Codegen.Prototype.Input
{
    internal class ApiaryOperation
    {
        private readonly MethodDeclarationSyntax _methodNode;
        private readonly Lazy<ApiaryRequest> _associatedRequest;

        internal ApiaryOperation(MethodDeclarationSyntax methodNode, ApiaryResource parentResource)
        {
            _methodNode = methodNode ?? throw new ArgumentNullException(nameof(methodNode));
            ParentResource = parentResource ?? throw new ArgumentNullException(nameof(parentResource));

            _associatedRequest = new Lazy<ApiaryRequest>(InitAssociatedRequest);
        }

        public IEnumerable<ApiaryRequestParameter> SortedRequiredParameters =>
            from param in _methodNode.GetParameters()
            join reqParam in AssociatedRequest.RequieredParameters on param.GetName() equals reqParam.NameInService
            select reqParam;

        public ApiaryRequest AssociatedRequest => _associatedRequest.Value;

        public ApiaryResource ParentResource { get; }

        public string OperationName => _methodNode.GetName();

        public bool IsStandardOperation => AssociatedRequest.IsStandard;

        public bool IsLongRunningOperation => AssociatedRequest.IsLongRunning;

        public bool IsListOperation => AssociatedRequest.IsList;

        private ApiaryRequest InitAssociatedRequest() =>
            ParentResource.FindRequestClass(_methodNode.GetReturnTypeName());
    }
}
