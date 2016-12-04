using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSharpExamples.Examples;
namespace CSharpExamples
{
    class Program
    {
        public static void Main()
        {
            //run each example that has meaningful output
            Console.WriteLine("Starting 1: Hello World");
            HelloWorld ex1 = new HelloWorld();
            Console.WriteLine("Starting 2: Hello You");
            HelloYou ex2 = new HelloYou();
            Console.WriteLine("Starting 4: Branches");
            Branches ex4 = new Branches();
            Console.WriteLine("Starting 5: Loops");
            Loops ex5 = new Loops();

            Console.ReadLine();
        }
    }
}
