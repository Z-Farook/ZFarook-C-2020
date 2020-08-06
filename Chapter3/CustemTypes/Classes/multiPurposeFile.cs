using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    //File purpose: PASSING PARAMETERS BY VALUE AND BY REFERENCE

    #region For C# PASSING PARAMETERS BY VALUE AND BY REFERENCE
#if true
    public struct ValueType
    {
        public int ThePropToBeNotChanged { get; set; }

        //would this change the value of the above property? no!!
        public int MethodWithValTypeRef(ValueType valTypeRef)
        {
            var res = valTypeRef.ThePropToBeNotChanged = 33;
            Console.WriteLine("\n" + ThePropToBeNotChanged);
            return res;
        }
    }

    /*if there is need for a value type property to be able to changed.Use the REF keyword*/
    public struct ValueType2
    {
        public int ThePropToBeNotChanged { get; set; }

        /*would this change the value of the above property? Yes since the struct is being
         * passed by reference *the keyword ref*/
        public int MethodWithValTypeRef(ref ValueType2 valTypeRef)
        {
            var res = valTypeRef.ThePropToBeNotChanged = 33;
            Console.WriteLine("\n" + ThePropToBeNotChanged);
            return res;
        }
    }

    public class RefType
    {
        public int ThePropToBeNotChanged { get; set; }

        //would this change the value of the above property
        public int MethodWithValTypeRef(RefType valTypeRef)
        {
            var res = valTypeRef.ThePropToBeNotChanged = 33;
            Console.WriteLine("\n" + ThePropToBeNotChanged);
            return res;
        }
    }

    public class UsingRefKeyWordWithClass
    {
        public string X { get; set; }

        public static UsingRefKeyWordWithClass ChangeA(UsingRefKeyWordWithClass a)
        {
            a.X = "The second value assigned to property: 2";
            /*Note the next line creating new object and upon returning the *a* the value will be lost GARBAGE COLLECTED
             * and the result will be that assigned at the line above*/
            a = new UsingRefKeyWordWithClass { X = "The 3rd value assigned to property: 3" };
            return a;
        }
    }

    public class UsingRefKeyWordWithClass2
    {
        public string X { get; set; }

        public static UsingRefKeyWordWithClass2 ChangeA(ref UsingRefKeyWordWithClass2 a)
        {
            a.X = "The second value assigned to property: 2";

            /*Now you will get the next value in the result, so in this case there is no loss. 
             * No garbage collection now thanks to the REF Keyword!*/
            a = new UsingRefKeyWordWithClass2 { X = "The 3rd value assigned to property: 3" };
            return a;
        }
    }
#endif
    #endregion

    #region For C# out Parameters
#if true
    internal static class ClassForOutParameters
    {
        public static void GetInputFromConsoleAndHandelNoException()
        {
            string input = Console.ReadLine();
            int result = int.Parse(input);
            Console.WriteLine($"result: {result}");
        }

        public static void GetInputAndHandelExceptionWithOut()
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int userInputToInt))
            {
                Console.WriteLine($"result: {userInputToInt}");
            }
            else { Console.WriteLine("You must type a number!"); GetInputAndHandelExceptionWithOut(); };
        }

        /*Not the TrParse returns Boolean and it is built method from dot itself*/
        public static void OutKewWordAdvancedUse(string consoleInput) => Console.WriteLine(
            int.TryParse(consoleInput, out int theParsedConsResult) ?
            $"you passed: {theParsedConsResult}" : $" gives us number not a string like: {consoleInput}");

        /*Note: out modifier allows returning values specified with the arguments*/
        public static float Divide(int x, int y, out int remainder)
        {
            remainder = x % y;
            return (float)x / y;
        }
    }
#endif
    #endregion

    #region For C# in parameters!
#if true
    /*The in modifier is mainly used with value types. However, you can use it with reference types as well.*/

    internal struct StructForInParameterTesting
    {
        public int MutableField;

        /*Define a method using the in keyword makes the field read-only*/
        public static void TestMethodForInPara(in StructForInParameterTesting param)
        {
            //param.MutableField = 69;// does not compile - read only variable
            Console.WriteLine(param.MutableField); //reading is allowed: that 12
        }
    }

    /* "in" is not very desired with class type (reference type) but here is an example!
     
     * When using the in modifier with reference types, you can change the content of the variable,BUT NOT THE VARIABLE ITSELF*/
    internal class ClassForInParameterTesting
    {
        public int MyProperty { get; set; }

        public static void TestMethodForInPara2(in ClassForInParameterTesting param)
        {
            //assignment allowed even the in keyword is used because we are using the reference type
            var m = param.MyProperty = 2;
            Console.WriteLine(m);
            //param = new ClassForInParameterTesting(); /*So,change the content of the variable,BUT NOT THE VARIABLE ITSELf*/
            return;
        }
    }

#endif
    #endregion

    #region For C# ENUM TYPES
#if true

    public enum KFCProduct
    {
        chicken,
        milkshake,
        cola,
    }
    /*Changing the default type from INT to SHORT*/
    public enum KFCProductWithIndexStartingAt1 : short
    {
        chicken = 1,
        milkshake = 2,
        cola = 3,
    }

    [Flags]
    public enum DaysOfWeek
    {
        /*        Monday,
                Tuesday,
                Wednesday,
                Thursday,
                Friday,
                Saturday,
                Sunday,
                Weekend = Saturday | Sunday,
                Workday,
                AllWeek = Workday | Weekend*/
        Monday = 0x1,
        Tuesday = 0x2,
        Wednesday = 0x4,
        Thursday = 0x8,
        Friday = 0x10,
        Saturday = 0x20,
        Sunday = 0x40,
        Weekend = Saturday | Sunday,
        Workday = 0x1f,
        AllWeek = Workday | Weekend
    }

    [Flags]
    public enum SingleHue : short
    {
        None = 0,
        Black = 1,
        Red = 2,
        Green = 4,
        Blue = 8
    };

#endif
    #endregion

    #region For C# Partial types/Classes
#if true

    internal partial class ClassWithPartialKeyWord
    {
        public void MethodOne() { Console.WriteLine("I am the method ONE from the partial class"); }
    }

    internal partial class ClassWithPartialFuncion
    {
        //partial method is called.
        public static void HelperForPartialMCall() => TPartialMethod(); 
        
        /*Note when there is no implementation of this method the compiler omits the invocation 
         *and when the is body defined for this method in any file then it goes to fire that one*/
        static partial void TPartialMethod();

    }

   internal static partial class csharp
    {
        static partial void Show();

        public static void disp()
        {
            //partial method is called.
            Show();
        }
    }


#endif
    #endregion

}
