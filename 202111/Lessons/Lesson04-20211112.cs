using System;
using System.Collections.Generic;

namespace IBTLessons 
{
	public class Program
	{
		public static void Main()
		{
			List<int> myList = new List<int>{1 ,2 ,3 ,4};
			// local scope
			string firstName, lastName;

			// namespace.object.method
			System.Console.WriteLine("Hello World");
			Console.WriteLine("Hey you!");

			Console.Write("Enter your first name: ");

			firstName = Console.ReadLine();
			Console.Write("Enter your last name: ");
			lastName = Console.ReadLine();
			Console.WriteLine($"Your full name is { firstName } { lastName }.");
			
			MyHelperMethods myHelpers = new MyHelperMethods();
			myHelpers.SendEmails("address@email.com", 10M);
		}
	}
	
	public class MyHelperMethods 
	{
		// method syntax
		// access modifier > return type > name > parenthesis > list of parameters
		// parameter and argument
		public bool SendEmails(string emailAddress, int orderNumber)
		{
			Console.WriteLine(emailAddress);
			// creating email object
			// creating smtp object
			// filling in subject
			// filling in to addresses
			// filling in from address
			// filling in body
			// sending
			return true;
		}
		// methods with same name but different signature are allowed
		public bool SendEmails(string emailAddress, decimal myOtherNumber, bool retry = false)
		{
			try 
			{
				// here code that needs to be executed
				// creating email object
				// creating smtp object
				// filling in subject
				// filling in to addresses
				// filling in from address
				// filling in body
				// sending
			}
			catch(FormatException ex1) 
			{
				// do something related to a specific exception
			}
			catch(Exception ex2)
			{
				// do something related to a generic exception
			}
			finally 
			{
				// optional - always executes and it's usually for cleaning up
			}
			return true;
		}
		
	}
}