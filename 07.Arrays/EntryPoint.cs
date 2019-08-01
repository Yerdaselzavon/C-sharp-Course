using System;

class entryPoint
{
    static void Main()
    {
        int[] numbers = { 5, 6, 6, 8, 6, 4, 2 };

        Console.WriteLine(numbers[3]);

        int[] numbers2 = new int[6];
        numbers2[1] = 20;
        Console.WriteLine(numbers2[1]);
        numbers2[1] = 78;
        Console.WriteLine(numbers2[1]);

        //indexs in arrays can be changed during the process, bounds of the array cannot be changed
        //String array challenge below using both methods

        string[] fruit1 = { "apple" , "orange", "peach", "plum", "pear"};
        Console.WriteLine(fruit1[1]);

        string[] fruit2 = new string[5];
        fruit2[0] = "Apple";
        fruit2[1] = "orange";
        fruit2[2] = "peach";
        fruit2[3] = "plum";
        fruit2[4] = "pear";

        Console.WriteLine(fruit2[2]);

        fruit2[2] = "jack fruit";

        Console.WriteLine(fruit2[2]);
        Console.WriteLine(fruit2[2][0]);
        //Can use 2 indexers to dig dipper into chosen element
        //Strings are still immutable, but you can change the string itself for each string
    }
}

