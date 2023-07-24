using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {//vals.Contains(false);

            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }

            var sum = numbers.Sum();

            return (sum % 2 != 0);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)

        {//password.Any(char.IsLower) && password.Any(char.IsUpper) && password.Any(char.IsNumber);
            var isLower = false;
            var isUpper = false;
            var isNumber = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLower(password[i]))
                {
                    isLower = true;
                }
                if (char.IsUpper(password[i]))
                {
                    isUpper = true;
                }
                if (char.IsNumber(password[i]))
                {
                    isNumber = true;
                }
            }
            if (isLower && isUpper && isNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {// single line Enumerable.Range(1, 99).Where(x => x % 2 != 0).ToArray();
            var list = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    list.Add(i);
                }
            }
            return list.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }

        private static char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }
    }
}

