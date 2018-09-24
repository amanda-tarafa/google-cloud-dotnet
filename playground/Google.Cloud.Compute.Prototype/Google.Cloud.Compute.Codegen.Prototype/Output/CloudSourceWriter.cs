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
using Microsoft.CodeAnalysis.MSBuild;
using System.Threading.Tasks;

namespace Google.Cloud.Compute.Codegen.Prototype.Output
{
    internal class CloudSourceWriter
    {
        public async Task Save(CompilationUnitSyntax resources, CompilationUnitSyntax client)
        {
            using (MSBuildWorkspace workspace = MSBuildWorkspace.Create())
            {
                Task<Solution> solutionTask = workspace.OpenSolutionAsync(
                    CodegenConfig.Current.CloudSolutionFilePath);

                resources = resources.Format(workspace) as CompilationUnitSyntax;
                client = client.Format(workspace) as CompilationUnitSyntax;

                var solution = await solutionTask;
                var project = solution.GetProject(CodegenConfig.Current.CloudProjectName);

                var resourcesDocument = project.CreateOrReplaceDocument(
                    CodegenConfig.Current.CloudResourcesFileName, resources);

                // Update our local project reference because the whole structure is inmutable.
                project = resourcesDocument.Project;

                var clientDocument = project.CreateOrReplaceDocument(
                    CodegenConfig.Current.CloudClientFileName, client);
                // Update our local project reference because the whole structure is inmutable.
                project = clientDocument.Project;

                workspace.TryApplyChanges(project.Solution);
                workspace.CloseSolution();
            }
        }
    }
}
