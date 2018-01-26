﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEx
{
    public static class NumberAnalysisMethods
    {
        /// <summary>
        /// Indicates whether the specified string is divisible by 4
        /// </summary>
        /// <returns>Boolean</returns>
        public static bool DivisibleBy4(this string str)
        {
            if (!str.IsInteger())
                throw new System.ArgumentException("Provided string is not a number");
            if (str[0] == '-')
                str = str.Remove(0, 1);
            if (str.Length < 2)
                return false;

            var strint = str.ToString();
            if (((int)Char.GetNumericValue(strint[strint.Length - 1])
                + (int)Char.GetNumericValue(strint[strint.Length - 2])) % 4 != 0)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Indicates whether the specified string is divisible by 3
        /// </summary>
        /// <returns>Boolean</returns>
        public static bool DivisibleBy3(this string str)
        {
            if (!str.IsInteger())
                throw new System.ArgumentException("Provided string is not a number");
            if (str[0] == '-')
                str = str.Remove(0, 1);

            var strint = str.ToString();
            long sum = 0;
            for (int i = strint.Length - 1; i >= 0; i--)
            {
                sum += (int)Char.GetNumericValue(strint[i]);
            }
            if (sum % 3 != 0)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Indicates whether the specified string is divisible by 9
        /// </summary>
        /// <returns>Boolean</returns>
        public static bool DivisibleBy9(this string str)
        {
            if (!str.IsInteger())
                throw new System.ArgumentException("Provided string is not a number");
            if (str[0] == '-')
                str = str.Remove(0, 1);

            var strint = str.ToString();
            long sum = 0;
            for (int i = strint.Length - 1; i >= 0; i--)
            {
                sum += (int)Char.GetNumericValue(strint[i]);
            }
            if (sum % 3 != 0)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Indicates whether the specified string is divisible by 7
        /// </summary>
        /// <returns>Boolean</returns>
        public static bool DivisibleBy7(this string str)
        {
            if (!str.IsInteger())
                throw new System.ArgumentException("Provided string is not a number");
            if (str[0] == '-')
                str = str.Remove(0, 1);

            int powerOf3 = 3;
            long sum = 0;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (i == str.Length - 1)
                {
                    sum += (int)Char.GetNumericValue(str[i]);
                    continue;
                }
                if (i == str.Length - 2)
                {
                    sum += (int)Char.GetNumericValue(str[i]) * 3;
                    continue;
                }
                powerOf3 = powerOf3 * 3;
                sum += (int)Char.GetNumericValue(str[i]) * powerOf3;
            }
            if (sum % 7 != 0)
                return false;
            return true;
        }

        /// <summary>
        /// Indicates whether the specified string is divisible by 7
        /// </summary>
        /// <returns>Boolean</returns>
        public static bool DivisibleBy11(this string str)
        {
            if (!str.IsInteger())
                throw new System.ArgumentException("Provided string is not a number");
            if (str[0] == '-')
                str = str.Remove(0, 1);

            long oddSum = 0; long evenSum = 0;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (i % 2 == 0)
                {
                    evenSum += (int)Char.GetNumericValue(str[i]);
                }
                else
                {
                    oddSum += (int)Char.GetNumericValue(str[i]);
                }
            }
            if (oddSum - evenSum % 11 != 0)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Indicates whether the specified string is divisible by 20
        /// </summary>
        /// <returns>Boolean</returns>
        public static bool DivisibleBy20(this string str)
        {
            if (!str.IsInteger())
                throw new System.ArgumentException("Provided string is not a number");
            if (str[0] == '-')
                str = str.Remove(0, 1);
            if (str.Length < 2)
                return false;

            if ((int)Char.GetNumericValue(str[str.Length - 1]) != 0)
            {
                return false;
            }
            if ((int)Char.GetNumericValue(str[str.Length - 2])%2 != 0)
            {
                return false;
            }
            return true;
        }


        //public static bool DivisibleBy(this string str)
        //{
        //    var strint = str.ToString();

        //    return true;
        //}
    }
}
