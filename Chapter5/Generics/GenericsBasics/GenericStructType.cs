using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericsBasics
{
    #region/*============================================ GENERIC STRUCTS Example of the built-in Nullable<T> =======================================================*/

    /**You can use the nullable without any class or struct here is a struct used due to restrictions from the namespace  */
    internal struct ATest
    {
        public static int? GetNullableType(int? x)
        {
            if (x == null)
            {
                Console.WriteLine("x2 is null");
            }
            else if (x < 0)
            {
                Console.WriteLine("x1 is smaller than 0");
            }
            else
            {
                Console.WriteLine("x is: " + x);
            }
            return x;
        }
    }
    #endregion

    #region/*============================================ GENERIC Methods=======================================================*/

    internal interface IAnimal
    {
        string Age { get; }
        int Height { get; }
        int CountSample(List<MethodPlaceHolder> smaple);
    }

    internal struct MethodPlaceHolder : IAnimal
    {
        /**simple demo */
        internal static void Swap<T>(ref T x, ref T y)
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine(temp);
        }

        /**Using the generic parameter The built-in types: interface IEnumerable<out T> */
        internal static void PrintAnimalSimple(IEnumerable<Animal> animals)
        {
            foreach (var item in animals)
            {
                Console.WriteLine($"Animal name: {item.Name} and color: {item.Color}");

            }
        }

        /**The PrintAnimalSimple method ONLY WORKS with ANIMAL type WHICH is of course LIMITING
         * So we modify the parameter to more TAnimal which make it more flexible and we can decided upon
         * the call what it should be like a car or boat*/
        public string Age { get; set; }
        public int Height { get; set; }
        public int CountSample(List<MethodPlaceHolder> samples) => samples.Count;
        internal static void PrintAnimal1<TAnimal>(IEnumerable<TAnimal> samples) where TAnimal : IAnimal
        {
            foreach (TAnimal sample in samples)
            {
                Console.WriteLine($"Age : {sample.Age}, Age : {sample.Height} ");
            }
            Console.WriteLine($"Total sample: {samples.Count()}");
        }

        /**The PrintAnimal1 is not good enough because it is restricting us too much with the where clause
         * we modify it more as the following*/
        internal static TtotalAnimal PrintAnimal2<TAnimal, TtotalAnimal>(IEnumerable<TAnimal> samples, Func<TAnimal, TtotalAnimal, TtotalAnimal> countLenght)
        {
            TtotalAnimal sum = default;
            foreach (TAnimal sample in samples)
            {
                sum = countLenght(sample, sum);
            }
            return sum;
        }
    }

    #endregion

    #region /*==========================================GENERIC Methods Specialization (overloading)=======================================================*/
#if true
    public class MethodSpecialisationePlaceHolder
    {

        public static void Test1(int x) => Console.WriteLine($"Type of the TTest1 (int x) is: {x.GetType().Name}\n");
        public static void Test2<T>(T x) => Console.WriteLine($"Type of the Test2<T>(T x)  is: {x.GetType().Name}\n");
        public static void Test3<T, T2>(T x, T2 y) => Console.WriteLine($"Type of the Test3<T, T2>(T x, T2 y) is: {x.GetType().Name}, { y.GetType().Name}\n");
        public static void Test4<T>(T x, int y) => Console.WriteLine($"Type of the Test4<T>(T x, int y)  is: {x.GetType().Name}, { y.GetType().Name}\n");
        public static void YourSurprise<T>(T x) => Test2(x);

    }
#endif
    #endregion

}

