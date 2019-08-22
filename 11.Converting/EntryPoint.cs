using System;

class EntryPoint
{
    static void Main()
    {
        int number = 5;
        string word = "5";
        char x = 'x';
        float pi = 3.14f;

        float interger = number;
        int floating = (int)pi;

        System.Console.WriteLine(interger);
        System.Console.WriteLine(floating);
        //int to float works, but float to int doesn't work without the typecast of (int), also any decimal places are last info as
        //it rounds down. typecasting only works if they are compatible (can't convert string to int)

        int convertedString = Convert.ToInt32(word);
        Console.WriteLine(convertedString);
        //converts number in strings to intergers, can be added to as normal interger

        int parsedString = int.Parse(word);
        Console.WriteLine(parsedString);
        //if value is null convert class will return a zero, whereas parse will throw an exception



    }
}

