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
    internal class ApiaryResource
    {
        private readonly ClassDeclarationSyntax _classNode;
        private readonly Lazy<IList<ApiaryOperation>> _operations;
        private readonly Lazy<IList<ApiaryRequest>> _requestClasses;

        internal ApiaryResource(ClassDeclarationSyntax classNode)
        {
            _classNode = classNode ?? throw new ArgumentNullException(nameof(classNode));
            _operations = new Lazy<IList<ApiaryOperation>>(InitOperations);
            _requestClasses = new Lazy<IList<ApiaryRequest>>(InitRequestClasses);
        }

        public string ClassName => _classNode.GetName();
        public string FullyQualifiedName => $"{CodegenConfig.Current.ApiaryResourceNamespace}.{ClassName}";

        public string PluralResourceName =>
            ClassName.Remove(ClassName.Length - CodegenConfig.Current.ApiaryResourceSuffix.Length);

        public IEnumerable<ApiaryOperation> StandardOperations =>
            from operation in _operations.Value
            where operation.IsStandardOperation
            select operation;

        public IEnumerable<ApiaryOperation> LongRunningOperations =>
            from operation in _operations.Value
            where operation.IsLongRunningOperation
            select operation;

        public IEnumerable<ApiaryOperation> ListOperations =>
            from operation in _operations.Value
            where operation.IsListOperation
            select operation;

        private IList<ApiaryOperation> InitOperations() =>
            (from method in _classNode.GetMethods()
             select new ApiaryOperation(method, this)).ToList();

        private IList<ApiaryRequest> InitRequestClasses() =>
            (from c in _classNode.GetInnerClasses()
             select new ApiaryRequest(c, this)).ToList();

        internal ApiaryRequest FindRequestClass(string requestClassName) =>
            (from request in _requestClasses.Value
             where request.ClassName == requestClassName
             select request).Single();
    }
}