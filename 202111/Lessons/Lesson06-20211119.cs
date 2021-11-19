using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
		Contact myNewContact = new Contact();
		myNewContact.Name = "Eduardo";
		myNewContact.Address = "1 Main St";
		
		Customer myNewCustomer = new Customer();
		myNewCustomer.ShipToAddress = "123 Main Rd Toronto ON";
		myNewCustomer.Name = "John Smith";
		// private attributes are not inherited
		// myNewCustomer.SIN = "" ;
		// protected attributes cannot be accessed from outside of the class
		//myNewCustomer.SecretCode = "123";
		
		// Conversion between these classes Child to Parent
		// Implicit conversion
		Contact newContact1 = myNewCustomer;
		// Explicit conversion
		Contact newContact2 = (Contact)myNewCustomer;
		
		// The reverse is not posible Parent to Child
		// Customer newCustomer1 = newContact1;
		// Customer newCustomer2 = (Contact)newContact1;
		
		// Abstract classes cannot be instantiated
		// Error
		// Person myNewPerson = new Person();
		
		// Interfaces cannot be instantiated EVER
		// IListable myListableObject = new IListable();
	}
}

// Inheritance is a "is a" relationship between two classes
// Example: Staff derives/inherits from Person == Staff is a Person
// Person is the Base/Super/Parent class
// Staff is the Derived/sub/Child class


// PERSON class might have generic properties/methods that represent a person in general
// STAFF class will have specific properties/methods that represent a person who is a Staff
// Start by defining the base class

// In C# classes cannot inherit from more than one parent
public class AnotherClass
{}

// All these classes are what's called "concrete class"
public class PdaItem
{
  public string Name { get; set; }

  public DateTime LastUpdated { get; set; }
}

// Define the Contact class as inheriting the PdaItem class
public class Contact : PdaItem   // colon (:) parent class                                         
{
  	public string Address { get; set; }
   	public string Phone { get; set; }
	// private access modifier
	// these are not inherited and cannot be accessed outside of this class
	private string SIN { get; set; }
	// protected access modifier
	// these are inherited but annot be accessed outside of parent or child classes
	protected string SecretCode { get; set; }
	
	// overriding methods
	public virtual void PrintName() 
	{
		Console.WriteLine($"{Name} {Address} {Phone}");
	}
	
}
// there's no limit to how many levels you can specify
public class Customer : Contact
{
	public string ShipToAddress { get;set; }
	public void PrintNameAndCode() {
		Console.WriteLine(this.SecretCode); // protected attribute is inherited but can only be used internally
	}
	
	public override void PrintName() 
	{
		Console.WriteLine($"{Name} {ShipToAddress}");
	}
}

// sealed classes
// use these when you want to make sure the class cannot be inherited
public sealed class CommandLineParser
{
  // ...
}
// ERROR:  Sealed classes cannot be derived from
public sealed class DerivedCommandLineParser // : CommandLineParser
{
  // ...
}

class A
{
  public virtual void Method()
  {
  }
}
class B : A
{
  public override sealed void Method()
  {
  }
}

class C : B
{
  // ERROR:  Cannot override sealed members
  // public override void Method() {}
}

// Abstract class
// these classes cannot be instantiated
public abstract class Person
{
	public string FullName { get; set; }
	
	public abstract void PrintPersonalInformation();
}

public class Student : Person, IListable
{
	public string CellValues {get;}
	
	public void DisplayInList() 
	{
		Console.WriteLine("Print in list");
	}

	public override void PrintPersonalInformation() 
	{
		Console.WriteLine("Printing name in Student Format");
	}
}

// virtual methods CAN be overriden if the derived classes chooses to do so
// abstract methods MUST be overriden and implemented all the time

// Interfaces (alternative to abstract classes)
// A class can implement many interfaces, an interface is some sort of contract, and it's a more loose relationship
// This is a "can do" type of relationship, not quite an "is a"
public interface IListable
{
	string CellValues {get;}
	
	void DisplayInList();
}

