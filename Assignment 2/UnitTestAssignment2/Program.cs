using System;

namespace UnitTestAssignment2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //  Convert case of String
            string testString = "Nishit Jariwala ASHokKUmAR";
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Converted \"" + testString + "\" into Lowercase : " + testString.FunctionForConvertCase());
            //  Convert string in title case
            testString = "nishit jariwala";
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Converted \"" + testString + "\" into Titlecase : " + testString.ConvertTitleCase());
            // Check if string is in lower case
            testString = "nishitjariwala";
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Checking if all the character of string are in lower case or not \"" + testString + "\" : " + testString.CheckLowerCase());
            //  Convert string in capatalize
            testString = "nishit jariwala";
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Converted \"" + testString + "\" into Capitalize : " + testString.ConvertCapitalize());
            // Check if string is in lower case
            testString = "NISHITJARIWALA";
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Checking if all the character of string are in upper case or not \"" + testString + "\" : " + testString.CheckUpperCase());
            //  Count words of String
            testString = "nishit jariwala";
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("No of word in \"" + testString + "\" : " + testString.FunctionForCountingWord());
            //  Remove last character of String
            testString = "Nishit Jariwala";
            Console.WriteLine("~~~~~~~~~");
            Console.WriteLine("After removing last char from string \"" + testString + "\" : " + testString.RemoveLastCharacter());
            //  Check if string is numeric or not
            string num = "17IT410";
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");
            if (num.ValidationOfNumber() == true)
                Console.WriteLine("\"" + num + "\" is not valid numeric value");
            else
                Console.WriteLine("\"" + num + "\" is not valid numeric value");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");
            if (num.integerConverter() == null)
                Console.WriteLine("\"" + num + "\" can not convert in numeric value");
            else
                Console.WriteLine("\"" + num + "\" numeric value is : " + num.integerConverter());
        }
    }
}
