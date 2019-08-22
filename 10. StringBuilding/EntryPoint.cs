class EntryPoint
{
    static void Main()
    {
        string nameOfCharacter = "Link ";
        int damageTaken = 100;
        string spellName = "Fireball";

        string damageReport = "The " + nameOfCharacter + "character took " + damageTaken + " damage from " + spellName;

        System.Console.WriteLine(damageReport);
        // works but over complicated

        string damageReportV2 = string.Format("The {0}character took {1} damage from {2} ", nameOfCharacter, damageTaken, spellName);
        System.Console.WriteLine(damageReportV2);
        //Curly Bois are used as the strings now act like an array, and they are getting the index number from it
        string damageReportV21 = string.Format("The {0}character took {1} damage from {2} , and the character {0}is now dead", nameOfCharacter, damageTaken, spellName);
        System.Console.WriteLine(damageReportV21);
        //You can retarget indexs at any point
        string damageReportV3 = $"The {nameOfCharacter}character took {damageTaken} damage from {spellName} ";
        System.Console.WriteLine(damageReportV3);
        //interpolation is much easier to read and write
    }
}