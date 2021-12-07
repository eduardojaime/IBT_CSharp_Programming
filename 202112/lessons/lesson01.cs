using System;
// generic collections
using System.Collections.Generic; // List<string>
using System.Linq;
					
public class Program
{
	public static void Main()
	{
		// Chapter 15
		Console.WriteLine("Hello World");
		
		// query Collections
		List<string> students = new List<string>();
		students.Add("Mezli");
		students.Add("Roman");
		students.Add("Sahid");
		students.Add("Sherlon");
		students.Add("Rustam");
		students.Add("Adrian");
		students.Add("David");
		
		// LINQ > Language Integrated Query allows you to perform operations on collections and arrays
		// We want to get a list of students whose name start with the letter R
		// indexOf() to check the first letter or maybe StartsWith()
		// iterate using a... for loop
		string name = "Eduardo";
		Console.WriteLine(name.StartsWith("E"));
		// Manual approach
		List<string> filteredStudents = new List<string>();
		foreach(var student in students) 
		{
			if (student.StartsWith("R"))
			{
				filteredStudents.Add(student);
			}
		}
		
		// LINQ approach
		// Allows you to specify a Where predicate
		// s stands for 'an element in the collection', it's an alias
		// => is a lambda expression, you can read it as 'such as' or 'becomes', it denotes the condition to fulfill for an item to be selected
		// s.StartsWith("R") is a condition that returns True or False, if T then the item is added to the resultset
		List<string> filteredListLINQ = students.Where(s => s.StartsWith("R")).ToList();
		Console.Write("Result set: ");
		foreach(var s in filteredListLINQ)
			Console.Write(s + " ");
		Console.WriteLine();
		
		// LINQ applies to collections (generic and non-generic) and also to Arrays
		List<int> grades = new List<int>() { 10, 10, 30, 30, 50, 60 }; // Collection initializer
		Dictionary<string, ConsoleColor> colorMap = new Dictionary<string, ConsoleColor>
		{
			{ "Error", ConsoleColor.Red },
          	{ "Warning", ConsoleColor.Yellow },
          	{ "Information", ConsoleColor.Green },
          	{ "Verbose", ConsoleColor.White}
		}; // initialize a collection by specifying the initial elements in {}
		
		// Standard Query Operators
		// Iterate using foreach
		foreach(int grade in grades)
		{
			// some processing
		}
		// filtering with where
		List<string> filteredListLINQ2 = students.Where(s => s.StartsWith("R")).ToList();
		// filtering with where and select > e.g. get the color that belongs to a warning message
		var warningColor = colorMap.Where(e => e.Key == "Warning").Select(e => e.Value).First(); // select and where return a list, choose only first element
		Console.WriteLine(warningColor);
		// count elements
		int numberOfStudents = filteredListLINQ2.Count();
		Console.WriteLine("There are " + numberOfStudents);
		// check if there are any elements in the list
		bool areThereElements = filteredListLINQ2.Any(); // returns True if there are elements in the list or False if it's empty
		if (areThereElements)
			Console.WriteLine("Yes, we got some results!");
		else
			Console.WriteLine("No results, list is empty");
		
		// Sort elements
		foreach(string student in students)
			Console.Write(student + "\t");
		Console.WriteLine();
		
		// List<string> sortedStudents = students.OrderBy(s => s).ToList(); // I'm using ToList() because all these methods return IEnumerable collections
		List<string> sortedStudents = students.OrderByDescending(s => s).ToList(); // I'm using ToList() because all these methods return IEnumerable collections
		foreach(string student in sortedStudents)
			Console.Write(student + "\t");
		Console.WriteLine();
		
		// Join, Union, Distinct 
		// How many distinct grades do we have?
		List<int> distinctGrades = grades.Distinct().ToList();
		foreach (int grade in distinctGrades)
			Console.Write(grade + "\t");
		Console.WriteLine();
		// Average of grades
		double gradeAvg = grades.Average();
		Console.WriteLine("Avg: " + gradeAvg.ToString());
		
		// Max value in grades
		int maxValue = grades.Max();
		Console.WriteLine("Max: " + maxValue.ToString());
		
		// Min value in grades
		int minValue = grades.Min();
		Console.WriteLine("Max: " + minValue.ToString());
		
		// Sum all elements in grades
		int sumGrades = grades.Sum();
		Console.WriteLine("Sum: " + sumGrades.ToString());
	}
}