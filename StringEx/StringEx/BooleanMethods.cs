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
