using System;

namespace KataFizzBuzz
{
    public class FizzBuzz
    {
        public string NumToFizzBuzz(int number)
        {
            if (!DivisibleByOrContainsDivider(number,3)&&!DivisibleByOrContainsDivider(number,5)) return number.ToString();
            string result = "";
            if (DivisibleByOrContainsDivider(number,3)) result += "Fizz";
            if (DivisibleByOrContainsDivider(number,5)) result += "Buzz";
            return result;
        }

        bool DivisibleByOrContainsDivider(int number, int divider)
        {
            return number % divider == 0 || number.ToString().Contains(divider.ToString()) ? true : false;
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
