using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
		
		// Chapter 11 Exception handling
		// try/catch block > try/catch/finally(optional)
		
		// catching exception > use try blocks to enclose segments of code that might fail
		
		try 
		{ // here goes the code that might fail
			// throwing exceptions when there's a mistake in our program
			Console.WriteLine("Please select A or B");
			string input = Console.ReadLine();

			if (input == "A" || input == "B")
			{
				Console.WriteLine("Right choice!");
				// do something else
			}
			else 
			{
				// whatever they entered is not an A or a B so it's invalid
				throw new InvalidOperationException("This is an invalid operation");
				// nothing else will get executed in this case
				Console.WriteLine("This will not be seen");
			}
			
			// Exception will be thrown if I enter 0 or a symbol or letter
			Console.WriteLine("Enter a number");
			string number = Console.ReadLine();
			int result = 100 / int.Parse(number);
		}
		catch(InvalidOperationException ex) // catches exceptions of this type only
		{
			Console.WriteLine(ex.Message + " " + ex.GetType().ToString());
		}
		catch(Exception ex) // catches exceptions of any type that haven't been caught before
		{
			Console.WriteLine(ex.Message + " " + ex.GetType().ToString());			
		}
		finally 
		{
			// optional block, always runs
			Console.WriteLine("Cleanup tasks");
		}
			
		// Guidelines
		// 1) Always throw an exception according to what happened
		// SqlConnectionException to signify an werror while connecting to the database
		// InvalidOperationException to signify that something the user tried to do is not valid, etc
		// 2) Always provide an explanatory message		
	}
}