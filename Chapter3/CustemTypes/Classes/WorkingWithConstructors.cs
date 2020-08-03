using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    //note once there is a single CONSTRUCTOR with one parameter then default one never is there 
    internal class ClassForConstructorPurpose
    {
        private int _number;
        public ClassForConstructorPurpose(int number)
        {
            _number = number;
        }
        //public int Number { get { return _number; } }
        /*The next line is same as the previous one*/
        public int Number { get => _number; }
    }
    //The way how the constructor is being used here is also known as FACTORY INITIALIZER 
    internal class ClassWithPrivateConstructor
    {
        private static ClassWithPrivateConstructor _name;
        private string _state;
        private ClassWithPrivateConstructor(string s)
        {
            Console.WriteLine($"\nThe private constructor got the value: {s}");

            _state = s;
        }
        /// <summary>
        /// Note how the null coalescing is being used and pay extra attention to the extra Parentheses after the ??  
        /// </summary>
        /// <param name="state"></param>
        /// <returns></returns>
        public static ClassWithPrivateConstructor Name(string state) => _name ?? (_name = new ClassWithPrivateConstructor(state));
    }

    class ClassForConstructerInitializer
    {
        private string _description;
        private uint _nWheels;
        public ClassForConstructerInitializer(string description, uint nWheels)
        {
            _description = description;
            _nWheels = nWheels;
            Console.WriteLine("Received argument from the Constructor initializer: " + (description, nWheels));
        }
        /*when the parameter in the 2nd constructor receives the argument then the same value in that argument is passed to the constructor which was caused by the: this keyword!
        -	So, when calling as the following: ClassForConstructerInitializer("test") THEN ARGUMENT FOR THE DESCRIPTION IS SAME for the: (string description, uint nWheels)
        :this (description, 4) => ("test", 4) 
        */
        public ClassForConstructerInitializer(string description) : this(description, 4)
        {
        }

        public string TestConInitializer()
        {

            Console.WriteLine("Final result: " + (_description, _nWheels));
            return "";
        }
    }

    public class ClassWithStaticConstructor
    {
        public static int MyProperty { get; set; }
        static ClassWithStaticConstructor()
        {
            MyProperty = Test();
        }

        public static int Test() => 421;
    }

}
