using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

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

            #region For C# The array class
#if false
            DummyClass.MakeArrayUsingCreateInstance(5);
            DummyClass.MakeCustomArrayUsing();
            int[] initArr = { 1, 2, 3, 4, 5, 6 };
            DummyClass.CopyArrayUsingClone(initArr);
#endif
            #endregion

            #region For C# sorting with the Array class
#if false
            DummyClass.SortTest();

            /*Custom array sorting using an interface*/
            var planets = new Planet[] {
                new Planet("Jupiter", 101),
                new Planet("Mars", 191),
                new Planet("Earth", 101),
            };

            /**Sort using the CompareTo from the interface IComparable<PlaneT> */
            Array.Sort(planets);
            Console.WriteLine();
            foreach (var item in planets)
            {
                Console.WriteLine($"Sorted custom array based on names: {item.Name}");
            }
          
            Person[] persons =  new Person[] {
                new Person { FirstName="Damon", LastName="Hill" },
                new Person { FirstName="Niki", LastName="Lauda" },
                new Person { FirstName="Ayrton", LastName="Senna" },
                new Person { FirstName="Graham", LastName="Hill" }
             };

            Array.Sort(persons, new PersonComparsion(PersonCompareType.FirstName));

            foreach (Person p in persons)
            {
                Console.WriteLine(p);
            }

#endif
            #endregion


            Console.WriteLine();

        }
    }
}
