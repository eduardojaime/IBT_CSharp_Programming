using System;
					
public class Program
{
	public static void Main()
	{
		// variables using c# keywords
		int myNumber = 10;
		string myName = "Eduardo";
		
		// Base class library (BCL) version of the name
		Int32 myIntNumber = 10; // same as writing int myIntNumber = 10;
		String myFullName = "Eduardo Jaime"; //same as string (lower case);
		
		// in C# everything is either text or number
		
		// Int types
		long myVeryLongNumber = 9000000000000000;
		byte myNotVeryLongNumber = 255; // how come??? why not 256???
		
		// 1 byte is 8 bits 11111111 = 255
		
		// what happens when I do:
		int myNewNumber = 10; // 32 bytes of memory??? pls??
		
		// what can we use to represent numbers with decimal digits?
		// float double and decimal
		float myValue1 = 10.99F;
		double myValue2 = 19.232D; // literal numbers with decimal digits are considered double by default
		decimal myValue3 = 12.23232M; // M as in Money because decimal is recommeded for financial values
				
		// Literal Value
		Console.WriteLine(Math.PI);
		
		const int WEEKS_IN_YEAR = 52;
		int partTimeHours = 20;
		decimal hourlyRate = 14.30M;
		
		decimal myTotal2 = (14 * 20 * 52); // << what's this?
		decimal myTotal3 = (hourlyRate * partTimeHours * WEEKS_IN_YEAR); // << what's this? Yearly Salary
		
		double myInput = 10.20; // but imagine I got it from the user via the console
		double taxRate = 1.15D; // and maybe this is also retrieved from a database or a config file
		
		double total = myInput * taxRate; // magic numbers > hardcoded values > 
		
		bool isThisTrue = true;
		bool isThisFalse = false;
		char letterA = 'A'; // one single character in Unicode
		
		Console.WriteLine((int)letterA);
		
		// Escape character \
		///Console.Write("I'm Eduardo and I say "Hello World!"");
		// most common ones are \" and \n
		Console.Write("I'm Eduardo and I say \"Hello World!\" \n\t This is a new line \n");
		string firstName = "Eduardo";
		string lastName = "Jaime";
		
		// string interpolation
		string fullName = $"      Your full name is {firstName} {lastName}      ";
		Console.WriteLine(fullName);
		
		string fullNameAllUpperCase = fullName.ToUpper(); // will convert string to upper case
		Console.WriteLine(fullNameAllUpperCase.Trim());
		Console.WriteLine(fullNameAllUpperCase.Replace('A', '@'));
		
		string numStr = "100";
		int numInt; // >> 0000000000000000 == 0
		
		// conversion
		// Parse(), TryParse()
		bool wasItSuccessfull = int.TryParse(numStr, out numInt); // tries to convert, but if it fails it doesn't alter the output variable
		Console.WriteLine(numInt);
		Console.WriteLine(wasItSuccessfull);
		
		int intNumber = 31416;
		long longNumber = (long) intNumber; // cast the value
			
		Console.WriteLine(total);
		
		// LITERAL VALUES that are string have ""
		Console.WriteLine("Hello World"); // \n newline character
	}
}