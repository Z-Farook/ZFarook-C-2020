using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace BasicsOfArrays
{
    public class SpanExperimentHolder
    {
        public static Span<int> CreateSpane()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine($"Original arr[0] value  is = {arr[0]}");
            var spanArr = new Span<int>(arr);
            var changeArr = spanArr[0] = 100;
            Console.WriteLine($"Changed arr using span spanArr[0] value  is = {arr[0]}");
            Console.WriteLine();
            return spanArr;
        }

        public static Span<int> MakeSliceOfArr()
        {
            //casting the span to int[]
            int[] myArr = CreateSpane().ToArray();
            myArr[0] = 13;
            myArr[1] = 22;
            myArr[myArr.Length - 1] = 33;
            Console.WriteLine($"//slice with constructor, myArr length= {myArr.Length }");
            var newArr1 = new Span<int>(array: myArr, start: 0, length: myArr.Length);
            foreach (var item in newArr1)
            {
                Console.WriteLine(item + ",");
            }
            Console.WriteLine($"//slice with span<T>.Slice, newArr1 length= {newArr1.Length }");
            var newArr2 = newArr1.Slice(start: 1, newArr1.Length - 1);
            foreach (var item in newArr2)
            {
                Console.WriteLine(item + ",");

            }
            Console.WriteLine();
            return newArr1;
        }
        public static void ChangeArrValWithoutIndexer()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 11, 12, 14, 15, 16 };

            var span1 = new Span<int>(arr);
            var span2 = new Span<int>(array: arr2, start: 0, length: arr.Length);

            Console.WriteLine($"Length span1 = {span1.Length}, span2 {span2.Length}");

            span1.Clear();
            Console.WriteLine("// After span1.CLear() values are: \n");
            foreach (var item in span1)
            {
                Console.Write($" {item},");
            }

            Console.WriteLine("\n");
            Console.WriteLine("//After filling the span1 with span2: span1.CopyTo(span2) values are: \n");

            span2.CopyTo(span1);

            foreach (var item in span1)
            {
                Console.Write($" {item},");
            }

            Console.WriteLine("\n");
            Console.WriteLine("//After filling the span1 with using span1.Fill() values are: \n");

            span1.Fill(101);
            foreach (var item in span1)
            {
                Console.Write($" {item},");
            }
        }

        public static void MakeReadOnlySpan()
        {
            var myNormalSPan = CreateSpane().ToArray();
            var spanROnly = new ReadOnlySpan<int>(myNormalSPan);
#if false
            /*SO, the read only does not allow the following.*/
            spanROnly[0] = 12;
            spanROnly.Clear();
#endif
            foreach (var item in spanROnly)
            {
                Console.WriteLine($"spanROnly: {item}");
            }
            Console.WriteLine();
        }
    }
}
