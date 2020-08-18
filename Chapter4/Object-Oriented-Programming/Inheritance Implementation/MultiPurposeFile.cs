using Inheritance_Implementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Globalization;
using System.Security;
using System.Text;

namespace Inheritance_Implementation
{

    #region For C# basic inheritance
#if true

    public class Species
    {
        public string FName { get; set; }
        public string LName { get; set; }
        protected void PrintSpeciesName(Species obj) => Console.WriteLine($"First name:{obj.FName} , Last name: {obj.LName}");

    }

    public class Human : Species
    {
        public Human(string fn, string ln)
        {
            HName = new Species { FName = fn, LName = ln };
        }

        public Species HName { get; }

        public void PrintHumanName() => PrintSpeciesName(HName);
    }

#endif
    #endregion

    #region For C# HIDING a method
#if true
    public class BaseA
    {
        public static void TestA(int x)
        {
            Console.WriteLine(x);
        }
    }
    public class ClassHidingTheMethod : BaseA
    {
        /*Now this method is hiding the method in the base class, BECAUSE IT HAS THE SAME SIGNATURE 
         *to overcome this problem use the NEW keyword in the beginning of the method. like: new public static void TestA(int x){} */
#pragma warning disable
        public static void TestA(int x)
        {
            Console.WriteLine($"X is : {x}");
        }
#pragma warning restore
    }
    public class ClassNotHidingTheMethod : BaseA
    {
        new public static void TestA(int x)
        {
            Console.WriteLine(x);
        }
    }
#endif
    #endregion

    #region For C# CALLING METHOD from the BASE CLASS
#if true

    public class BaseB
    {
        public virtual string TestD()
        {
            Console.WriteLine("I the base the method from the base class");
            return "";
        }
    }
    public class ChildOfB : BaseB
    {
        public void PrintBaseMethod()
        {
            Console.WriteLine("Calling base method, res:\n");
            Console.WriteLine(base.TestD());
        }
    }
#endif
    #endregion

    #region For C# ABSTRACT classes and methods
#if true

    public abstract class BasePiza
    {
        /*we can have the default value with the prop initializer syntax or trough the constructor using the :base with the derived constructor */
        public double FlourInKgs { get; } = .12;
        public double TomatoInKgs { get; } = .12;
        public double CheeseInKgs { get; } = .12;
        public double OnionsInKgs { get; } = .12;

        //protected BasePiza(double flourInKgs, double tomatoInKgs, double cheeseInKgs, double onionsInKgs)
        //{
        //    FlourInKgs = flourInKgs;
        //    TomatoInKgs = tomatoInKgs;
        //    CheeseInKgs = cheeseInKgs;
        //    OnionsInKgs = onionsInKgs;
        //}

        public abstract void PrintIngredient(object x);
    }

    public class PizaTuna : BasePiza
    {
        //public PizaTuna(double flourInKgs, double tomatoInKgs, double cheeseInKgs, double onionsInKgs) : base(flourInKgs, tomatoInKgs, cheeseInKgs, onionsInKgs)
        //{
        //}


        public override void PrintIngredient(object x)
        {
            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(x))
            {
                string name = descriptor.Name;
                dynamic value = descriptor.GetValue(x);
                Console.WriteLine("{0} = {1}", name, value);
            }
        }
    }

#endif
    #endregion

    #region For C# SEALING the Classes and methods
#if true

    public sealed class TheUnDerivable
    {
        public void test() => Console.WriteLine("No, free work from me go and get it yourself!!");
    }

#if false
   // this Derived class can;t inherit BaseClass because it is sealed  
       public class TryingToDoTheUndoable : TheUnDerivable
    {
        //some coding here
    }
#endif


#endif

    #endregion

    #region For C# The SEALING a method
#if true

    public class TheBaseWithMethodToSeal
    {
        public virtual void test() => Console.WriteLine("No, I help only one class and not the whole world!!");
    }

    public class TheMethodSealingClass : TheBaseWithMethodToSeal
    {
        public sealed override void test()
        {
            Console.WriteLine("I am sealed now and ANYTHING DERIVING me cANNOT CHANGE MY STUFF. I am the boss from now");
        }
    }

#if false
    //to see the error turn the false to true on the line above!
    public class MyClass : TheMethodSealingClass
    {
        public override void test()
        {
            Console.WriteLine("I am sealed now an");
        }
    }
#endif
#endif
    #endregion

    #region Constructors of Derived Classes
#if true
    /* This class will contain SELF-WRITTEN CONSTRUCTOR THUS WHEN INHERITING this class any where WE MUST CALL THE CONSTRUCTOR of this class 
     * explicItly*/
    public class Person
    {
        public string Fname { get; private set; }
        public string Lname { get; private set; }

        public Person(string fname, string lname)
        {
            Fname = fname;
            Lname = lname;
        }

        public void Fullname(TheClassThatNeedsToCallTheBaseConstrutor obj) => Console.WriteLine($"Fname: {Fname}\nLname: {Lname}\nNationality: {obj.Nationality} ");
    }

    public class TheClassThatNeedsToCallTheBaseConstrutor : Person
    {
        public string Nationality { get; private set; }

        /** Note how the base constructor is being called */
        public TheClassThatNeedsToCallTheBaseConstrutor(string sName, string lName, string nationality) : base(sName, lName)
        {
            Nationality = nationality;
        }

        public Person personX { get; }
    }

    /**Now if try the flowing--not passing the base args to the base constructor when the base is inherited, it will give an error*/
#if false
    public class TestBaseConstrutor : Person
    {
        public int MyProperty { get; set; }

        public TestBaseConstrutor(int myProperty)
        {
            MyProperty = myProperty;
        }
    }
#endif
#endif
    #endregion

}


