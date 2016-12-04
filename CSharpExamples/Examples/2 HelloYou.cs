/*
	This Example shows how to take input and store it in a "variable"
	It also shows how to output a variable with a string
*/

using System; //this means that we use the System namespace, so instead of System.Console.WriteLine We can use Console.WriteLine
namespace CSharpExamples.Examples
{
    //Create HelloYou Class
    public class HelloYou
    {

        //create method        
        public HelloYou()
        {
            //Prompt the user for input
            Console.WriteLine("What is your name?");
            //store input in the variable 'name'
            string name = System.Console.ReadLine();

            //output a string including the 'name' variable
            System.Console.WriteLine("Hello {0}", name);
        }
    }
}
        
     
 