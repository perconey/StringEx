using System;

namespace StringEx
{
    //     Case converting methods

    public static class CaseConverting
    {
        #region ToCamelCase summary
        /// <summary>
        /// Converts the value of specified string to a CamelCase string
        /// </summary>
        /// <returns>String satisfying CamelCase rules</returns>
                #endregion
        public static string ToCamelCase(this string str)
        {
            str = str.ToLower();
            int i = 0;
            foreach (char c in str)
            {
                if (c == ' ')
                {
                    try
                    {
                        char tc = Char.ToUpper(str[i + 1]);
                        str = str.Remove(i, 2).Insert(i, tc.ToString());
                    }
                    catch (Exception ex) { };
                }
                else
                {
                    i++;
                }
            }
            return str;
        }
        #region ToDelimiterSeparated summary

        /// <summary>
        /// Converts the value of specified string to a DelimiterSeparated string with delimiter as provided in first argument
        /// delimiter - char that will be used as a separator
        /// keepCasing - determines if the product will keep the original casing
        /// </summary>
        /// <returns>String satisfying DelimiterSeparated rules</returns>
                #endregion
        public static string ToDelimiterSeparated(this string str, char delimiter, bool keepCasing)
        {
            if(keepCasing)
            str = str.Replace(' ', delimiter);
            else
                str = str.ToLower().Replace(' ', delimiter);
            return str;
        }

    }
}
