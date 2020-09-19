using System;
using System.Buffers;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfArrays
{
    internal class PoolHolder
    {
        public static void CreatArrayPoolTest()
        {
            /*Making your own pool INSTEAD OF GETTING a predefined shared pool using the shared prop of the class ArrayPool<T> */
            ArrayPool<int> customPool = ArrayPool<int>.Create(maxArrayLength: 400, maxArraysPerBucket: 10);

            for (int i = 0; i < 5; i++)
            {
                /*Random math for our length for the array to be MADE WITH RENT method*/
                var lenRequesut = (int)(Math.Pow(i, 5));

                /*The Rent method returns an array with at least the requested number of elements.*/
                var /*var == int[]*/ arr = customPool.Rent(lenRequesut);

                Console.WriteLine($" Requested array with Length = {lenRequesut} via Rent method and received with length = {arr.Length}  ");

            }
            Console.WriteLine();
        }
        public static void ArrayPoolUsinSharedProp()
        {

            for (int i = 5; i < 10; i++)
            {
                int arrayLength = (int)(Math.Pow(i, 5));

                /*A predefined shared pool by accessing the Shared property of the ArrayPool<T> class*/
                int[] arr = ArrayPool<int>.Shared.Rent(arrayLength);

                Console.WriteLine($" Requested array with Length =  {arrayLength} and received with length = {arr.Length}");

                /*After you no longer need the array, you can return it to the pool. After the array is returned,
                 * you can later reuse it by another rent.*/
                ArrayPool<int>.Shared.Return(arr, clearArray: true);
            }
            Console.WriteLine();
        }
    }
}

