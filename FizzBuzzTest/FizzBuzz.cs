using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzTest
{
    class FizzBuzz
    {
        internal string evaluate(int p)
        {
            if (isMultipleOfThree(p) && isMultipleOfFive(p))
            {
                return "FizzBuzz";
            }
            else if (isMultipleOfThree(p))
            {
                return "Fizz";
            }
            else if (isMultipleOfFive(p))
            {
                return "Buzz";
            }
            else
            {
                return p.ToString();
            }
        }

        public bool isMultipleOfThree(int num)
        {
            return num % 3 == 0;
        }

        public bool isMultipleOfFive(int num)
        {
            return num % 5 == 0;
        }

        #region NOT USED

        public bool isMultipleOfThreeAndFive(int num)
        {
            return isMultipleOfThree(num) && isMultipleOfFive(num);
        }

        /// <summary>
        /// Remove the factor from the calculator and pass it in by inverting the control to the caller
        /// </summary>
        /// <param name="numberToTest"></param>
        /// <param name="factor"></param>
        /// <returns></returns>
        public bool isMultipleOf(int numberToTest, int factor)
        {
            return numberToTest % factor == 0;
        }

        #endregion
    }
}
