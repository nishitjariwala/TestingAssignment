﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace UnitTestAssignment2
{
    public static class ExtendMethod
    {

        //  Question: 9
        //  Method created for counting words
        public static int FunctionForCountingWord(this string inputString)
        {
            if (inputString.Length > 0)
            {
                string[] words = inputString.Split(' ');
                return words.Length;
            }
            return 0;
        }

        //  Question: 1 & 2
        //  Method for multiple case of string converter
        public static string FunctionForConvertCase(this string inputString)
        {
            if (inputString.Length > 0)
            {
                char[] cArray = inputString.ToCharArray();
                for (int i = 0; i < inputString.Length; i++)
                {
                    cArray[i] = char.IsUpper(cArray[i]) ? char.ToLower(cArray[i]) : char.ToUpper(cArray[i]);
                }
                return new string(cArray);
            }
            return inputString;
        }
       
        //  Question: 4
        //  Method to Check if all the characters from given input string are in lower case or not.
        public static bool CheckLowerCase(this string inputString)
        {
            int count = 0;
            int len = inputString.Length;
            if (inputString.Length > 0)
            {
                char[] charArray = inputString.ToCharArray();
                for (int i = 0; i < inputString.Length; i++)
                {
                    if (char.IsLower(charArray[i]) || char.IsWhiteSpace(charArray[i]))
                    {
                        count++;
                    }
                }
                if (count == len)
                    return true;
            }
            return false;
        }

        //  Question: 6
        //  Method to Check if all the characters from given input string are in upper case or not.
        public static bool CheckUpperCase(this string inputString)
        {
            int count = 0;
            int len = inputString.Length;
            if (inputString.Length > 0)
            {
                char[] charArray = inputString.ToCharArray();
                for (int i = 0; i < inputString.Length; i++)
                {
                    if (char.IsUpper(charArray[i]) || char.IsWhiteSpace(charArray[i]))
                    {
                        count++;
                    }
                }
                if (count == len)
                    return true;
            }
            return false;
        }

        // Question: 5
        //  Convert string into Capatalize
        public static string ConvertCapitalize(this string inputString)
        {
            if (inputString.Length > 0)
            {
                char[] charArray = inputString.ToCharArray();
                charArray[0] = char.ToUpper(charArray[0]);
                for (int i = 1; i < inputString.Length; i++)
                {
                    charArray[i] = char.ToLower(charArray[i]);
                }
                return new string(charArray);
            }
            return inputString;
        }

        // Question: 3
        //  Convert string into Title Case
        public static string ConvertTitleCase(this string inputString)
        {
            if (inputString.Length > 0)
            {
                string result = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(inputString.ToLower());
                return result;
            }
            return inputString;
        }

        //  Question 8
        //  function to remove the last character from given the string
        public static string RemoveLastCharacter(this string inputString)
        {
            if (inputString.Length > 0)
            {
                return inputString.Substring(0, inputString.Length - 1);
            }
            return inputString;
        }

        //  Question 7
        //  Function to identify whether given input string can be converted to a valid numeric value or not
        public static bool ValidationOfNumber(this string inputString)
        {
            if (inputString.Length > 0)
            {
                int number;
                return int.TryParse(inputString, out number);
            }
            return false;
        }

        //  Question 10
        //  Cnvert an input string to integer
        public static int? integerConverter(this string inputString)
        {
            int x = 0;
            if (inputString.Length > 0)
            {
                Int32.TryParse(inputString, out x);
            }
            return x;
        }
    }
}
