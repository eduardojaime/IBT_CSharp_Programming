using System;
using System.Linq;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
		// Chapter 16 LINQ (with query expressions)
		string[] keywords = new string[] // collection or array
		{
			"abstract", "add*", "alias*", "as", "ascending*",
			"async*", "await*", "base","bool", "break",
			"by*", "byte", "case", "catch", "char", "checked",
			"class", "const", "continue", "decimal", "default",
			"delegate", "descending*", "do", "double",
			"dynamic*", "else", "enum", "event", "equals*",
			"explicit", "extern", "false", "finally", "fixed",
			"from*", "float", "for", "foreach", "get*", "global*",
			"group*", "goto", "if", "implicit", "in", "int",
			"into*", "interface", "internal", "is", "lock", "long",
			"join*", "let*", "nameof*", "namespace", "new", "nonnull*",
			"null", "object", "on*", "operator", "orderby*", "out",
			"override", "params", "partial*", "private", "protected",
			"public", "readonly", "ref", "remove*", "return", "sbyte",
			"sealed", "select*", "set*", "short", "sizeof",
			"stackalloc", "static", "string", "struct", "switch",
			"this", "throw", "true", "try", "typeof", "uint", "ulong",
			"unsafe", "ushort", "using", "value*", "var*", "virtual",
			"unchecked", "void", "volatile", "where*", "while", "yield*"
		};
		
		// LINQ Standard Query Operators
		// select all elements which contain an "*"
		var filteredKeywords1 = keywords.Where(k => k.Contains("*")).ToList();
		foreach(string word in filteredKeywords1)
			Console.Write(word + "\t");
		Console.WriteLine();
		
		// Opinion: is it easy to read??
		// from the method names you could guess or know what they are suppossed to do
		// lambda expression is not very 'readable' k => k.Contains("*") is read as "select k such as k contains asterisk"
		
		// Query Expressions (looks like SQL)
		// What's the basic SQL statement? (selection of data) SELECT * FROM table_name (collection) 
		// basic LINQ query expression statement >>> from COLLECTION where CONDITIONS select SOMETHING (properties of an object or whole object)
		// projection == result
		var filteredKeywords2 = from word in keywords
								where word.Contains("*")
								orderby word descending
								select word;
								// group word by word.Contains("*");
		foreach(string word in filteredKeywords2)
			Console.Write(word + "\t");
		Console.WriteLine();
		
		
		// deferred execution?? 
		
		
	}
}