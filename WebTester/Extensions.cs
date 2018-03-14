using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebTester
{
    static class Extensions
    {
        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }
    }
}
