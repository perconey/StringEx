using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEx
{
    public static class BooleanMethods
    {
        public static bool IsCamelCase(this string str)
        {
            for(int i = 0; i < str.Length; i++)
            {
                if (Char.IsSymbol(str[i]) || Char.IsWhiteSpace(str[i]) || Char.IsUpper(str[0])) return false;
            }
            return true;
        }
    }
}
