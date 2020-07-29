using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    internal class ClassesIntroduction
    {
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
}
