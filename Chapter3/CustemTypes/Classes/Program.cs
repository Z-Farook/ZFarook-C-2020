using System;
using System.Numerics;
using System.Runtime.CompilerServices;

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
            #endregion

            #region For C# method overloading and invocation
#if false
            MethodOverloding.MLoadingOne();
            MethodOverloding.MLoadingTwo(1);
            MethodOverloding.MLoadingThree(12, 23);

            /*This will be assigned as the parameters are defined in the function so: l= 2 m12*/
            MethodOverloding.MForNamedArgInvocation(2, 12);

            /*This will be HOWEVER ALSO ASSIGNED AS THE PARAMETERS are defined in the function
              so regardless the order given here: m: 2, l: 12*/
            MethodOverloding.MForNamedArgInvocation(m: 2, l: 12);

            /*non-trailing named arguments are only allowed when the name and the position 
              result in finding the same corresponding parameter.In other words if we omit the name of some parameters then
              the ORDER IN THE INVOCATION MUST MATCH WITH THAT OF ORIGINAL FOUND IN THE DEFINITION of the method */
            MethodOverloding.MForNamedArgInvocation(l: 32, 113);

            MethodOverloding.MWithOptionalParameter(2, 3);
            MethodOverloding.MWithOptionalParameter(4);

            /*The best time to use the NAMED ARGUMENT is when the optional are being passed*/
            MethodOverloding.MWihtMultipleOptionalParams(w: 12, q: 8);
            MethodOverloding.MUsingOptinalPatametersWithKeyWord(8, 9, 10, "TEst");
#endif
            #endregion

            #region For C# Constructors
#if false
            var con = new ClassForConstructorPurpose(50);
            write(con.Number);
            ClassWithPrivateConstructor.Name("The initialization with private constructor");

            var ConInitializer = new ClassForConstructerInitializer("Proton Persona");
            var res = ConInitializer.TestConInitializer();

            /*Remember!, static constructor does not have any access modifiers and It’s never called explicitly*/
            write(ClassWithStaticConstructor.MyProperty);
    
#endif
            #endregion

            #region For C# Struct
#if false
            var sc = new School("Hr", "Rotterdam");
            sc.GetSchoolAndCity();
            /*To avoid some performance issue we can use the REF keyword when passing an struct to an function*/
            sc.GetSchoolAndCity(ref sc);
            ReadOnlyStruct rds = new ReadOnlyStruct(true, true);
            rds.CanWeUndoTheRain();
            ExampleTypeRefStruct refStruct = new ExampleTypeRefStruct(12);
            refStruct.TheBarkingDog();
            write(refStruct.MyProperty);
            sc = refStruct;/*this cannot be done since refStruct lives on stack and this assignment is on the heap*/
            refStruct.ToString(); this cannot be done either
#endif
            #endregion

            #region For C# PASSING PARAMETERS BY VALUE AND BY REFERENCE
#if false
            ValueType vType = new ValueType { ThePropToBeNotChanged = 1 };
            var res = vType.MethodWithValTypeRef(vType);
            /*Check if the property got the value changed*/
            if (vType.ThePropToBeNotChanged == res)
                write("Yes, the prop was changed!");
            else write("No, the vType.ThePropToBeNotChanged wasn't changed");

            /*Using the ref keyword within struct type*/
            ValueType2 vType2 = new ValueType2 { ThePropToBeNotChanged = 1 };
            var res2 = vType2.MethodWithValTypeRef(ref vType2);
            /*Check if the property got the value changed*/
            if (vType2.ThePropToBeNotChanged == res2)
                write("Yes, the prop was changed *even* it was a value type! You got thank to the REF KEWORD");
            else write("No, the vType.ThePropToBeNotChanged wasn't changed");

            RefType refType = new RefType { ThePropToBeNotChanged = 11 };
            var res3 = refType.MethodWithValTypeRef(refType);
            /*Check if the property got the value changed*/
            if (refType.ThePropToBeNotChanged == res)
                write("Yes, the refType.ThePropToBeNotChanged was changed!");
            else write("No, the ThePropToBeNotChanged wasn't changed");

            /*Without ref keyword, when not careful the can be data loss. The garbage collection in this case*/
            var refWithinClass = new UsingRefKeyWordWithClass { X = "The initial value is: 1" };
            UsingRefKeyWordWithClass.ChangeA(refWithinClass);
            write(refWithinClass.X);

            /*Using REF keyword within class type TO AVOID the garbage collection in this case*/
            var refWithinClass2 = new UsingRefKeyWordWithClass2 { X = "The initial value is: 1" };
            UsingRefKeyWordWithClass2.ChangeA(ref refWithinClass2); /*Note the use of ref*/
            write(refWithinClass2.X);



