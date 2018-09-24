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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google.Cloud.Compute.Codegen.Prototype.Output
{
    internal static class Utils
    {
        public static string GenerateGetOperationName(string resourceName)
        {
            //Keep just the class name
            var typeClassName = GetClassNameOnly(resourceName);
            return $"Get{typeClassName}";
        }

        internal static string GenerateBodyParameterName(string bodyParameterTypeName)
        {
            if (bodyParameterTypeName == null)
            {
                return null;
            }
            // Keep just the class name
            var typeClassName = Utils.GetClassNameOnly(bodyParameterTypeName);
            var oldFirstLetter = typeClassName.First().ToString();
            var newFirstLetter = oldFirstLetter.ToLower();
            var newName = new StringBuilder(typeClassName);
            newName.Replace(oldFirstLetter, newFirstLetter, 0, 1);
            // Adding this because there was some name clashing with required parameters.
            newName.Append("Entity");
            return newName.ToString();
        }

        internal static string GetClassNameOnly(string typeName)
        {
            return typeName.Split('.').Last();
        }
    }
}
