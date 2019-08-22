class EntryPoint
{
    static void Main()
    {
        int bigNumber = 3456741;

        System.Console.WriteLine(bigNumber.ToString().Contains("5"));
        System.Console.WriteLine(bigNumber.ToString().IndexOf("5"));
        System.Console.WriteLine(bigNumber.ToString().LastIndexOf("5"));
        //can't use contains index of etc on Ints, needs to be converted to string first

        string iLearn = "I am learning ";
        string nameOfCourse = "C# programming course";

        string concantenated = iLearn + nameOfCourse;
        string concantenated2 = iLearn + nameOfCourse + bigNumber;

        System.Console.WriteLine(iLearn + nameOfCourse);
        System.Console.WriteLine(concantenated);
        System.Console.WriteLine(concantenated2);


    }
}