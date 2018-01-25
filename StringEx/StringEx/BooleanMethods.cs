using System;

namespace StringEx
{
    //     Boolean methods

    public static class BooleanMethods
    {
        /// <summary>
        /// Indicates whether the specified string is categorized as CamelCase string 
        /// </summary>
        /// <returns>Boolean</returns>
        public static bool IsCamelCase(this string str)
        {
            var c = str.ToCharArray();
            if (Char.IsUpper(c[0]))
            {
                return false;
            }
            for (int i = 1; i < c.Length; i++)
            {
                if (Char.IsPunctuation(c[i]) || Char.IsSymbol(c[i]) || c[i] == ' ')
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Indicates whether the specified string is a number
        /// </summary>
        /// <returns>Boolean</returns>
        public static bool IsNumber(this string str)
        {
            foreach(var c in str)
            {
                if (!Char.IsNumber(c))
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Indicates whether the specified string is categorized as DelimiterSeparated string 
        /// </summary>
        /// <returns>Boolean</returns>
        public static bool IsDelimiterSeparated(this string str, bool mindCasing)
        {
            var c = str.ToCharArray();
            //default value
            char symbol = 's';
            bool sySet = false;
            for (int i = 0; i < c.Length; i++)
            {
                if (mindCasing && Char.IsUpper(c[i])) return false;
                if (Char.IsSymbol(c[i]) || Char.IsPunctuation(c[i]) && sySet == false)
                {
                    symbol = c[i];
                    sySet = true;
                    continue;
                }
               if(Char.IsSymbol(c[i]) || Char.IsPunctuation(c[i]))
                {
                    if(c[i] != symbol)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

    }
}
