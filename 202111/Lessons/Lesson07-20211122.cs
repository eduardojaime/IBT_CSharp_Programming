using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
		
		// Chapter 9 - Value types (creating your own types)
		// Two main types: REFERENCE or VALUE
		// The difference being how they are stored in the Computer memory
		// REFERENCE types will store a reference to the actual value somewhere else in memory
		// e.g.: array, string (text), objects (instantiated from classes)
		// VALUE types will store the actual value in it
		// e.g.: int, decimal, char, float, etc... (numbers)
		
		int number1; // bucket created in memory, 4 bytes, empty (all zeros)
		Console.WriteLine($"int values go from {int.MinValue} to {int.MaxValue}");
		int number2 = 42; // bucket created in memory, 4 bytes, contains binary representation of number 42
		
		string text1; // bucket created in memory, 4 bytes (default), no reference value set so it's "null"
		string text2 = "some text here"; // bucket created in memory, 4 bytes (default), it contains a reference to somewhere else where "some text here" is stored 
		
		// why do you think reference types work this way?
		// is it the same to store the letter "A" than to store the contents of the "Canadian Charter of Rights and Freedoms"
		// how many bytes are used to store one letter? depends on the character set ASCII is 1 byte, UTF can be 2 or 4 bytes
		// SHORT ANSWER: it's impossible to predict the actual length of the string, as oppossed to VALUE types where each type can store only a specific range of values
		
		// Custom value types
		// Structs and Enums
		// Struct is very similar to a class
		// We are writing a system that handles coordinates for navigation
		// You could create an Angle struct to use it in the Coordinates class
		
		
		// Enums are constant values that are referred to by name and make your code easier to read
		int connectionState1;
		// ...
		switch (connectionState1)
		{
			case 0:
				// ...
				break;
			case 1:
				// ...
				break;
			case 2:
				// ...
				break;
			case 3:
				// ...
				break;
		}
		
		ConnectionState connectionState2;
		// ...
		switch (connectionState2)
		{
			case ConnectionState.Connected:
				// ...
				break;
			case ConnectionState.Connecting:
				// ...
				break;
			case ConnectionState.Disconnected:
				// ...
				break;
			case ConnectionState.Disconnecting:
				// ...
				break;
		}
	}
}

// Use keyword struct to declare a value type
// cannot use inheritance but can implement Interfaces
struct Angle                                                           
{
	// provide a constructor to initialize all values
  	public Angle(int degrees, int minutes, int seconds)
  	{
      	Degrees = degrees;
      	Minutes = minutes;
      	Seconds = seconds;
  	}

	// Using C# 6.0 read-only, automatically implemented properties
	public int Degrees { get; }
	public int Minutes { get; }
	public int Seconds { get; }

	public Angle Move(int degrees, int minutes, int seconds)
	{
		return new Angle(
			Degrees + degrees,
			Minutes + minutes,
			Seconds + seconds);
	}
}

// Declaring a class as a reference type
// (declaring it as a struct would create a value type
// larger than 16 bytes)
class Coordinate
{
	public Angle Longitude { get; set; } // 41 25 01N and 120 58 57W
  	public Angle Latitude { get; set; }
}

// Enum declaration
// Keyword enum + list of values
// all these values map to int values in order from top to bottom
enum ConnectionState
{
	Disconnected, // 0
	Connecting, // 1
	Connected, // 2
	Disconnecting // 3
}
// enum with custom numbering
enum ConnectionStateExpanded : short
{
  Disconnected, // 0
  Connecting = 10, // 10
  Connected, // 11
  Joined = Connected, // 11
  Disconnecting // 12
}