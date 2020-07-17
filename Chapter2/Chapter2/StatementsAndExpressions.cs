using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Emit;
using System.Text;
using System.Threading;

namespace Chapter2
{
    internal static class StatementsAndExpressions
    {
        internal static void myStatements()
        {
            int a = 74;
            int b = 54;
            int c;
            c = a + b;
            Console.WriteLine("myStatements res: " + c);
        }
        internal static void blockStatement()
        {
            int a = 74;
            int b = 54;
            int c;
            c = a + b;
            { /*these empty braces are also a form of a statement */
                Console.WriteLine("myStatement1s2 res: " + c);
            }
        }
        internal static void myExepression()
        {
            int a = 74;
            int b = 54;
            double x = (a * 4 + Math.Sqrt(b));
            Console.WriteLine("my expression res: " + x);
        }
        //Method Invocation Expressions As Statements
        //the main concern of the following method is that this does nothing. 
        //nothing with it and letting it hang in the air.
        internal static void uselessExepressionAsStatement()
        {
            Console.WriteLine("Hello, world!");
            Console.WriteLine(12 + 30);
            Console.WriteLine("write a number!");
            Console.ReadKey();
            Console.WriteLine("\n-----------------------" );
            // we are doing nothing with the following 
            Math.Sqrt(4);
        }
        // To see the compiler error for Example above, change this:
#if false
//  to:
//#if true
        internal static void ExpressionsUnacceptableAsStatements()
        {
            Console.ReadKey().KeyChar + "!";
            Math.Sqrt(4) + 1;
        }
#endif
        //assignment are expression 
        internal static void assignmentIsExepression(){
            int number;
            Console.WriteLine(number = 7);
            Console.WriteLine(number);

            int x, y;
            x = y = 0;
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        //order of expression
        internal static void orderOfTheExpressionForOprands()
        {
            var a = 10 + (8 / 2); // 14
            var b = (10 + 8) / 2; //= 9 
        }
        

    }
}
