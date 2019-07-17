using System;

class EntryPoint
{
    static void Main()
    {
        string freeSpace = " ";
        string max = "Max Value";
        string min = "Min Value";
        int someInterger = 256;
        // intergers=2^32
        int intMax = int.MaxValue;
        int intMin = int.MinValue;
        // .value= methods of given data type

        System.Console.WriteLine("interger " + max + freeSpace + intMax);
        System.Console.WriteLine("interger " + min + freeSpace + intMin);

        uint someUInterger = 5;
        uint maxUInt = uint.MaxValue;
        uint minUInt = uint.MinValue;

        System.Console.WriteLine("Uinterger " + max + freeSpace + maxUInt);
        System.Console.WriteLine("Uinterger " + min + freeSpace + minUInt);
        // only positive numbers

        System.Console.WriteLine("Range of intergers" + freeSpace + Math.Pow(2 , 32));

        byte someByteNumber = 255;
        byte byteMinValue = byte.MinValue;
        byte byteMaxValue = byte.MaxValue;

        Console.WriteLine("Byte " + max + freeSpace + byteMaxValue);
        Console.WriteLine("Byte " + min + freeSpace + byteMinValue);

        sbyte sbyteMin = sbyte.MinValue;
        sbyte sbyteMax = sbyte.MaxValue;

        Console.WriteLine("SByte " + min + freeSpace + sbyteMin);
        Console.WriteLine("SByte " + max + freeSpace + sbyteMax);

        long minLong = long.MinValue;
        long maxLong = long.MaxValue;

        Console.WriteLine("Long " + min + freeSpace + minLong);
        Console.WriteLine("Long " + max + freeSpace + maxLong);

        ulong minULong = ulong.MinValue;
        ulong maxULong = ulong.MaxValue;

        Console.WriteLine("Ulong " + min + freeSpace + minULong);
        Console.WriteLine("Ulong " + max + freeSpace + maxULong);

    }
}