using System;
class entryPoint
{
    static void Main()
    {
        string freespace = " ";
        float someFloatNumber = 3.14f;
        // Precision of 7 digits, must have F suffix
        System.Console.WriteLine(someFloatNumber.ToString("f"));
        // .toString("f") will write numbers larger than 7 digits rather than e+x, although will still be 000.. after 7 digits
        float Pi = 3.14f;
        float radius = 10f;
        //Use Float data type as number is not always whole
        float finalNum = Pi * radius * radius;
        Console.WriteLine("Area of a circle with a radius of 10=" + finalNum);

        float fMax = float.MaxValue;
        float fMin = float.MinValue;

        Console.WriteLine("max float value" + freespace + fMax.ToString("f"));
        Console.WriteLine("min float value" + freespace + fMin.ToString("f"));

        double doubleMax = double.MaxValue;
        double doublemin = double.MinValue;
        //precision to 14 digits suffix is D
        Console.WriteLine("max Double value" + freespace + doubleMax.ToString("f"));
        Console.WriteLine("min Double value" + freespace + doublemin.ToString("f"));

        decimal decMax = decimal.MaxValue;
        decimal decMin = decimal.MinValue;
        //Precision is 28-29 digits suffix is M
        Console.WriteLine("max Decimal value" + freespace + decMax.ToString("f"));
        Console.WriteLine("Min Decimal Value" + freespace + decMin.ToString("f"));
    }
}