#endif
            #endregion

            #region For C# Out keyword
#if false
            /*This will not do the work if the use will pass a string instead of int*/
            //ClassForOutParameters.GetInputFromConsoleAndHandelNoException();
            //ClassForOutParameters.GetInputAndHandelExceptionWithOut();
            //var theUserInput = Console.ReadLine();
            //ClassForOutParameters.OutKewWordAdvancedUse(theUserInput);
           var ri =  ClassForOutParameters.Divide(10, 3, out int kk);
            Console.WriteLine(ri);
            Console.WriteLine(kk);
#endif
            #endregion

            #region For C# in Parameter
#if false
            var xForInParameter = new StructForInParameterTesting();
            /*This is being allowed because we are not use the in keyword yet!*/
            xForInParameter.MutableField = 12;
            StructForInParameterTesting.TestMethodForInPara(xForInParameter);

            var xForInParameter2 = new ClassForInParameterTesting();
            xForInParameter2.MyProperty = 1;
            ClassForInParameterTesting.TestMethodForInPara2(xForInParameter2);

#endif
            #endregion

            #region For C# null able types
#if false

            int b = 3;
            int? v = null;
            int h = v.HasValue ? v.Value + b : b - 1;
            int h1 = v ?? b - 1;/*using null coalescing*/
            if (v != null)
                write($"V was:{(v ?? v.Value)}");
            else
                write($"V was: NULL so the left side is evaluated: b - 1 ={b - 1} ");
            
            string? l = null;
            string j = (string)l ?? "";/*Null coalescing: If l != null than the value else the empty string*/

            int x1 = 1;
            int? x2 = null;
            int? x3 = x2;
            int x4 = x3 ?? 0;
            int x5 = x3.HasValue ? x3.Value : -1;



#endif
            #endregion

            #region For C# Enum Type
#if false
            KFCProduct chick = KFCProduct.chicken;

            KFCProduct i = (KFCProduct)0; /*Cast a NUMBER to an ENUMERATION value. */
            Console.WriteLine(i);/*The i will print the first named constants: chicken*/

            int j = (int)chick;/*Cast a ENUMERATION  to an NUMBER value*/
            Console.WriteLine(j); /*The j will print the value of the first named constants: chicken*/
            DaysOfWeek Di = (DaysOfWeek)3;
            Console.WriteLine(Di);

            KFCProduct enumMemberChicken;
            if (Enum.TryParse<KFCProduct>("chicken", out enumMemberChicken))
            {
                Console.WriteLine($"successfully parse enumMemberChicken: {enumMemberChicken}");
            }
            /*Prints all the names of constants*/
            foreach (string itmes in Enum.GetNames(typeof(KFCProduct)))
            {
                Console.WriteLine("\n" + itmes);
            }

            /*Prints all the value (indexes) of constants*/
            foreach (int itmes in Enum.GetValues(typeof(KFCProduct)))
            {
                Console.WriteLine("\n" + itmes);
            }

            Console.WriteLine(
           "All possible combinations of values with FlagsAttribute:");
            for (int val = 0; val <= 16; val++)
                Console.WriteLine("{0,5} - {1}", val, (SingleHue)val);
#if false
            foreach (int val in Enum.GetValues(typeof(DaysOfWeek)))
            {
                Console.WriteLine(val + ": " + (DayOfWeek)val);
            }
            var myEnumMemberCount = Enum.GetNames(typeof(DaysOfWeek)).Length;
            Console.WriteLine(myEnumMemberCount);

            DaysOfWeek mondayAndWednesday = DaysOfWeek.Monday | DaysOfWeek.Wednesday;
            Console.WriteLine(mondayAndWednesday);
            
            DaysOfWeek meetingDays = DaysOfWeek.Monday & DaysOfWeek.Sunday;
            Console.WriteLine(meetingDays);

            DaysOfWeek workingFromHomeDays = DaysOfWeek.Monday | DaysOfWeek.Weekend;
            Console.WriteLine(workingFromHomeDays);

            Console.WriteLine($"Join a meeting by phone on {meetingDays & workingFromHomeDays}");

            bool isMeetingOnTuesday = (meetingDays & DaysOfWeek.Sunday) == DaysOfWeek.Monday;
            Console.WriteLine($"Is there a meeting on Tuesday: {isMeetingOnTuesday}");
#endif
#endif
            #endregion

            #region For C# Partial use within classes
#if false
            ClassWithPartialKeyWord classWithPar = new ClassWithPartialKeyWord();
            classWithPar.MethodOne();
            classWithPar.MethodTwo();
            ClassWithPartialFuncion.HelperForPartialMCall();
            csharp.disp();
#endif
            #endregion


            write("");
        }
    }
}
