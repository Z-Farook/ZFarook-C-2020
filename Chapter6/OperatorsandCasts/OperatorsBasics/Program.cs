using System;
using System.Collections.Generic;
using System.Threading;
using System.Xml.Linq;

namespace OperatorsAndCasts
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

            #region For C# boxing and unboxing 
#if false
            BoxUnBox.Test();
#endif
            #endregion

            #region For C# COMPARING OBJECTS FOR EQUALITY
#if true
            B.Test();
            Point point2D = new Point(5, 5);
            Point3D point3Da = new Point3D(5, 5, 2);
            Console.WriteLine("{0} = {1}: {2}",
                    point2D, point3Da, point2D.Equals(point2D));
            
            var a = new StrA();
            var b = new StrB();
            StrB.ValueTypeComparison(a, b);
            Console.WriteLine();
#endif
            #endregion



        }
    }
}
