using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BasicsOfArrays
{
    class Program
    {
        static void Main(string[] argsm)
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

            #region For C# Enumerators
#if false
            var arr = new int[] { 1, 2, 3, 4, 5, 6 };
            var mgh = new TheMigicHolder(arr);
            Console.WriteLine("// The default IEnumerator type with foreach statement");

            foreach (var item in mgh)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine("\n");

            var compilerMagic = new EnumeratorsPalceHolder();
            Console.WriteLine("//  Compiler generated a *yield type* behind the scene and give us:");
            foreach (var item in compilerMagic)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n\n//The NOT default IEnumerator type with foreach statement");
            foreach (var item in mgh.Not_Default_Iterator_For_ForEach())
            {
                Console.Write(item + ", ");

            }
#endif
            #endregion

            #region For C# STRUCTURAL COMPARISON 
#if false
            //using IStructuralEquatable for comparison of content in objects

            var cir = new Circle() { Diameter = 10, Radius = 20 };
            Circle[] cir1 = { new Circle() { Diameter = 30, Radius = 40 }, cir };
            Circle[] cir2 = { new Circle() { Diameter = 30, Radius = 40 }, cir };

            //This Equal is an overload of the obejct.Equals and it is comparing the references
            if (cir1 == cir2)
                Console.WriteLine("The same reference");
            else
                Console.WriteLine("The reference cir1 == cir2 wasn't same ");

            //this Equal is from the obejct.Equals it is overridden but still behaves same as the base
            if (!cir1.Equals(cir2))
                Console.WriteLine("*!cir1.Equals(cir2)* returns false because not the same reference\n");

            /* This, Equal, is from the interface IStructuralEquatable.Equals! Which is implemented through the EqualityComparer<Circle> class (below in the if statement)
             * by implementing the Equal of IEquatable<T> interface which we have done ourself.
             * Notice we have converted the person1 array to IStructuralEquatable type using the as operator */

            if ((cir1 as IStructuralEquatable).Equals(cir2, EqualityComparer<Circle>.Default))
            {
                Console.WriteLine("The content of cir1 and cir2 was same");
            }

            //using IEqualityComparer<T> directly for comparison of content in objects
            var r1 = new Rectangle2() { Heigth = 1, Width = 2 };
            var r2 = new Rectangle2() { Heigth = 1, Width = 2 };
            var arr2 = new Rectangle2[] { r1, r2 };
            Console.Write($"The ids made and incremented by 1 automatically result => ");
            foreach (var item in arr2)
            {
                Console.Write($" {item.Id} ,");
            }
            Console.WriteLine("\n");
            Console.WriteLine($"Comparing only the reference results in => {r1.Equals(r2)}");
            var comparer = new RectangleComparer();
            Console.WriteLine($"Comparing the content reference results in => {comparer.Equals(r1, r2)}");
            Console.WriteLine($"Get some hashcode for r1 => {comparer.GetHashCode(r1)}");
            Console.WriteLine($"Get some hashcode for r2 => {comparer.GetHashCode(r2)}\n");
#endif
            #endregion

            #region For C# Span<T>s
#if false
            SpanExperimentHolder.CreateSpane();
            SpanExperimentHolder.MakeSliceOfArr();
            SpanExperimentHolder.ChangeArrValWithoutIndexer();
            SpanExperimentHolder.MakeReadOnlySpan();
#endif
            #endregion

            Console.WriteLine("\n");
        }
    }
}
