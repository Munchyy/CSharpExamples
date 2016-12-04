//A showcase on how to change the flow of execution
using System;
namespace CSharpExamples.Examples
{
    public class Branches
    {

        public Branches()
        {

            //'IF' statement

            //if something is true, then do this. (Or if its not true, then do this)
            if (true)
            {
                Console.WriteLine("Always done");
            }
            else
            {
                Console.WriteLine("Never done");
            }


            int x = 10;
            if (x > 0)
            {
                Console.WriteLine("x is bigger than 10");
            }
            else
            {
                Console.WriteLine("x is smaller than or equal to 0");
            }

        }
    }
}