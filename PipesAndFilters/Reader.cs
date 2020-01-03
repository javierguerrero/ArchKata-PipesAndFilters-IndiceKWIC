using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PipesAndFilters
{
    public class Reader : IOperation<string>
    {
        public IEnumerable<string> Execute(IEnumerable<string> input)
        {
            Console.Title = "Pipes and Filters Pattern in .NET";
            Console.WriteLine("Enter the path of the file:");
            return File.ReadLines(Console.ReadLine());
        }
    }
}