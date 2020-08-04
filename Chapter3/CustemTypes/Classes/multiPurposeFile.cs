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
            $"you passed: {consoleInput}" : $" gives us number not a string like: {consoleInput}");
    }




#endif
    #endregion


}
