using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace BasicsOfArrays
{
    internal class DummyClass
    {
        public static void MakeArrayUsingCreateInstance(int length)
        {
            Array arr = Array.CreateInstance(typeof(object), length);
            Console.WriteLine($"The type of the array is: {arr.GetType().Name}");
            for (int i = 0; i < length; i++)
            {
                arr.SetValue(i + 1, i);
                Console.WriteLine(arr.GetValue(i));
            }
        }
        public static void MakeCustomArrayUsing()
        {
            var arr = Array.CreateInstance(typeof(TestClassForCreateInstance), 3);

            #region question start here 
            /* how can this be done with for loop without overriding the previous instance?
             * so instead of using 0, 1 ,2 as the second argument for SetValue method  */

            arr.SetValue(new TestClassForCreateInstance(12, 13), 0);
            arr.SetValue(new TestClassForCreateInstance(102, 103), 1);
            arr.SetValue(new TestClassForCreateInstance(202, 203), 2);

            #endregion question 

            var data = (TestClassForCreateInstance[])arr;
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine($"At index {i} properties:\n A = {data[i].A}\n" +
                    $" B = {data[i].B}");
            }
        }
        public static void CopyArrayUsingClone(int[] arr)
        {
            var copied = (int[])arr.Clone();
            Console.WriteLine($"The type of the array is: {arr.GetType().Name} and copied content is:");
            for (int i = 0; i < copied.Length; i++)
            {
                Console.WriteLine(copied.GetValue(i));
            }
            Console.WriteLine();
        }
        public static void SortTest()
        {
            int[] arr = { 5, 4, 3, 2, 1, };
            Array.Sort(arr);
            Console.WriteLine("Sorted array:");
            foreach (var item in arr)
            {
                Console.Write(item + " ");

            }
        }

    }
    public class TestClassForCreateInstance
    {
        public int A { get; private set; }
        public int B { get; private set; }
        public TestClassForCreateInstance(int a, int b)
        {
            A = a;
            B = b;
        }
    }
    internal class Planet : IComparable<Planet>
    {
        public Planet(string name, int radius)
        {
            Name = name;
            Radius = radius;
        }

        public string Name { get; private set; }
        public int Radius { get; private set; }
        public int CompareTo([AllowNull] Planet other)
        {
            if (other == null) throw new ArgumentNullException("other");
            /**This will pick the element at index 0 and compare with reset of the elements till the last index and then picks the
             * element at index  0 + 1 (till the last one index) and does the same thing for as the 0*/
            int result = Radius.CompareTo(other.Radius);
            if (result == 0)
            {
                result = Name.CompareTo(other.Name);
            }
            return result;
        }
    }
    public enum PersonCompareType
    {
        FirstName,
        LastName
    }

    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public override string ToString() => $"{FirstName} {LastName}";

    }
    public class PersonComparsion : IComparer<Person>
    {
        private PersonCompareType _compareType;

        public PersonComparsion(PersonCompareType compareType) => _compareType = compareType;

        #region IComparer<Person> Members
        public int Compare(Person x, Person y)
        {
            if (x is null && y is null) return 0;
            if (x is null) return 1;
            if (y is null) return -1;

            switch (_compareType)
            {
                case PersonCompareType.FirstName:
                    return x.FirstName.CompareTo(y.FirstName);
                case PersonCompareType.LastName:
                    return x.LastName.CompareTo(y.LastName);
                default:
                    throw new ArgumentException("unexpected compare type");
            }
        }

        #endregion
    }
}
