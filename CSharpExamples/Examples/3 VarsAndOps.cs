//A showcase of Variables and Operators
public class VarsAndOps{
	public static Main(){
		//
		//Common types
		//
		
		//A "string" is a string of characters
		//i.e. any number of characters that a computer can understand
		string myString = "This could be anything12345^&*($*&";
		
		/*
			NOTE there are sequences of characters that have meaning
			this is started via the "escape character" which is '\'
			For example: '\n' is a newline, '\t' is a tab character
			To use a '\' character, you escape it by using 2: '\\' means '\'
		*/	
		
		//An "int" is an integer, a whole number.
		int smallInt = 1;
		int bigInt = 12432564623423;
		
		/*
			There are other number variables that arent whole numbers, like a float or a double
		*/
		
		//A "bool" is a Boolean variable. Either true, or false
		bool firstBool = true;
		bool secondBool = false;
		/*
			These are used when branching, seen in the next file. e.g. is x bigger than y?
		*/
		
		//
		//Operators
		//
		
		//Basic Operators
		
		//Arithmetics
		int x = 7;
		int y = 5;
		
		int added = x+y;
		//12
		int subbed = x-y;
		//2
		int multiply = x*y
		//35
		int divide = x/y; // this 'should' be a float since it can have decimal places with 2 ints
		//1
		int mod = x%y //this operator finds trhe remainder from an integer division		
		//2
		
		int shortAdd = 1;
		shortAdd += x; //this means shortAdd = shortAdd + x
		//8
		shortAdd -= x;
		//1
		int inc = 0; //increment
		inc++;//this means 'inc = inc + 1'
		//1
		int dec = 0;//decrement
		dec--; //this means 'dec = dec-1'
		//-1
		
	}
}