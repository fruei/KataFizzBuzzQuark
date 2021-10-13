using System;

namespace KataFizzBuzz
{
    public class FizzBuzz
    {
        public string NumToFizzBuzz(int number)
        {
            if (!DivisibleBy3OrContains3(number)&&!DivisibleBy5OrContains5(number)) return number.ToString();
            string result = "";
            if (DivisibleBy3OrContains3(number)) result += "Fizz";
            if (DivisibleBy5OrContains5(number)) result += "Buzz";
            return result;
        }

        bool DivisibleBy3OrContains3(int number)
        {
            return number % 3 == 0 || number.ToString().Contains('3') ? true : false;
        }
        bool DivisibleBy5OrContains5(int number)
        {
            return number % 5 == 0 || number.ToString().Contains('5') ? true : false;
        }

        public string[] NumListToFizzBuzzNumberList(int[] numbersList)
        {
            string[] result = new string[numbersList.Length];
            for (int i = 0; i < numbersList.Length; i++)
            {
                result[i] = NumToFizzBuzz(numbersList[i]);
            }
            return result;
        }
    }
}
