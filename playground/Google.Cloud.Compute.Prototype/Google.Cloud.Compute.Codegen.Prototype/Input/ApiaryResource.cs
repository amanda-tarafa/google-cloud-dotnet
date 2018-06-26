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
        private readonly Lazy<IList<ApiaryOperation>> _allOperations;
        private readonly Lazy<IList<ApiaryRequest>> _allClasses;

        internal ApiaryResource(ClassDeclarationSyntax classNode)
        {
            _classNode = classNode ?? throw new ArgumentNullException(nameof(classNode));
            _allOperations = new Lazy<IList<ApiaryOperation>>(InitAllOperations);
            _allClasses = new Lazy<IList<ApiaryRequest>>(InitAllClasses);
        }

        public string ClassName => _classNode.Identifier.ValueText;
        public string FullyQualifiedName => $"{CodegenConfig.Current.ApiaryResourceNamespace}.{ClassName}";

        public string PluralResourceName =>
            ClassName
            .Remove(ClassName.Length - CodegenConfig.Current.ApiaryResourceSuffix.Length);

        public IEnumerable<ApiaryOperation> LongRunningOperations =>
            from operation in _allOperations.Value
            where operation.IsLongRunningOperation
            select operation;

        public IEnumerable<ApiaryOperation> ListOperations =>
            from operation in _allOperations.Value
            where operation.IsListOperation
            select operation;

        public IEnumerable<ApiaryOperation> StandardOperations =>
            from operation in _allOperations.Value
            where operation.IsStandardOperation
            select operation;

        public ApiaryRequest FindRequestClass(string requestClassName)
        {
            return (from request in _allClasses.Value
                    where request.ClassName == requestClassName
                    select request).Single();
        }

        private IList<ApiaryOperation> InitAllOperations()
        {
            return (from method in _classNode.Members.OfType<MethodDeclarationSyntax>()
                    select new ApiaryOperation(method, this)).ToList();
        }

        private IList<ApiaryRequest> InitAllClasses()
        {
            return (from c in _classNode.Members.OfType<ClassDeclarationSyntax>()
                    select new ApiaryRequest(c, this)).ToList();
        }
    }
}
