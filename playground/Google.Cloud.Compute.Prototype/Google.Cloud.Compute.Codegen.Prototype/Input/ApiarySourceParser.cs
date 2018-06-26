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
    internal class ApiarySourceParser
    {
        private readonly ApiarySourceReader _reader;
        private readonly Lazy<IList<ApiaryResource>> _resources;

        internal ApiarySourceParser()
        {
            _reader = new ApiarySourceReader();
            _resources = new Lazy<IList<ApiaryResource>>(InitResources);
        }

        public IEnumerable<ApiaryResource> Resources => _resources.Value;

        private IList<ApiaryResource> InitResources()
        {
            return (from c in _reader.ResourcesNamespace?.Members.OfType<ClassDeclarationSyntax>()
                    where c.Identifier.ValueText.EndsWith(CodegenConfig.Current.ApiaryResourceSuffix)
                    select new ApiaryResource(c)).ToList();
        }
    }
}
