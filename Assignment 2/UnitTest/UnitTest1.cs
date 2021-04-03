using System;
using UnitTestAssignment2;
using Xunit;

namespace UnitTest
{
    public class UnitTest1
    {
        // Function for convert case of string
        [Fact]
        public void MultipleConvertCase()
        {
            string testString = "Nishit jariwala ASHoKkUMaR";
            string result = testString.FunctionForConvertCase();
        }


        //  Question 3
        //  convert string into title case
        [Fact]
        public void TitleCaseConverter()
        {
            string testString = "nishit jariwala";
            string result = testString.ConvertTitleCase();
            
        }

        //  Question 4
        //  Check if case is lower or not

        [Fact]
        public void CheckLower()
        {
            string a = "nishit jariwala";
            bool result = a.CheckLowerCase();
            Assert.True(result);
        }

        //  Question 6
        //  Check if case is upper or not
        [Fact]
        public void CheckUpper()
        {
            string a = "NISHIT JARIWALA";
            bool result = a.CheckUpperCase();
            Assert.True(result);
        }


        


        //  Question 5
        //  Convert String into capatalize 
        [Fact]
        public void ConvertCapitalizeCase()
        {
            string testString = "nishit jAriwala";
            string result = testString.ConvertCapitalize();
        }
        

        //  Question 9
        //  Test case: Success in counting Words
        [Fact]
        public void SuccessInCountingWords()
        {
            string testString = "Nishit Jariwala";
            int result = testString.FunctionForCountingWord();
        }

        //  Question 8
        //  function to remove the last character from given the string
        [Fact]
        public void RemoveLastCharacter()
        {
            string testString = "Nishit";
            string result = testString.RemoveLastCharacter();
        }


        //  Question 7
        //  Function to identify whether given input string can be converted to a valid numeric value or not
        [Fact]
        public void ValidateNumber()
        {
            string a = "333";
            bool result = a.ValidationOfNumber();
        }

        //  Question 10
        //  Cnvert an input string to integer
        [Fact]
        public void StringToNumber()
        {
            string a = "454";
            int? result = a.integerConverter();
            Assert.Equal(454, result);
        }
        
    }
}
