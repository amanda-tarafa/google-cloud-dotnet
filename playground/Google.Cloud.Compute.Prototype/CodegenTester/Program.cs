using Google.Cloud.Compute.Codegen.Prototype;
using Microsoft.CodeAnalysis.MSBuild;
using System;

namespace CodegenTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Codegen codegen = new Codegen();
            var task = codegen.Generate();
            task.Wait();
            Console.WriteLine(task.Exception);
        }
    }
}
