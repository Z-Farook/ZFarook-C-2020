using System;

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
#if false
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

            #region For C# arithmetic operators overloading
#if false
            AdditionHolder adh = new AdditionHolder(12, 1.0);

            Console.WriteLine("The result without operator loading when: AgeDeterminer(13, adh)");
            var res = AdditionHolder.AgeDeterminer(13, adh);
            Console.WriteLine((res.age, res.grownedHeight));

            Console.WriteLine("The result with operator loading when:  13 + adh =");
            var res2 = 13 + adh;
            Console.WriteLine((res2.age, res2.grownedHeight));

            var thrd1 = new ThreeDMoves(1.0, 2.0, 3.0);
            var thrd2 = new ThreeDMoves(2.0, 3.0, 4.0);
            var thrd3 = thrd1 *= 2;
            var thrd4 = thrd1 * thrd3;

            Console.WriteLine($"thrd3: {thrd3}\nthrd4: {thrd4}");
#endif
            #endregion

            #region For C# Overloading the Comparison Operators
#if false
            var i1 = new DayTemperature(25, 19);
            var i2 = new DayTemperature(25, 19);
            var i3 = new DayTemperature(125, 119);

            DayTemperature.IsTempSame(i1, i1);
            var resOfEqualOperator = i1 == i2;
            var resOfNotEqualOperator = i1 != i2;

            i1.Equals(i2);

            i1.GetHashCode();
            i2.GetHashCode();
            i3.GetHashCode();

            Console.WriteLine("======================================================================");
            DayTemperature.IsTempSame(i1, i3);
            var resOfEqualOperator1 = i1 == i3;
            var resOfNotEqualOperato2r = i1 != i3;
#endif
            #endregion

            #region For C# USER-DEFINED CASTS (implicit and explicit) it's kind like a operator overloading but not really
#if true
            var toBeConverted = new TheDestinationType(101);
            Console.WriteLine($"The original type of toBeConverted: {toBeConverted.GetType().Name}");
            var converted = (TheSourceType)toBeConverted;
            Console.WriteLine($"The destination type of toBeConverted: {converted.GetType().Name}\n");
            
            Console.WriteLine($"//From *heSourceType type  to short ");
            short shortCasting = (short )converted;
            Console.WriteLine($"The destination type of shortCasting: {shortCasting.GetType().Name}");

            Console.WriteLine($"//From *short type  to double  ");
           var shortTodouble =  (double)shortCasting;
            Console.WriteLine($"The destination type of shortTodouble: {shortTodouble.GetType().Name}");
#endif
            #endregion

            Console.WriteLine();


        }
    }
}
