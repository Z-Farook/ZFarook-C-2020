using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorsBasics
{
    class TypeSafety
    {
#pragma warning disable
        public static void TestTypeCasting()
        {

            long val = 30000;
            int i = (int)val; // A valid cast. The maximum int is 2147483647

            long val2 = 3000000000;
            int i2 = (int)val;  // An invalid cast. The maximum int is 2147483647 

            long val3 = 3000000000;
            int i3 = checked((int)val); //confirm that a cast is safe and to force the runtime to throw an overflow exception if it is not:

            double price = 25.30;
            int approximatePrice = (int)(price + 0.5);

            ushort c = 43;
            char symbol = (char)c;
            Console.WriteLine(symbol);

            int? a = null;
            //int b = (int)a;  /*Will throw exception*/
            int i4 = 10;
            string s = i4.ToString();

            string s2 = "100";
            int i5 = int.Parse(s);
            Console.WriteLine(i + 50);
        }
        public string Description;
        public int ApproxPrice;
#pragma warning restore
    }
}
