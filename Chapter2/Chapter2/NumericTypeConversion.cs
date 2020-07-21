using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Chapter2
{
    internal static class NumericTypeConversion
    {
        /*Implicit conversion*/
        internal static void IntToDouble()
        {
            int a = 40;
            double b = a;
            Console.WriteLine(a / 5);
            Console.WriteLine("The type of b is: " + b.GetType());
            Console.WriteLine("I am converted to double: " + b / 5);
        }
        internal static void ImplicitConversionFailed()
        {
#pragma warning disable
            double a = 1.0;
            /*to see the error do: */
#if flase
//to:
//#if true
            int b = a;
#endif
        }
        internal static void ExplicitTypeCasting()
        {
            double a = 1.0;
            int b = (int)a; /*We are forcing it to be of type INT */
        }

        internal static void IntentionalOverflow()
        {
            int start = Environment.TickCount;
            DoSomeWork();
            int end = Environment.TickCount;

            int totalTicks = end - start;
            Console.WriteLine(totalTicks);
        }

        internal static string DoSomeWork() =>  "i did";

        internal static void CheckedExpressions()
        {
            int a = 2_000_000_000;
            int b = 500_000_000;
            int c = 42;

            int result = (a + b) + c;
/*to see the error uncomment the next 3 comments and run the*/
            //checked
            //{
                int r1 = a + b;
                int r2 = r1 - (int)c;
            //}
        }
    }
}
    
