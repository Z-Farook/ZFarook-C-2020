using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace GenericsBasics
{
    #region/*============================================ GENERIC STRUCTS=======================================================*/

    /**You can use the nullable without any class or struct here is a struct used due to restrictions from the namespace  */
    internal struct ATest
    {
        public static int? GetNullableType(int? x)
        {
            if (x == null)
            {
                Console.WriteLine("x2 is null");
            }
            else if (x < 0)
            {
                Console.WriteLine("x1 is smaller than 0");
            }
            else
            {
                Console.WriteLine("x is: " + x);
            }
            return x;
        }
    }
    #endregion
}
