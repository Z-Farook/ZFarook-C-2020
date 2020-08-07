using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    internal class Properties
    {
        //Naming field with _ and making it private
        private string _planeName;
        private int _ticketPrice;

        /// <summary>
        /// Now the following will aid to access the field the property above, because that property is defined as private
        /// and that will only be called directly within this class and not from any other one. The setter contains a spacial kind
        /// of word "value" that is implicit parameter for the setter method.
        /// </summary>
        public string PlaneName
        {
            get
            {
                Console.WriteLine($"_Company: {_planeName} and _price: {_ticketPrice}\n");
                return _planeName;
            }
            set { _planeName = value; }
        }

        public int TicketPrice
        {
            get { return _ticketPrice; }
            set { _ticketPrice = value; }
        }


        //same thing with different naming convention
        private string planeName;
        private int ticketPrice;

        public string PlaneName2
        {
            get
            {
                Console.WriteLine($"Company: {planeName} and price: {ticketPrice}\n");
                //return PlaneName; /*doing this mistake calls the property above (the getter of PlaneName)*/
                return planeName;
            }
            set { planeName = value; }
        }

        public int TicketPrice2
        {
            get { return ticketPrice; }
            set { ticketPrice = value; }
        }
    }

    internal class ExpressionBodiedProps
    {
        private int x;
        private int y;

        public int Y
        {
            get => y;
            set => y = value;
        }

        public int X
        {
            get => x;
            set => x = value;
        }


    }

    internal class AutoImplimentedProps
    {
        /*This is a good candidate when there is no logic in the setter and getter*/
        public string Name { get; set; }
        public string LName { get; set; }
        public int AuotPropInitializer { get; set; } = 50;
    }
    internal class PropertyAccessLevel
    {
        private int accessX;

        public PropertyAccessLevel(int accessX)
        {
            /*Note this is a assignment to the set method of property AccessX when this is not done 
             * you will not be able to do the following: x.AccessX = 45 by using the object's instance
             * That said, it will be always ready only field and will have the auto value 0 always.
             * As discussed earlier, Read-only properties can’t be assigned outside the constructors
             * (Have look at the class ClassWithReadOnlyFields in ClassesIntroduction file!).
             */
            AccessX = accessX;
        }

        public int AccessX
        {
            get => accessX;
            private set => accessX = value;
        }

    }

    internal class MakeReadOnlyOmitingTheSetter
    {
        //1st way to create read only properties
        private readonly string _j;
        /// <summary>
        /// A read only field cannot be assigned to(except in a constructor of the class in which the field is defined or a variable initializer
        /// </summary>
        /// <param name="value"></param>
        public MakeReadOnlyOmitingTheSetter(string value)
        {
            _j = value;
        }

        public string J
        {
            get => _j;

            /* If you try to set a setter on the read only field the compiler will show an error:
             * A read only field cannot be assigned to(except in a constructor of the class in which
             * the field is defined or a variable initializer*/
            // set => _j = value;
        }

        //2nd way to create read only properties
        /*Auto-Implemented Read-Only Properties: instead of having to do a lot only for single read only field 
         * you have this compact syntax! */
        public int Id { get; } = 69;
        public int Id2 { get; } = Test();
        public static int Test() => 21;
    }

    internal class ExplicitReadOnlyPropTroughConstructor
    {
        public ExplicitReadOnlyPropTroughConstructor(int x) => ID = x;
        //{
        //    ID = x; 
        //}
        public int ID { get; }
    }

    public class Person
    {
        public Person(string v1, string v2)
        {
            FName = v1;
            Lname = v2;
        }
        /*Note these the next 3 props are now read only since there are not including the setters */
        public string FName { get; }
        public string Lname { get; }
        /*The next line is calling the props which in tern are kind of methods*/
        public string FullName => $"{FName} {Lname}";
    }
}


