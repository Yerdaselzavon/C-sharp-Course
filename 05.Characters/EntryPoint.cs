using System;
using System.Text;

class EntryPoint
{
    static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        //changes encoding for the console, only if special characters are required
        char theCharacterX = 'x';
        System.Console.WriteLine(theCharacterX);
        char unicodeCharacter = '\u02e6';
        System.Console.WriteLine(unicodeCharacter);
        //When writing in ascii or unicode, \u0000 , change the zeros with the ascii code where required
        char unicodeTest = '\u1760';
        Console.WriteLine(unicodeTest);

    }
}