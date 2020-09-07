using System;
using System.ComponentModel;

namespace BasicsOfArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            #region For C# Arrays
#if false
            ArrayHolder ah = new ArrayHolder();
            ArrayHolder.SingleDimArrayMaking();
            ArrayHolder.DoubleDimArrayMaking();
            ArrayHolder.ThreeDimArrayMaking();
            ArrayHolder.TheJaggedArrayMaking();
            var customTypeArray = new ArrayHolder[2];
            customTypeArray[0] = new ArrayHolder { TestA = 505, TestB = 606 };
            customTypeArray[1] = new ArrayHolder { TestA = 406, TestB = 706 };

            Console.WriteLine($"Total custom arrays { customTypeArray.Length}");

            for (int i = 0; i < customTypeArray.Length; i++)
            {
                Console.WriteLine($"Array {i} on index customTypeArray[{i}] have props:\n customTypeArray[{i}] prop: {customTypeArray[i].GetType().GetProperties()[i].Name} value is: " +
                    $"{customTypeArray[i].TestA}; {customTypeArray[i].GetType().GetProperties()[i].Name} {customTypeArray[i].TestB};\n");
            }
#endif
            #endregion


            Console.WriteLine();

        }
    }
}
