using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    internal class AnonymousTypesAndMethods
    {
        public string FName { get; set; }
        public string MName { get; set; }
        public string LName { get; set; }
    }
    internal class WorkingWithMethod
    {
        public int MyProperty { get; set; }
        public int MyProperty2 { get; set; }

        public void MethodOne(WorkingWithMethod wm)
        {
            wm.MyProperty = 101;
            Console.WriteLine("MyProperty1: " + wm.MyProperty);
        }
        public void ExpressionBodiedMethod(WorkingWithMethod wm, int x) => Console.WriteLine("MyProperty2: " + (wm.MyProperty2 = x).ToString());
    }
    
    //Note this class contains multiple things for different topics
    internal class MethodOverloding
    {
        public static void MLoadingOne()
        {
            Console.WriteLine("No parameter in this method");
        }

        public static void MLoadingTwo(int n)
        {
            Console.WriteLine("This method contains one parameter: " + n);
        }
        public static void MLoadingThree(int g, int q)
        {
            Console.WriteLine("This method contains two parameter: " + g + " and: " + q);
        }

        public static void MForNamedArgInvocation(int l, int m)
        {

            Console.WriteLine($"L is : {l} and M is: {m}");
        }

        public static void MWithOptionalParameter(int u , int t =2 )
        {

            Console.WriteLine($"Square of u: {u} and t: {t} is: {u* t}");
        }
    }

}
