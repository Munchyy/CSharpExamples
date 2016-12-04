using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples.Examples
{
    class Loops
    {
        public Loops()
        {

            ///While loop:
            ///This loop keeps repeating as long as a condition is true
            ///
            Console.WriteLine("While Loop 1:");
            int counter = 0;
            //check if the counter is less than 10
            while(counter < 10)
            {
                Console.WriteLine("Counter is " + counter);

                //increment the counter
                counter++;
            }
            Console.WriteLine("Loop exit, Counter: " + counter);
            //counter must have gotten to 10, so the loop exits


            //Infinite Loop:
            //while (true)
            //{
                //Console.WriteLine("Always");
            //}


            ///For loop:
            ///the for loop is better for this use than the while loop, as it is cleaner to run a certain number of times.
            ///the format is: for( /some counter/ ; /some condition for counter/ ; /change counter/ )
            Console.WriteLine("For Loop 1");
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("i = {0}", i);
            }

            Console.WriteLine("For Loop 2");
            for (int i = 2; i < 10000; i*=2)//start counter at 2, double it until its over 10,000
            {
                Console.WriteLine("i = {0}", i);
                //some logic
                int x = i * 9;
            }

        }
    }
}
