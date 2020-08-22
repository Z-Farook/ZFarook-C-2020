using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsBasics
{

    #region/*============================================Using null value in generic types===========================================*/
    public class ClassGenericWithNullValue<Tx>
    {
        /**In generics it is NOT POSSIBLE TO ASSIGN NULL TO GENERIC TYPES. That’s BECAUSE a generic type can also be instantiated as a value type */

        //T assignNull = null; /*This is not allowed*/

        Tx assignNull = default; /*This is now assigned to null */
        public Tx SetThedefaultVar(Tx x) => assignNull = x;
    }
    #endregion

    #region/*============================================ Generic INHERITANCE=======================================================*/

    public class Base<Tx> : IShowText
    {
        public Tx X { get; set; }

        public string PrintStuff()
        {
            throw new NotImplementedException();
        }
    }
    /**Note now the DERIVED CLASS will determine the type of Base too!! Using the type parameter <T>*/
    public class Derived<T> : Base<T>
    {
        public T Y { get; set; }
    }

    public class DerivedWithDifferentBaseType<Ty, Tx> : ClassGenericWithNullValue<Tx>
    {
        public Ty PropInDerived { get; set; }
    }
    #endregion

    #region/*============================================ Generic CONSTRAINTS=======================================================*/
    public interface IShowText
    {
        public string PrintStuff();

    }

    public class TheGreatWork<T, TIx> where TIx : IShowText
    {
        public string PrintStuff() => "I am the implementation of the PrintStuff signature method defined in the interface!!!";
    }

    /**Note this class has TYPE PARAMETER <T> and is CONSTRAINED with MUST HAVE IMPLEMENTATION OF an interface (IShowText)
     * So, an INSTANCE of this class will be ONLY ALLOWED WHEN a TYPE ARGUMENT is OF TYPE THAT IMPLEMENT the IShowText interface*/
    public class ConstrainStuff<T1, TIx> : TheGreatWork<T1, TIx> where TIx : IShowText
    {
        public void WonderLandString(ConstrainStuff<T1, TIx> obj) => Console.WriteLine(
            $"The class: GenericClassWithInterFaceConstrain is to be only instantiated if the " +
            $"type argument was implementing IShowText. So, it did and you can see the result of the interface method here:\n" +
            $"{obj.PrintStuff()}\n"
            );

        public void R(ConstrainStuff<T1, TIx> obj)
        {
            Console.WriteLine("test: " + obj.GetHashCode());
        }
    }

    public class TheHardWay
    {
        public static int x = 13;
    }
    /**Note THERE ARE NUMBER OF CONSTRAINS that can be used here IS ONLY JUST the demonstration of ONE--THE ONE FOR THE INTERFACES*/
    #endregion

    #region /*============================================ Generic's partial specialization=======================================================*/
    public class Book<TName, TPage>
    {
        public TName BName { get; set; }
        public TPage Bpage { get; set; }
    }

    public class EnglisBook<T> : Book<string, T>
    {
        public void PrintBookInfo(EnglisBook<T> book)
        {
            Console.WriteLine($"BookName: {book.BName} , BookPage {book.Bpage}");
        }
    }
    #endregion

    #region/*============================================ Generic's Static Members=======================================================*/




    #endregion
}