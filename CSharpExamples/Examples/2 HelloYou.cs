/*
	This Example shows how to take input and store it in a "variable"
	It also shows how to output a variable with a string
*/
//Create HelloYou Class
public class HelloYou{
    //create Main method        
    public static void Main(){
		//store input in the variable 'name'
        string name = System.Console.ReadLine("Please enter your name: ");
        
		//output a string including the 'name' variable
        System.Console.WriteLine("Hello {0}", name);
    }
}
        
     
 