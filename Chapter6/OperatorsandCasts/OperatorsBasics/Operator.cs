using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace OperatorsAndCasts
{
    // The classes names indicates what they are possibly holding
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


            /**This will intentionally ignore the data loss */
            unchecked
            {
                x += 1;
            }

            Console.WriteLine("Final res: " + x);

        }
    }

    // The classes names indicates what they are possibly holding
    public class AsAndIsHolder
    {
        public string testi = "Good stuff";
        public static void TheIsOper()
        {
            int f = 10;
#pragma warning disable CS0183 
            // 'is' expression's given expression is always of the provided type
            if (f is object)
#pragma warning restore CS0183
            {
                Console.WriteLine("f is an object");
            }

            Console.WriteLine();
            int i = 42;
            if (i is 42) // not that here we are CHECKING the literal 42, in other words a CONSTANT not an object 
            {
                Console.WriteLine("i has the value 42");
            }
            object o = null;
            if (o is null)
            {
                Console.WriteLine("o is null");
            }
        }
        public static void CreatAvarUsingIsOper(object obj)
        {
            if (obj is AsAndIsHolder phi)
                Console.WriteLine($"\nis operator passed because the obj was indeed the type of: {phi.GetType().Name}");
        }
        public static void TheAsOper()
        {
            object[] obj = new object[5];
            obj[0] = new AsAndIsHolder();
            obj[1] = new AsAndIsHolder();
            obj[2] = "C#";
            obj[3] = 334.5;
            obj[4] = null;

            for (int j = 0; j < obj.Length; ++j)
            {
                // using AS operator 
                string str = obj[j] as string; /**Note when object at index j can't be converted then IT GIVES NULL back  */

                if (str == null)
                    Console.WriteLine($"[{j}]: {str} can't be converted to  String\n");

                if (str != null)
                {
                    Console.WriteLine($"[{j} : '{str}' is a string\n");
                }
                else
                {
                    Console.WriteLine($"      Class or value: {obj[j]}, is not a string\n");
                }
            }

        }
    }
    public struct SizeOfHolder
    {
        public SizeOfHolder(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; }
        public int Y { get; }

        public static void PrintBytes()
        {
            /*By DEFAULT, UNSAFE code is NOT ALLOWED. You need to SPECIFY the
            AllowUnsafeBlocks IN THE CSPROJ project file.*/
            unsafe
            {
                Console.WriteLine($"Point size in bytes: {sizeof(SizeOfHolder)}");
            }
        }
    }
}
