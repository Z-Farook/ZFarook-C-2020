using Inheritance_Implementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
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
}

