using System;

namespace StringEx
{
    public static class BooleanMethods
    {
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

        public static bool IsDelimiterSeparated(this string str, bool mindCasing)
        {
            var c = str.ToCharArray();
            if (mindCasing && Char.IsUpper(c[0]))
            {
                return false;
            }
            //default value
            char symbol = ' ';
            for (int i = 1; i < c.Length; i++)
            {
                if(symbol == ' ')
                {
                    if (Char.IsSymbol(c[i]))
                        symbol = c[i];
                }
                else
                {
                    if(Char.IsSymbol(c[i]))
                    {
                        if (c[i] != symbol)
                            return false;
                    }
                }
            }

            return true;
        }

    }
}
