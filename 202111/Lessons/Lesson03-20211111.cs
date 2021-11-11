using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
		
		// From yesterday's class: Variables
		int myAge = 21;
		string myName = "Eduardo";
		
		// Operators and Operands and Results
		int difference = 4 - 2;
		// 4 and 2 are operands
		// minus (-) is an operator
		// 4 - 2 is called an expression
		// expressions produce results based on the operator
		// results can be stored in variables
		Console.WriteLine(difference.ToString()); // ToString() is not needed when printing numbers but it's a good practice
		
		// unary, binary, and ternary
		// unary operators need only one operand
		int negNumber = -difference; // it's the same as multiplying  difference * -1;
		Console.WriteLine(negNumber.ToString());
		
		// binary (arithmetic: +, -, *, /, %)
		int numerator;
		int denominator;
		int quotient;
		int remainder;
		
		numerator = 10;
		denominator = 2;

      	quotient = numerator / denominator;                                
      	remainder = numerator % denominator;                               

      	Console.WriteLine($"{numerator} / {denominator} = {quotient} with remainder {remainder}");
		
		// operators have precedence
		int myResult = 10 * 2 + 5 * 10; // ???? 70 > 20 + 50, what if I was expecting 700?
		// use parenthesis in your code to specify precedence
		int myOtherResult = 10 * (2 + 5) * 10; // the idea is that everything inside parenthesis is resolved first

		Console.WriteLine(myResult);
		Console.WriteLine(myOtherResult);
		
		// Compund Math assignment operators (+=, -=, *=, /=, %=)
		int x = 123;
		x = x + 2; // <<<< 125
		Console.WriteLine(x);
		x += 2;
		Console.WriteLine(x); // <<<< 127
		
		// Increment (++) and decrement (--) operators
		x++;
		// It's the same as these two
		// x = x + 1;
		// x += 1;
		Console.WriteLine(x); // <<<< 128
		x--;
		Console.WriteLine(x);
		
		// Control flow statements
		
		// conditional checks
		// if-else and switch-case
		if (x > 100) // boolean expression: the result will either be true or false
		{
			// executes if condition is true
			if (x - 100 > 25)
			{
				int myInnerValue = 1000;
				Console.WriteLine("Difference is greater than 25");
			}
			else 
			{
				Console.WriteLine("{Difference is lesser than 25");
			}			
		}
		else
		{
			// executes if condition is false
			Console.WriteLine($"{x} is lesser than 100");
		}
		
		int hourOfTheDay = 17;
		if ((10 < hourOfTheDay) && (hourOfTheDay < 24) )// AND results in true when both expressions are true
		  System.Console.WriteLine("Hi-Ho, Hi-Ho, it's off to work we go.");

		if ((10 < hourOfTheDay) || DateTime.Today.DayOfWeek == DayOfWeek.Monday) // OR results in true when at least one of the expressions is true
			Console.WriteLine("OR operator");
		
		string input = "exit";
		switch (input)
		{
			case "continue":
				Console.WriteLine("Continue the game");
				break;
			case "exit":
				Console.WriteLine("Exit the game");
				break;
			default:
				break;
		}
		
		// loop > execute a set of instructions over and over and over
		// while and do-while loops
		int counter = 12;
		while (counter < 10)
		{
			Console.WriteLine(counter++);
		}
		
		do 
		{
			Console.WriteLine(counter++);
		}
		while (counter < 10);
		
		// for and foreach
		for (int i = 0; i < 100; i++)
		{
			Console.Write(i + " ");
		}
		Console.WriteLine();
		
		// foreach can be used for lists or arrays
		int[] numbers = { 10, 90, 80, 34, 56 };
		foreach (int n in numbers)
		{
			Console.Write(n + " ");
		}
		Console.WriteLine();
		
		bool playAgain = false;
		// Game loop example
		do 
		{
			// ask for input from user
			// generate input from computer
			// compare input
			// display result
			// ask to continue
			Console.WriteLine("To play again press Y");
			string userSelection = Console.ReadLine();
			playAgain = (userSelection.ToUpper().Trim() == "Y");
		}
		while (playAgain); // while user choses to continue do another run
		
	}
}