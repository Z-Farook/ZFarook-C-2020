using InterfacesInCSharp.InterFace;
using System;
using System.Collections.Generic;
using System.Resources;
using System.Text;

namespace InterfacesInCSharp.InterFace
{
    public interface IHuman
    {
        /**All MEMBERS are always IMPLICITLY PUBLIC */
        string SName { get; }
        string LName { get; }
        bool EatsAnsDrinkHealthy(string food, string drink);


    }

    public interface IHuman2 : IHuman
    {
        public string test();
    }
}

namespace InterfacesInCSharp
{
    /**Note the name-space is being imported at the top in order to GET/USE the interface defined above
     * Now when the IHuman is inherited you must implement each member of the interface other wise you get the complier yelling at you*/
    public class Earthling : IHuman
    {
        public Earthling(string sName, string lName)
        {
            SName = sName;
            LName = lName;
        }
        /**Set the #if to false at the next line to see the error on action */
#if true 

        public string SName { get; private set; }

        public string LName { get; private set; }
#endif
        public bool EatsAnsDrinkHealthy(string food, string drink)
        {
            if (food != "Cheese pizza" && drink != "Cola")
            {
                Console.WriteLine($"{SName} {LName}, is possibly healthy because he doesn't eats/drink: {food}, {drink}");
                return true;
            }
            else
                return false;
        }
    }

    /**IS AND AS OPERATORS */
    public class TestClassForIsAndAsOperators
    {
        public int Dance { get; set; }
        /**Using the AS operator */
        public void MehtodWithAsOPerator(object o)
        {
            IHuman convertedI = o as IHuman;

            /**if the passed object doesn't inherits the IHuman interface then the type conversion is not done and null is returned (at the run time)  */
            if (convertedI != null)
            {
                Console.WriteLine("The passed object does implements the IHuman interface!!! ");
            }
            else
            {
                Console.WriteLine(TestClass.HowIst());
            }
        }

        /**Using the IS operator which is analogous to the as!! It defines the local variable CONVERTEDI in the condition itself  */
        public void MehtodWithIsOPerator(object o)
        {
            /**if the passed object doesn't inherits the IHuman interface then the type conversion is not done and null is returned (at the run time)  */
            if (o is IHuman convertedI)
            {
                Console.WriteLine("The passed object does implements the IHuman interface!!! ");
            }
            else
            {
                Console.WriteLine(TestClass.HowIst());

            }
        }
    }

    public class TestClass
    {
        public static string HowIst() => "THe passed parameter object does not implements the IHuman so the conversion cannot be done!!!";
    }

    /*NOTE we are having an interface that has  also INHERITED from ANOTHER Interface*/
    public class ClassWithTwoLayerInterfaces : IHuman2
    {
        public string SName => throw new NotImplementedException();

        public string LName => throw new NotImplementedException();


        public bool EatsAnsDrinkHealthy(string food, string drink)
        {
            throw new NotImplementedException();
        }

        /*Note the next method is FROM THE DERIVED Interface!!*/
        public string test()
        {
            throw new NotImplementedException();
        }
    }
}