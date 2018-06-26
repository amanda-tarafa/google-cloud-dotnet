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
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System;
using System.IO;

namespace Google.Cloud.Compute.Codegen.Prototype.Input
{
    internal class ApiarySourceReader
    {
        private readonly Lazy<SyntaxNode> _syntaxRoot;

        internal ApiarySourceReader()
        {
            _syntaxRoot = new Lazy<SyntaxNode>(InitSyntaxRoot);
        }

        public NamespaceDeclarationSyntax ResourcesNamespace =>
            _syntaxRoot.Value.GetNamespace(CodegenConfig.Current.ApiaryResourceNamespace);

        public NamespaceDeclarationSyntax DataNamespace =>
            _syntaxRoot.Value.GetNamespace(CodegenConfig.Current.ApiaryDataNamespace);

        private SyntaxNode InitSyntaxRoot()
        {
            using (var sourceFile = new FileStream(CodegenConfig.Current.ApiarySourcePath, FileMode.Open))
            {
                var sourceText = SourceText.From(sourceFile);
                return CSharpSyntaxTree.ParseText(sourceText).GetRoot();
            }
        }
    }
}
