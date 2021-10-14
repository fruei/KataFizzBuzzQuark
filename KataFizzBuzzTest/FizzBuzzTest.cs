using KataFizzBuzz;
using System;
using Xunit;

namespace KataFizzBuzzTest
{
    public class FizzBuzzTest
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(3, "Fizz")]
        [InlineData(4, "4")]
        [InlineData(5, "Buzz")]
        [InlineData(6, "Fizz")]
        [InlineData(13, "Fizz")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(55, "Buzz")]
        [InlineData(45, "FizzBuzz")]
        [InlineData(67, "67")]
        public void NumToFizzBuzz_Number_FizzBuzzComposedStringOrNumberString(int number, string expected)
        {
            /// Arrange
            FizzBuzz _fizzBuzz = new FizzBuzz();
            /// Act
            string result = _fizzBuzz.NumToFizzBuzz(number);
            /// Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] { 1,2,3 }, new string[] { "1", "2", "Fizz" })]
        [InlineData(new int[] { 4, 5, 6, 7, 8, 9, 10 },
            new string[] { "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz" })]
        [InlineData(
            new int[] { 11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32 },
            new string[] { "11", "Fizz", "Fizz", "14", "FizzBuzz", "16", "17",
                "Fizz", "19", "Buzz", "Fizz", "22", "Fizz", "Fizz", "Buzz",
                "26", "Fizz", "28","29", "FizzBuzz", "Fizz", "Fizz" })]
        public void NumListToFizzBuzzNumberList_NumbersList_FizzBuzzComposedStringOrNumberStringPopulatedList(int[] numbersList, string[] expected)
        {
            /// Arrange
            FizzBuzz _fizzBuzz = new FizzBuzz();
            /// Act
            string[] result = _fizzBuzz.NumListToFizzBuzzNumberList(numbersList);
            /// Assert
            Assert.Equal(expected, result);
        }
    }
}
