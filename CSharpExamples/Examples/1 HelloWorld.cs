/*
	The basic program for any language is a "Hello World"
	This serves as an example for structure and basic output
*/

//Declare the namespace. This is a "group" of seperate classes that you might want to use together.
namespace CSharpExamples.Examples
{
    //create class called HelloWorld
    public class HelloWorld
    {

        //create Method     
        public HelloWorld()
        {
            //Write "Hello World" to the console
            System.Console.WriteLine("Hello World");

            //this lets us see the console, it will wait for an <enter> instead of ending immediately
            System.Console.ReadLine();
        }
    }
}