using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorsBasics
{
    public class OperatorHolder
    {
        public static int temp = 18;
        public static void PreAndPsotOper()
        {
            var c = 12;
            if (++c == 13)
            {
                Console.WriteLine("It passed because the c was incremented before the expression");
            }
            var d = 12;
            if (d++ == 13)
            {
                Console.WriteLine("It wasn't passed because the c was incremented after the expression");
            }

        }

        public static string TheTernaryOper(int x)
        {
            return x == temp ? "Adult" : "Not adult";
        }

        public static void TheCheckedOper()
        {
            var i = int.MaxValue;
            int x = 0;
            Console.WriteLine("The max value of int can be between: " + int.MaxValue + " -- " + int.MaxValue);
            Console.WriteLine("The initial vale of was: " + x);

            x += int.MaxValue;

            Console.WriteLine($"It is failing with the checked operator because you tried to assign a number: {i} + 1\n and" +
                $" that {"is not between the boundary of the int type".ToUpper()}.\n");

#if false //turn this to true to see the error
            checked
            {
                x += 122;
            }
#endif
            /**The code on the next line is eqUAL TO THE WHOLE CODE in the #if preprocessor
             * IF the CHECKED (Overflow/Underflow) is operator is ENABLED for the whole project through the Advance Build Settings*/

            //x += 1;

            Console.WriteLine("Final res: " + x);
            Console.WriteLine();

        }

        public static void TheUncheckedoper()
        {
            var i = 0;
            byte x = 0;

            Console.WriteLine("The max value of byte can be can between: " + byte.MaxValue + " -- " + byte.MaxValue);
            Console.WriteLine("The initial vale of was: " + x);

            x += byte.MaxValue;

            Console.WriteLine($"It is not failed {"because unchecked operator is used".ToUpper()} even we tried to assign a number: {i += x + 1}\n and" +
                $" that {"is not between the boundary of the byte type".ToUpper()}, but you lose data.\n");


            /**This will intentional ignore the data loss */
            unchecked
            {
                x += 1;
            }

            Console.WriteLine("Final res: " + x);

        }
    }
}
