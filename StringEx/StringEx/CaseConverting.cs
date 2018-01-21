using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEx
{
    public static class CaseConverting
    {
        public static string ToCamelCase(this string str)
        {
            str = str.ToLower();
            int i = 0;
            foreach (char c in str)
            {
                if (c == ' ')
                {
                    str = str.Remove(i, 1);
                    try
                    {
                        str = str.Insert(i, Char.ToUpper(str[i]).ToString());
                        str = str.Remove(i + 1, 1);
                    }
                    catch (Exception ex) { };
                }
                i++;
            }
            return str;
        }

    }
}
