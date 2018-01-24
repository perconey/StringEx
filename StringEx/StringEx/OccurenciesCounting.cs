using System;

namespace StringEx
{
    public static class OccurenciesCounting
    {

        /// <summary>
        ///     Occurencies counting methods
        /// </summary>


        public static int WordsStandardCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static int UpperCaseCount(this string str)
        {
            int i = 0;
            foreach (char c in str)
                if(Char.IsUpper(c))
                    i++;

            return i;
        }

        public static int LowerCaseCount(this string str)
        {
            int i = 0;
            foreach (char c in str)
                if (Char.IsLower(c))
                    i++;
            return i;
        }

        public static int NumbersCount(this string str)
        {
            int i = 0;
            foreach (char c in str)
                if (Char.IsNumber(c))
                    i++;
            return i;
        }

        public static int SymbolsCount(this string str)
        {
            int i = 0;
            foreach (char c in str)
                if (Char.IsSymbol(c))
                    i++;

            return i;
        }

        public static int SurrogateCount(this string str)
        {
            int i = 0;
            foreach (char c in str)
                if (Char.IsSurrogate(c))
                    i++;
            return i;
        }
    }
}
