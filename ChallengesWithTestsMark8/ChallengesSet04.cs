using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            {


                int Total = 0;

                foreach (int num in numbers)
                {
                    if (num % 2 == 0)
                        Total += num;
                    else
                        Total -= num;
                }

                return Total;
            }
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<string> stringLlist = new List<string>() { str1, str2, str3, str4 };
            return stringLlist.Min(x => x.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] array = new int[] { number1, number2, number3, number4 };
            return array.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3 &&
           sideLength3 + sideLength1 > sideLength3 &&
           sideLength2 + sideLength3 > sideLength1)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public bool IsStringANumber(string input)
        {

            double n;
            bool isNumber = double.TryParse(input, out n);

            return isNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            return objs.Where(x => x == null).Count() > (objs.Count() / 2);
        }
        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            { return 0; }var n = numbers.Where(x => x % 2 == 0);
            {
                return 0;
            }
            return n.Average();
        }
        public int Factorial(int number)
        {
            var fact = 1;
            if( number < 0)
            {
                throw new ArgumentException();
            }
            if (number == 1 || number == 0)
            {
                return 1;
            }
            if (number >=2)
            {
                var factorial = number * Factorial(number - 1);
                return factorial;
            }
            return 0; 




        }
} }


   
    

















