using System;

public class Program
{
    public static void Main()
    {

        Console.WriteLine("Hello World");

        int val; // value types are defaulted to 0
        string myText; // reference types are defaulted to null
        int? valNull; // I'm telling the compiler this is a null variable

        // nullable data types, allow you to assign null to the variable
        int? number = null;
        if (number is null)
        {
            System.Console.WriteLine("'number' requires a value and cannot be null");
        }
        else
        {
            System.Console.WriteLine($"'number' doubled is { number * 2 }.");
        }

        var myDateTime = new DateTime(2021, 11, 10);
        var myNumber = 10M; //??? M for ??? DECIMAL MONEY
                            // ANONYMOUS TYPE
        var personalInfo = new
        { // new means new object
            firstName = "Eduardo",
            lastName = "Jaime"
        };

        Console.WriteLine(personalInfo.lastName);

        // tuples
        (string country, string capital, double gdpPerCapita) = ("South Sudan", "Juba", 275.18D);
        Console.WriteLine($"{country}'s capital city is {capital} and it has a GDP of {gdpPerCapita}");

        // Arrays > collection of data, 0-based, one-dimensional and two-dimensional
        string[] languages;

        languages = new string[5];
        languages[0] = "C#";
        languages[1] = "Python";
        languages[2] = " VB.NET";
        languages[3] = "C++";
        languages[4] = "JavaScript";

        int[] grades = { 15, 15, 50, 5 };
        foreach (int grade in grades)
            Console.Write(grade + " ");
        Console.WriteLine();

        int[,] cells = new int[3, 3]
        {
            {1, 0, 2},
            {1, 2, 0},
            {1, 2, 1}
        };
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(cells[i, j] + "\t");
            }
            Console.Write("\n");
        }

        bool[,,] cells1;
        cells1 = new bool[2, 3, 3]
          {
			 // Player 1 moves                //  X |   |
			 {   {true, false, false},        // ---+---+---
				 {true, false, false},        //  X |   |
				 {true, false, true} },       // ---+---+---
											  //  X |   | X

			 // Player 2 moves                //    |   | O
			 {   {false, false, true},        // ---+---+---
				 {false, true, false},        //    | O |
				 {false, true, false} }        // ---+---+---
											  //    | O |
		  };
        // represent a graph or a tree
        int[][] cells3 = {
            new int[]{1, 0, 2, 0},
            new int[]{1, 2, 0},
            new int[]{1, 2},
            new int[]{1}
        };

        string[] languages2 = new string[]{
          "C#", "COBOL", "Java",
          "C++", "TypeScript", "Visual Basic",
          "Python", "Lisp", "JavaScript"};
        System.Array.Sort(languages2);

        string searchString = "COBOL";
        int index = System.Array.BinarySearch(languages2, searchString);
        System.Console.WriteLine($"The wave of the future, { searchString }, is at index { index }.");
        System.Console.WriteLine();

        System.Array.Reverse(languages2);
        System.Console.WriteLine($"{ languages2[0],-20 }\t{ languages2[^1],-20 }");
        // Note this does not remove all items from the array.
        // Rather, it sets each item to the type's default value.
        System.Array.Clear(languages2, 0, languages2.Length);
        System.Console.WriteLine($"After clearing, the array size is: { languages2.Length }");


        string myText1 = "Hello this is some text";
        myText1 = myText1.Replace(" ", string.Empty);
        for (int i = 0; i < myText1.Length; i++)
        {
            Console.Write(myText1[i] + "\t");
        }
    }
}