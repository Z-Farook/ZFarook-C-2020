using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Classes
{
    internal class ClassesIntroduction
    {
#pragma warning  disable
        /*Fields*/
        public const string LearningMode = "Happy mode!";

        /*Properties; they are kind of methods and this is the special syntax for getter and setter
        we can also define getter and setter by ourself!
        */
        public string FirstName { get; set; }
        public string LastName { get; set; }

        /*Custom getter and setter example*/
        private int myVar;
        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public ClassesIntroduction()
        {
        }

        public ClassesIntroduction(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }

    internal struct PersonPhone
    {
        private int _phoneNumber;
        private string _country;

        public PersonPhone(int phoneNumber, string country)
        {
            _phoneNumber = phoneNumber;
            _country = country;
        }

        public static object test(PersonPhone personPhone)
        {
            return $"Person 1:\n {personPhone._country}  {personPhone._phoneNumber}";
        }
    }

    internal struct PersonPhone2
    {
        public const string LearningMode = "Happy mode!";
        public string _country { get; set; }
        public int _phoneNumber { get; set; }

        public static Func<object, object, object, object> CountryAndPhone = (object contry, object pnum, object lMode) =>
        {
            var res = $"Person 2:\n{contry} {pnum} {lMode}";
            Console.WriteLine(res);
            return res;
        };
    }

    internal class ClassWithReadOnlyFields
    {
        private static readonly string _theReadOnlyField; /*Note here are to keywords: static, readonly */
        private readonly int _creationTime; 

#if false
        public void SetReadOnlyField(string value )
        {
        //this does not works because read-only properties can’t be assigned outside the constructors:
            _theReadOnlyField = value;
        }
#endif
        //this is allowed as the comment above already made clear what is accepted
        //Not the static constructor must be a parameterless one
        static ClassWithReadOnlyFields()
        {
            /*note this stays the same for all the instances of this type BECAUSE its of TYPE static
            if we remove that type we will also need to pass an object ref in order to assign a value*/
            _theReadOnlyField += "12";
        }

        public  ClassWithReadOnlyFields(int valueX)
        {
            // Initialize a read-only instance field
            _creationTime = valueX;
        }

        //this gives the value assigned by the static constructor above
        public static void getTheReadOnlyField()
        {
            Console.WriteLine($"\nThe 1st constructor assigned: {_theReadOnlyField}");
        }

        //this gives the value assigned by the constructor above with one argument
        public static void TheReadOnlyFieldDefinedTroughConstructor(ClassWithReadOnlyFields objX)
        {
            Console.WriteLine($"\nThe 2nd constructor assigned: {objX._creationTime}");
        }
    }
}
