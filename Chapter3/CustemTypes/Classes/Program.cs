using System;
using System.Numerics;

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
#if false
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
            var res = PersonPhone2.CountryAndPhone(country, pnum, lMode);

            /*Makes the static constructor execute */
            ClassWithReadOnlyFields.getTheReadOnlyField();

            /*This calls the constructor with one parameter*/
            ClassWithReadOnlyFields classWithReadOnlyFields = new ClassWithReadOnlyFields(500);
            /*printing the value of the assignment above*/
            ClassWithReadOnlyFields.TheReadOnlyFieldDefinedTroughConstructor(classWithReadOnlyFields);
#endif
            #endregion

            #region For working with C Sharp class properties 
#if false
            Properties myP = new Properties();
            myP.PlaneName = "PIA";
            myP.TicketPrice = 120;
            myP.PlaneName2 = "KLM";
            myP.TicketPrice2 = 110;
            /*print trough getter what is assigned*/
            var res = myP.PlaneName;
            var res2 = myP.PlaneName2;

            var exBodiedP = new ExpressionBodiedProps();
            exBodiedP.X = 4;
            exBodiedP.Y = 4;
            write(("Expression bodied props: ", exBodiedP.X, exBodiedP.Y));

            var autoImProp = new AutoImplimentedProps();
            autoImProp.Name = "Zahid";
            autoImProp.LName = "Farook";
            write(autoImProp.Name);
            /*get the value of property initializer */
            write(autoImProp.AuotPropInitializer);

            PropertyAccessLevel x = new PropertyAccessLevel(12);
            MakeReadOnlyOmitingTheSetter makeReadOnly = new MakeReadOnlyOmitingTheSetter("Good day");
            write(makeReadOnly.J);
            ExplicitReadOnlyPropTroughConstructor explicitReadOnlyProp = new ExplicitReadOnlyPropTroughConstructor(45);
            //explicitReadOnlyProp.ID = 12; /*This will give an error since the prop is made read only*/

            Person person = new Person("Zahid", "FARook");
           // person.FirstName = ""; /*You can't do that since you are working with read only fields and they can only be assigned trough constructor*/
            write(person.FullName);
#endif
            #endregion

            #region For C# Anonymous types
#if false
            var john = new
            {
                Age = 68,
                height = 4.5,
                weight = 50
            };
            //john.Age = 65; /*Note here the value cannot be assigned since the anonymous types are read only */
            write(john.Age);

            //making an anonymous type using the props of an already existing object
            AnonymousTypesAndMethods singer = new AnonymousTypesAndMethods();
            var dName = "A";
            singer.FName = dName;

            var dancer = new
            {
                /*Note here the value cannot be assigned since the anonymous types are read only */
                singer.FName,
                singer.MName,
                singer.LName,
            };
            write(dancer.FName);
            var m1 = new WorkingWithMethod();
            m1.MethodOne(m1);
            m1.ExpressionBodiedMethod(m1, 10);

#endif

            #region For C# method overloading and invocation
#if true
            //MethodOverloding.MLoadingOne();
            //MethodOverloding.MLoadingTwo(1);
            //MethodOverloding.MLoadingThree(12, 23);
            ///*This will be assigned as the parameters are defined in the function so: l= 2 m12*/
            //MethodOverloding.MForNamedArgInvocation(2, 12);

            ///*This will be HOWEVER ALSO ASSIGNED AS THE PARAMETERS are defined in the function
            //  so regardless the order given here: m: 2, l: 12*/
            //MethodOverloding.MForNamedArgInvocation(m: 2, l: 12);
            ///*non-trailing named arguments are only allowed when the name and the position 
            // * result in finding the same corresponding parameter. In other words if we omit the name of some parameters then
            // the ORDER IN THE INVOCATION MUST MATCH WITH THAT OF ORIGINAL FOUND IN THE DEFINITION of the method*/
            //MethodOverloding.MForNamedArgInvocation(l: 32, 113);

            MethodOverloding.MWithOptionalParameter(2, 3);
            MethodOverloding.MWithOptionalParameter(4);




#endif
            #endregion

            #endregion

            write("");
        }
    }
}
