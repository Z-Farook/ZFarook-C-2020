using System;
using System.Collections.Generic;
using System.Threading;

namespace OperatorsBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            #region For C#  OPERATOR
#if false
            /**Pre- and post increment */
            OperatorHolder.PreAndPsotOper();
            Console.WriteLine(OperatorHolder.TheTernaryOper(12));

            /**The checked and unchecked operator */
            OperatorHolder.TheCheckedOper();
            OperatorHolder.TheUncheckedoper();
#endif

#if false
            AsAndIsHolder.TheIsOper();
            AsAndIsHolder.CreatAvarUsingIsOper(new AsAndIsHolder());
            Console.WriteLine();
            AsAndIsHolder.TheAsOper();
#endif

#if false
            SizeOfHolder.PrintBytes();
#endif
            #endregion

            #region For C# Type safety (Explicit type casting)
#if false
            TypeSafety.TestTypeCasting();
            double[] Prices = { 25.30, 26.20, 27.40, 30.00 };
            var h = new TypeSafety();
            h.Description = "Hello there.";
            h.ApproxPrice = (int)(Prices[0] + 0.5);
            Console.WriteLine(h.ApproxPrice);
#endif
            #endregion


            Console.WriteLine();

        }
    }
}
