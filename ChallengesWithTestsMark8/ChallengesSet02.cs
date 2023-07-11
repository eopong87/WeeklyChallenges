using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        private int number;

        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);


        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            double max = double.MinValue;
            double min = double.MaxValue;
            foreach (double number in numbers)
            {

                if (number > max)
                {
                    max = number;
                }
                if (number < min)
                {
                    min = number;
                }
            }
            return max + min;
        }


        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {



            if (numbers == null)
            {
                return 0;
            }
            int sum = 0;

            foreach (var num in numbers)
            {
                sum += num;
            }
            return sum;
        }
        public int SumEvens(int[] numbers)
        {



            int sum = 0;

            if (numbers == null)
            {
                return 0;
            }
            int answer = 0;
            foreach (int n in numbers)
            {
                if (n % 2 == 0)
                {
                    answer += n;
                }
            }
            return answer;
        }

        public bool IsSumOdd(List<int> numbers)
        {


            if (numbers == null)
            {
                return false;
            }
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            if (sum % 2 != 0)
            {
                return true;
            }
            else
                return false;
        }
        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return number < 0 ? 0 : number / 2;
        }
    }



    
}





