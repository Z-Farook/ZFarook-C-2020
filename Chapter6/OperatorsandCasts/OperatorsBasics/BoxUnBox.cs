using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorsAndCasts
{
    internal static class BoxUnBox
    {
        public static void Test()
        {
            int f = 34;
            object t = f;  //boxed
            int g = (int)t; // un-boxed
            Console.WriteLine(g);

            int h = 54;
            string j = h.ToString(); // boxed and unboxed IMPLICITLY !!!! runtime creates a temporary reference-type
            Console.WriteLine(j);
        }
    }
}
