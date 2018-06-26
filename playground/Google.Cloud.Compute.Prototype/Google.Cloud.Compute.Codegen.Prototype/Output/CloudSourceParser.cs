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
using System.Threading.Tasks;

namespace Google.Cloud.Compute.Codegen.Prototype.Output
{
    internal class CloudSourceParser
    {
        private readonly CloudSourceWriter _writer;

        internal CloudSourceParser()
        {
            _writer = new CloudSourceWriter();
        }

        public void AddResource(ApiaryResource inputResource)
        {
            var outputResource = new CloudResource(inputResource);
            var outputResourceProperty = new CloudResourceProperty(inputResource, outputResource);

            _writer.AddResource(outputResource.SyntaxNode);
            _writer.AddResourcePropertyInClient(outputResourceProperty.PropertySyntaxNode, outputResourceProperty.PropertyInitSyntaxNode);
        }

        public async Task Save()
        {
            await _writer.Save();
        }
    }
}
