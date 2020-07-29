using System;
using System.Security;

namespace Classes
{
    class Program
    {
#pragma warning disable
        static void Main(string[] args)
        {
            Action<object> write = Console.WriteLine;
            write("");
            #region For C# classes and Struct
#if true
            /*Instantiating a object*/
            ClassesIntroduction person = new ClassesIntroduction();
            /*Accessing the fields of a class */
            person.FirstName = "Zahid";
            person.LastName = "Farook";
            write((person.FirstName, person.LastName));

            ClassesIntroduction person1 = new ClassesIntroduction();
            /*Accessing the fields of a class */
            person1.FirstName = "John";
            person1.LastName = "Doe";
            write(person1.LastName);
            write("");

            /*Get the constant filed from cLASS*/
            var personMode = ClassesIntroduction.LearningMode;

            PersonPhone pNumber1 = new PersonPhone(12453, "Belgium");
            write(PersonPhone.test(pNumber1));
            write("");

            PersonPhone2 pNumber2 = new PersonPhone2();
            var country = pNumber2._country = "NL";
            var pnum = pNumber2._phoneNumber = 123;
            /*Get the constant filed from STRUCT*/
            var lMode = PersonPhone2.LearningMode;
            var res = PersonPhone2.CountryAndPhone(country, pnum, lMode );
#endif
            #endregion

            write("");
        }
    }
}
