using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter2
{
    internal static class CSharpPatterns
    {

        public static void PatternWithTupleSwitchCase((int x, int y) tupleArg)
        {
            switch (tupleArg)
            {
                case (1, 0):
                    Console.WriteLine($"This matched bingo");
                    break;
                case (1, 2):
                    Console.WriteLine($"This is matched with second case");
                    break;
                default:
                    Console.WriteLine($"Nothing matched with tuple: ({tupleArg.x} , {tupleArg.y})");
                    break;
            }

        }

        public static void CheckTheArgTypeAndCallAMethod(object x)
        {
            switch (x)
            {
                case string s:
                    Console.WriteLine($"The type of argument was: {s.GetType()}");
                    break;
                case int i:
                    Console.WriteLine($"The type of argument was: {i.GetType()}");
                    break;
                default:
                    Console.WriteLine("The type of argument was something else than: int or string!!");
                    break;

            }
        }

        public static void MoreThanOneKinfOfPositionalPattern(object obj)
        {
            switch (obj)
            {
                /*Positional pattern WITH CONSTANT and TYPE PATTERNS*/
                case (0, int a):
                    Console.WriteLine($"Positional pattern with constant and type patterns ");
                    break;

                /*  POSITIONAL PATTERN: tuple pattern *(1,3)* is really just a special case of a positional pattern*/
                case (int x, int y):
                    Console.WriteLine($"Hello, i am POSITIONAL case ");
                    break;

                /*This is a discard pattern.*/
                case (int x, _):
                    Console.WriteLine($"At X: {x}. you won’t actually need a type pattern’s output—it might " +
                        $"be enough just to know that the input matched a pattern");
                    break;

                /*Positional pattern WITH VAR*/
                case (var x, var y):
                    Console.WriteLine($"Hello, i am POSITIONAL case with VAR keyword!");

                    break;
                default:
                    Console.WriteLine("No case was matched!!");
                    break;

            }
        }

        public static void Propertypatterns(object j)
        {
            /*Property pattern without output*/
            switch (j)
            {
                /*Note that here Length is some random variable!! it's a property of MS provided class String*/
                case string { Length: 0 }:
                    Console.WriteLine($"your name doe's not have any letters wow! man");
                    break;
            }

            /*Property pattern with output*/
            switch (j)
            {
                /*IF you do want to print the actual length of the property then you must define a variable which aids to do that
                 *Property patterns can optionally SPECIFY AN OUTPUT 
                 */
                case string { Length: 0 } s:

                    Console.WriteLine($"your name have only {s.Length} letters wow! man");
                    break;
                default:
                    break;
            }

            /*Since each PROPERTY in a property PATTERN contains a nested pattern, those too can
            produce outputs*/
            switch (j)
            {
                case string { Length: int length }:
                    Console.WriteLine($"How long is a piece of string? This long: {length}");
                    break;
            }
        }


        public static void ConditionalPatternUsigWhen(object obj)
        {
            switch (obj)
            {
                case (int x, int y) when x > y:
                    Console.WriteLine($"{x} > {y}");
                    break;

                default:
                    Console.WriteLine("X is not Y");
                    break;
            }
        }

        public static object SwitchStatementWithoutExpression(object obj)
        {
            switch (obj)
            {
                case (int x, int y) when x < y: { var i = "Portrait"; Console.WriteLine(i); return i; }
                case (int x, int y) when x > y: { var i = "Landscape"; Console.WriteLine(i); return i; }
                /*Fires when there is tuple input to this and the x , y are equal*/
                case (int _, int _): { var i = "Square"; Console.WriteLine(i); return i; }
                default: { var i = "Nothing is found, because the argument was not a tuple"; Console.WriteLine(i); return i; }
            }
        }

        public static object SwitchStatementWithExpression(object obj)
        {
            return obj switch
            {
                (int x, int y) when x < y => Test(x),
                (int x, int y) when x > y => "Landscape",
                /*Fires when there is tuple input to this and the x , y are equal*/
                (int _, int _) => "Square",
                /*If functions parameters were as: (int x , int y )tuple then the compiler will produce an error because then 
                 all the possible cases will be already handled by the first 3 statements*/
                _ => "Nothing is found, because the argument was not a tuple"
            };
        }
        public static object Test(int x) => "Portrait and x was:" + x;


        public static void BooleanPatternWithIs(object myObj)
        {
            /*Note how the obj is being used in the variable assignment 
             * you also cannot print the {x}, {y} because you can see that it is an expression which is evaluating to a boolean*/
            bool areThere2Val = myObj is (int x, int y);
            Console.WriteLine($"Are there two variable in the tuple?: {areThere2Val} ");
        }

        public static void UseTheVariableOfBoolPattern(object myArg)
        {
            /*Prints the string "test" if THE MYARG PARAMETER contains the FIRST ARGUMENT OF TYPE INT AND IS A TUPLE*/
            if (myArg is (int x, _))
                Console.WriteLine("X was: " + x);
            else
                Console.WriteLine("The argument was not tuple of integers!!");

        }

        public static void ConditionalPatternWithOutUsingWhenKeyWord( object myObj)
        {
            if (myObj is (int x, int y) && x > y)
                Console.WriteLine("That was epic conditional pattern check!!");
            else
                Console.WriteLine("The argument was not tuple of integers!!");

        }
    }
}