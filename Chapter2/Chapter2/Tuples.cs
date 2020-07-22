using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter2
{
    internal static class Tuples
    {
        public static void MyTuple()
        {
            //not named tuple
            var tup = (1, 2); /*using var to get the type via Compiler inference*/
            Console.WriteLine(tup.Item1.ToString(), tup.Item2.ToString());

            (int x, string y) tup2 = (2, "tuple 2"); /*Named Tuple*/
            Console.WriteLine(tup2.x.ToString(), tup2.y);

            //When using VAR you can make the named and not named tuple also 
            var namedTuple = (a: 10, b: 23); /*Naming tuple members in the initializer*/
            namedTuple.a++;

            //Make Tuple of existing data
            int c = 4;
            double d = 1.0;
            var tupleOfVariable = (c, d);
            tupleOfVariable.c = 2;
        }

        //Structural similarity of tuples 
        public static void AssigningTupleValues()
        {
            (int x, int y) tup = (45, 3);
            (int width, int height) rectangle = tup;
            (int DadAge, int NumberOfChild) fami = tup;
        }

        //tuple deconstruction 
        public static void DeconstructTuple()
        {
            (int x, int y) tup = (45, 3);
            (int width, int height) rectangle = (10, 15);
            (int x, int y) = tup; /*This deconstruct *tup* into two local variables called X and Y*/
            Console.WriteLine($"1: {x}, {y}");
            (int w, int h) = rectangle;
            Console.WriteLine($"2: {w}, {h}");

            (int X, int Y) point1 = (40, 6);
            (int X, int Y) point2 = (12, 34);
            (int x1, int y1) = point1;
            Console.WriteLine($"1: {x}, {y}");
            /**
             *On the next line the x and y refers to the two variables "x1 y1"
             *that are originated in the deconstructing of *point1* 
             and then the values of those two are changed to those of *point2*'s x and y*/
            (x, y) = point2;
            Console.WriteLine($"2: {x}, {y}");

        }
    }
}
