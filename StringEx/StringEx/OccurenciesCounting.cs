using System;

namespace StringEx
{
    public static class OccurenciesCounting
    {


        //     Occurencies counting methods

        /// <summary>
        /// Gets the 32-bit integer that represents a number of unique words in string separated by whitespace, dot etc.
        /// </summary>
        /// <returns>Number of words</returns>
        public static int WordsStandardCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        /// <summary>
        /// Gets the 32-bit integer that represents a number of upper case characters in string 
        /// </summary>
        /// <returns>Number of upper case characters</returns>
        public static int UpperCaseCount(this string str)
        {
            int i = 0;
            foreach (char c in str)
                if(Char.IsUpper(c))
                    i++;

            return i;
        }

        /// <summary>
        /// Gets the 32-bit integer that represents a number of occurencies of character supplied in parameter
        ///<para>If MindCasing paramters is true, method does recognize casing of characters</para> 
        /// </summary>
        /// <returns>Number of character occurencies</returns>
        public static int CharacterCount(this string str, char WantedCharacter, bool MindCasing = false)
        {
            int i = 0;
            if (!MindCasing)
                str = str.ToLower();
            
            foreach (char c in str)
                if (c == WantedCharacter)
                    i++;
 
            return i;
        }


        /// <summary>
        /// Gets the 32-bit integer that represents a number of lower case characters in string 
        /// </summary>
        /// <returns>Number of lower case characters</returns>
        public static int LowerCaseCount(this string str)
        {
            int i = 0;
            foreach (char c in str)
                if (Char.IsLower(c))
                    i++;
            return i;
        }


        /// <summary>
        /// Gets the 32-bit integer that represents a number of numeric type characters in string
        /// </summary>
        /// <returns>Quantity of numeric type characters</returns>
        public static int NumbersCount(this string str)
        {
            int i = 0;
            foreach (char c in str)
                if (Char.IsNumber(c))
                    i++;
            return i;
        }

        /// <summary>
        /// Gets the 32-bit integer that represents a number of symbolic characters in string 
        /// </summary>
        /// <returns>Number of symbols in string</returns>
        public static int SymbolsCount(this string str)
        {
            int i = 0;
            foreach (char c in str)
                if (Char.IsSymbol(c))
                    i++;

            return i;
        }

        /// <summary>
        /// Gets the 32-bit integer that represents a number of characters satysfying Char.IsSurrogate in string
        /// </summary>
        /// <returns>Number of surrogate</returns>
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
