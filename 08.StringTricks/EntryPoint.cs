using System;

class EntryPoint
{
    static void Main()
    {
        string seperator = new string('-' , 40);
        string fruitJuice = "Strawberry Juice";

        Console.WriteLine(seperator);
        Console.WriteLine(fruitJuice.Contains("f"));
        Console.WriteLine(seperator);
        //Returns a boolean result, case sensitive
        Console.WriteLine(fruitJuice.IndexOf("r"));
        Console.WriteLine(seperator);
        //returns the first index in which the string appears, -1 if the character does not exist
        Console.WriteLine(fruitJuice.LastIndexOf("r"));
        Console.WriteLine(seperator);
        //Same as above with last index

        Console.WriteLine(fruitJuice.ToLower().Contains("straw"));
        Console.WriteLine(seperator);
        Console.WriteLine(fruitJuice.ToUpper().Contains("straw"));
        Console.WriteLine(seperator);
        //As with chaining indexes, you can chain methods. Above works but below is cleaner

        bool containStraw = fruitJuice.ToLower().Contains("straw");

        Console.WriteLine(containStraw);
        Console.WriteLine(seperator);
        fruitJuice = fruitJuice.ToLower();
        Console.WriteLine(fruitJuice);
        Console.WriteLine(seperator);
        fruitJuice = fruitJuice.ToUpper();
        Console.WriteLine(fruitJuice);
        Console.WriteLine(seperator);


    }
}
