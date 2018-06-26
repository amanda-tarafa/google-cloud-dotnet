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

using Google.Apis.Compute.v1.Data;
using Google.Cloud.Compute.Prototype;
using System;
using TestProgram.Comparison;

namespace TestProgram.Generated
{
    public static class GeneratedCompute
    {
        /// <summary>
        /// This method shows how usage of the apiary client wrapper would look like
        /// </summary>
        public static void Run()
        {
            // Client creation (hiding credential obtention)
            ComputeClient computeClient = ComputeClient.Create(project: APIsComparisons.ProjectID);
            Console.WriteLine("ComputeService created");

            // Normal operation (hiding request object) (using the project and zone set)
            Instance instance = computeClient.Instances.GetInstance(APIsComparisons.ProjectID, APIsComparisons.ComputeZoneID, APIsComparisons.ComputeInstanceID);
            Console.WriteLine($"Compute instance of name {instance.Name} gotten.");

            //// Long running operation (entirely hiding polling) (using the project and zone set)
            //computeClient.Instances.ResetInstance(APIsComparisons.ComputeInstanceID);
            //Console.WriteLine("Instance reset");

            //// Unsetting to test overload that receives these
            //computeClient.Project = null;
            //computeClient.Instances.Zone = null;

            //// Long running operation (allowing client code to poll until completed at will)
            //Operation operation = computeClient.Instances.StartResetInstanceOperation(
            //    APIsComparisons.ProjectID, APIsComparisons.ComputeZoneID, APIsComparisons.ComputeInstanceID);
            //computeClient.Operations.PollUntilCompleted(APIsComparisons.ProjectID, operation);
            //Console.WriteLine("Instance reset");

            //// List operation (hiding paging logic and returning an IEnumerable)
            //IEnumerable<Instance> instances = computeClient.Instances.ListInstances(
            //    APIsComparisons.ProjectID, APIsComparisons.ComputeZoneID);
            //foreach (Instance ins in instances)
            //    Console.WriteLine(ins.Name);
        }
    }
}
