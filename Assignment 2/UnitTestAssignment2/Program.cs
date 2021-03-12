using System;

namespace UnitTestAssignment2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string a = "nishit jariwala";
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Converted \"" + a + "\" into Uppercase : " + a.ConvertUpper());
            a = "NISHIT JARIWALA";
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Converted \"" + a + "\" into Lowercase : " + a.ConvertLower());
            a = "nishit jariwala";
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Converted \"" + a + "\" into Titlecase : " + a.ConvertTitleCase());
            a = "nishitjariwala";
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Checking if all the character of string are in lower case or not \"" + a + "\" : " + a.IsLower());
            a = "nishit jariwala";
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Converted \"" + a + "\" into Capitalize : " + a.ConvertCapitalize());
            a = "NISHITJARIWALA";
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Checking if all the character of string are in upper case or not \"" + a + "\" : " + a.IsUpper());
            a = "nishit jariwala";
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("No of word in \"" + a + "\" : " + a.WordCount());
            a = "Nishit Jariwala";
            Console.WriteLine("~~~~~~~~~");
            Console.WriteLine("After removing last char from string \"" + a + "\" : " + a.RemoveLastCharacter());
            string num = "17IT410";
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");
            if (num.ValidNumeric() == true)
                Console.WriteLine("\"" + num + "\" is not valid numeric value");
            else
                Console.WriteLine("\"" + num + "\" is not valid numeric value");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");
            if (num.StringToNumber() == null)
                Console.WriteLine("\"" + num + "\" can not convert in numeric value");
            else
                Console.WriteLine("\"" + num + "\" numeric value is : " + num.StringToNumber());
        }
    }
}
