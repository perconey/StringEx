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

    }
}
