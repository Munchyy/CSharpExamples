//A showcase on how to change the flow of execution
public class Branches{

	public static void Main(){
		
		//'IF' statement
		
		//if something is true, then do this. (Or if its not true, then do this)
		if (true){
			System.Console.WriteLine("Always done");
		}else{
			System.Console.WriteLine("Never done");
		}
		
		
		int x = 10;
		if (x > 0){
			System.Console.WriteLine("x is bigger than 10");
		}else{
			System.Console.WriteLine("x is smaller than or equal to 0");
		}
		
	}
}