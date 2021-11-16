using System;
using System.Data.SqlClient;
					
// Everything in C# is an object
// C# is an object-oriented programming language
// what's an object??? an instance of a class (exists in memory) (cookie, building)
// what's a class??? template/blueprint to create instances of that type (exists in code) (cookie cutter, construction blueprint)
// container of methods (behavior) and attributes (properties), reusable, to create an instance, allows you to reuse it and create instances of it 
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
		
		// Use classes as if they are built into the framework
		// Cookie Cutters analogy
		Circle circle; // grab a cookie cutter and hold it
		circle = new Circle(); // instantiating/initializing the object > memory space is allocated to fit a Circle object
		Triangle triangle = new Triangle(); // how does the computer know how big the object is? 16 MB? 16 kb?
		// an object is as big as the summatory of all the attributes it contains (more or less)
		
		// Polymorphism: same method name inherited from base class, but implemented differently in the derived class
		circle.Draw();
		triangle.Draw();
		
		Staff teacher = new Staff();
		try
		{
			teacher.Age = 1;
		}
		catch(Exception ex)
		{
			// handle exception
			Console.WriteLine($"Exception handled: {ex.Message}");
		}
		teacher.FirstName = "Eduardo";
		teacher.LastName = "Jaime";
		
		Console.WriteLine($"Teacher's name is {teacher.FirstName} {teacher.LastName}");
		string fullName = teacher.GetName();
		Console.WriteLine($"Teacher's formatted name is {fullName}");
		
		Console.WriteLine($"Teacher is {teacher.Age} years young!"); // displays unmodified default value of _Age which is 18 (constructor)
		teacher.Age = 25; // property method can be used as a property of the class
		Console.WriteLine($"Teacher is {teacher.Age} years young!");
		
		
		Staff director = new Staff("Filiberto", "Romero"); // constructor with parameters
		Console.WriteLine($"Director's formatted name is {director.FullName}"); 
		
	}
}
// Person.cs
public class Person // Person is a base class
{
	// encapsulation: deciding what to show, and what to hide
	// member variable = instance field = field = attribute = property = class variable
	public string FirstName; // 2 bytes
	public string LastName; //  2 bytes
	private string _SIN; //		2 bytes => 6 bytes
	private int _Age = 18; // 	default values

	// Property method
	public void SetSIN(string newSINValue)
	{
		// add some form of validation
		// add security checks
		this._SIN = newSINValue;
	}
	
	// Property method using getters and setters
	// Helps you hide private properties behind these methods (encapsulation)
	public int Age 
	{ 
		get 
		{	
			return _Age;
		}
		set
		{ 
			// can add validation here. e.g. check that age is not > 18
			if (value < 18)
			{
				throw new ArgumentException("Staff age cannot be less than 18!", nameof(value));
			}
			else 
			{
				_Age = value; // value is implicit, coming from outside
			}
		}
	}
	
	// Alternative to return full name as a property method (calculated field)
	public string FullName
	{
		get
		{
			return $"{FirstName} {LastName}, MScSwE"; // alternativelly this.FirstName
		}
	}
	
	public string GetName()
	{
		return $"{FirstName} {LastName}, MScSwE"; // alternativelly this.FirstName
	}
}
// Inheritance: a "is a kind of" relationship between classes
// Staff is a kind of person
// Staff.cs
public class Staff : Person // Staff is a derived class
{
	string staffId;
	
	// constructor methods allows you to set default values
	public Staff()
	{
		// class created
		// default state of a class
		this.Age = 18;
		this.SetSIN("111-11-111");
	}
	
	public Staff(string FirstName, string LastName)
	{
		this.FirstName = FirstName;
		this.LastName = LastName;
	}
	
	public bool GetPaid(decimal salary)
	{
		return true;
	}
}
// Student is a kind of person
// Student.cs
public class Student : Person // Student is a derived class
{
	string studentNumber;
	float[] grades;
	
	public bool RegisterForClass(int classId) 
	{
		return true;
	}
}

// Polymorphism: poly = many, morphos = forms/shapes, many shapes
// when applied to methods it means that the same method name, performs a different operation/process according to the class
public class Shape // think about circles rectangles triangles
{
	// behaviour of a shape, it can be drawn
	public virtual void Draw() {}
}
// both classes inherit the Draw method, however it's not the same to draw a circle than to draw a triangle
public class Circle : Shape
{
	public override void Draw() 
	{
		Console.WriteLine(@"        
							. -- ~~~ -- .
						.-~               ~-.
					   /                     \
					  /                       \
					 |                         |
					 |                         |
					 |                         |
					  \                       /
					   \                     /
						`-.               .-'
							~- . ___ . -~
		"); // recreating a circle with ASCII art
	}
}
public class Triangle : Shape
{
	public override void Draw() 
	{
		Console.WriteLine(@"
		 _        _                   _      
		| |      (_)                 | |     
		| |_ _ __ _  __ _ _ __   __ _| | ___ 
		| __| '__| |/ _` | '_ \ / _` | |/ _ \
		| |_| |  | | (_| | | | | (_| | |  __/
		 \__|_|  |_|\__,_|_| |_|\__, |_|\___|
								 __/ |       
								|___/   		
		");
	}
}





