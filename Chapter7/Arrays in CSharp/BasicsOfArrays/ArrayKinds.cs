using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfArrays
{
    internal class ArrayHolder
    {
        public int TestA { get; set; }
        public int TestB { get; set; }
        public static void SingleDimArrayMaking()
        {
            int[] sinDim0 = new int[2];
            sinDim0[0] = 1;
            sinDim0[1] = 1;
            //sinDim0[2] = 1; //error if tried

            int[] sinDim1 = new int[] { 1, 2 }; // size omitted use array initializer
            Console.WriteLine(sinDim1[0]);

            //The same array using array EVEN SHORTER initializing syntax
            int[] singDin3 = { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine(singDin3[singDin3.Length - 1]);
        }
        public static void DoubleDimArrayMaking()
        {
            // The same array WITH DIMENSIONS SPECIFIED.
            var array2DimA = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            Console.WriteLine("\n" + array2DimA[1, 0]);

            // The same array WITH NO DIMENSIONS SPECIFIED / size omitted use array initializer.
            /*Not what we are passing instead of [2,2]*/
            int[,] array2DimB = new int[,] {
                { 1,2} ,
                { 3,4}
            };
            Console.WriteLine(array2DimB[1, 1]);

            //The same array using array EVEN SHORTER initializing syntax
            int[,] array2DimC = {
                { 1,2} ,
                { 3,4}
            };

            Console.WriteLine(array2DimC[0, 1]);

        }
        public static void ThreeDimArrayMaking()
        {
            var threeDimA = new int[2, 1, 2]
            /*dim 1 = 2 rows*/
            {
               {
                /*dim 2  have  1 rows, and have two element*/
                    {1 ,2 }
               },

               {

                /*dim 2  have  1 rows, and have two element*/
                    { 3,4}
               },
            };
            Console.WriteLine("\nWith syntax style:  var threeDimA = new int[2, 1, 2]\n");
            Console.WriteLine("{\n { { 1 , 2 } },\n { { 3 , 4} }, \n};");
            Console.WriteLine($"[0,0,1] => {threeDimA[0, 0, 1]}");
            Console.WriteLine($"[1,0,1] => {threeDimA[1, 0, 1]}");
            Console.WriteLine($"[1,0,0] => {threeDimA[1, 0, 0]}");

            /*The same array WITH NO DIMENSIONS SPECIFIED / size omitted use array initializer.
             * Not what we are passing instead of [2, 1, 2]*/
            var threeDimB = new int[,,]
            /*dim 1 = 2 rows*/
            {
              {
                  /*dim 2  have  1 rows, and have two element*/
                  {1 ,2 }
              },
              {
                /*dim 2  have  1 rows, and have two element*/
                { 3,4}
              },
            };

            Console.WriteLine("\nWith syntax style:  var threeDimB = new int[,,]\n");
            Console.WriteLine("{\n { { 1 , 2 } },\n { { 3 , 4} }, \n};");
            Console.WriteLine($"[0,0,1] => {threeDimB[0, 0, 1]}");
            Console.WriteLine($"[1,0,1] => {threeDimB[1, 0, 1]}");
            Console.WriteLine($"[1,0,0] => {threeDimB[1, 0, 0]}");

            //The same array using array EVEN SHORTER initializing syntax
            int[,,] threeDimC = 
           /*dim 1 = 2 rows*/
           {
              {
                  /*dim 2  have  1 rows, and have two element*/
                  {1 ,2 }
              },
              {
                /*dim 2  have  1 rows, and have two element*/
                { 3,4}
              },
           };

            Console.WriteLine("\nWith syntax style:  int[,,] threeDimC = \n");
            Console.WriteLine("{\n { { 1 , 2 } },\n { { 3 , 4} }, \n};");
            Console.WriteLine($"[0,0,1] => {threeDimC[0, 0, 1]}");
            Console.WriteLine($"[1,0,1] => {threeDimC[1, 0, 1]}");
            Console.WriteLine($"[1,0,0] => {threeDimC[1, 0, 0]}");

        }
        public static void TheJaggedArrayMaking()
        {
            int[][] jaggedA = new int[2][];
            jaggedA[0] = new int[2] { 1, 2 };
            jaggedA[1] = new int[2] { 101, 2 };
            //jaggedA[2] = new int[2] { 1, 2 }; /*error if tried !!!*/

            Console.WriteLine("\nWith syntax style:  jaggedA = new int[2][];\n");
            Console.WriteLine(jaggedA[1][0]);


            // The same array WITH NO DIMENSIONS SPECIFIED / size omitted use array initializer.
            /*Not what we are passing instead of  new int[2][]  */
            int[][] jaggedB = new int[][] {
              new int[2] { 1, 2 },
              new int[2] { 101, 2 },
            };
            Console.WriteLine("\nWith syntax style:  jaggedA = new int[][] and new int[2]{} ;\n");
            Console.WriteLine(jaggedB[1][0]);

            int[][] jaggedC = new int[][] {
              new int[] { 1, 2 }, /*Note here the size can be omitted too if you know the values beforehand*/
              new int[] { 101, 2 },
            };
            Console.WriteLine("\nWith syntax style:  jaggedA = new int[][] and new int[]{};\n");
            Console.WriteLine(jaggedC[1][0]);



        }

    }
}
