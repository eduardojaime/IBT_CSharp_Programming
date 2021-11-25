using System;
using System.Collections; // for non-generic classes
using System.Collections.Generic; // import the generic classes
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
		
		// Chapter 12 Generics
		// What's 'generic'? General? 
		// It is a class, that can handle (only) one type of element, but it's 'generic' in the sense that you can indicate which this type
		// Dictionary<TKey, TValue> angle brackets allow you specify data type for key and value
		Dictionary<int, string> myList = new Dictionary<int, string>();
		// myList.Add(10M, "some value"); // example of generic class enforcing type
		
		// non-generic queue
		Queue myQueue = new Queue(); // as in the supermarket, adds to the end of the queue, and reads/extracts from the beginning FIFO
		myQueue.Enqueue(true); //boolean
		myQueue.Enqueue(1); // int
		myQueue.Enqueue("10"); // string
		myQueue.Enqueue(DateTime.Now); // Today's date
		
		while(myQueue.Count > 0)
		{
			// object data-type is the parent of all data-types
			Object item = myQueue.Dequeue(); // extracts next element at the start of the queue
			// if I'm expecting an integer
			// breaks >> int result = 100 * (int)item; // you have to cast it
			
			Console.WriteLine($"Item value is {item} and type is {item.GetType()}");
		}
		// is this safe? >> not very safe, it will likely break at some point when somebody enters junk data in the queue that we don't know how to handle
		
		Console.WriteLine();
		
		// C# encourages type safety > explicitly define datatypes to be expected
		// generic and type-safe version of queue
		Queue<int> myQueue2 = new Queue<int>();
		myQueue2.Enqueue(1);
		myQueue2.Enqueue(int.Parse("10"));
		
		while (myQueue2.Count > 0)
		{
			var item = myQueue2.Dequeue();
			int result = 100 * item;
			Console.WriteLine($"Item value is {item} and type is {item.GetType()}");			
		}
		// benefits
		// you know what data type to expect
		// boxing and unboxing are avoided (performance improvement)
		// 	boxing is converting a type (int) into an object
		// 	unboxing is converting an object into a type (int)
		// facilitate type safety (by specifying the data type to use)
		
		// Recommendation: use the out-of-the-box generic classes included in System.Collections.Generic
		List<int> months = new List<int>();
		for (int i = 1; i <= 12; i++)
		{
			months.Add(i);
		}
		
		List<string> students = new List<string>();
		students.Add("Mezli");
		students.Add("Roman");
		
		Console.WriteLine();
		
		// Angle brackets < >
		Pair<int> myTwoNumbers = new Pair<int>(10, 100);
		Console.WriteLine($"Left value {myTwoNumbers.left} & Right value {myTwoNumbers.right}");
		
	}
}

// How do we use them in our own classes?
// classes, interfaces and structs can be written to handl specific generics
// a class that represents a pair of something: numbers, strings, dates
class Shoe
{
	int size;
	public Shoe(int size)
	{
		this.size = size;
	}
}
// custom non-generic class and handles only Shoes
class Pair
{
	public Shoe left;
	public Shoe right;
	
	public Pair(Shoe left, Shoe right)
	{
		this.left = left;
		this.right = right;
	}
}
// custom generic class that can be reused in different systems: glasses, shoes, numbers
class Pair<T> // whatever data type is specified when creating the class will become T
{
	public T left;
	public T right;
	
	public Pair(T left, T right)
	{
		this.left = left;
		this.right = right;
	}
}


