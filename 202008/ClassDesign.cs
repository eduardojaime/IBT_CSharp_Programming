using System;
					
public class Program
{
	public static void Main()
	{
		Student myNewStudent = new Student("Edward", "James"); //<-- this is the constructor METHOD
		Console.WriteLine("New Id : " + myNewStudent.StudentId.ToString());
		// IT NOW BREAKS BECAUSE MY PROPERTY METHOD ONLY IMPLEMENTS 'GET'
		// myNewStudent.StudentId = Guid.NewGuid();
		Console.WriteLine("New Id : " + myNewStudent.StudentId.ToString());
		myNewStudent.Name = "Eduardo";
		Console.WriteLine("New Student : " + myNewStudent.Name);
		
		// no-code constructor
	}
}
// MY CUSTOM CLASS
public class Student
{
	private Guid _studentId; // a 16 digit id number
	private string _name;
	private string _lastName;
	private DateTime _createdDate;
	// Empty constructor is default values
	public Student(){
		this._studentId = Guid.NewGuid();
		this._createdDate = DateTime.Now;
	}
	// custom constructor
	public Student(string Name, string LastName) : this()
	{
		this._name = Name;
		this._lastName = LastName;
	}
	
	public string Name 
	{
		get 
		{
			return _name;
		}
		set 
		{
			_name = value;
		}
	}
	
	public string LastName 
	{
		get 
		{
			return _lastName;
		}
		set 
		{
			_lastName = value;
		}
	}
	public Guid StudentId
	{
		get 
		{
			return _studentId;
		}
	}
}