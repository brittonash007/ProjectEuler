using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.CustomTools
{
    public static class ExtensionMethods
    {
        public static float Sum<T>(this IEnumerable<T> list, Func<T, float> selector)
        {
            return list.Select(selector).Sum();
        }
    }
}
