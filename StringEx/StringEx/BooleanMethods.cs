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
            var c = str.ToCharArray();
            if (Char.IsUpper(c[0]))
            {
                return false;
            }
            for (int i = 1; i < c.Length; i++)
            {
                if (Char.IsSymbol(c[i]) || c[i] == ' ')
                {
                    return false;
                }
            }

            return true;
        }
    }
}
