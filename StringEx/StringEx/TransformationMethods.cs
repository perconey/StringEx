using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEx
{
    //      String transforming methods
    public static class TransformationMethods
    {
        /// <summary>
        /// Transforms the value of specified string into it's reversed equivalent
        /// </summary>
        /// <returns>Reversed string</returns>
        public static string Reverse(this string str)
        {
            char[] ca = str.ToCharArray();
            Array.Reverse(ca);
            return new string(ca);
        }
    }
}
