using InterfacesInCSharp.InterFace;
using System;
using System.Threading;

namespace InterfacesInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            #region For C# basic interfaces 
#if false
            var p1 = new Earthling("Jane", "Parker");
            p1.EatsAnsDrinkHealthy("Salad", "Water");

#endif
            #endregion

            #region For C# IS AND AS OPERATORS
#if true
            /*The as operator testing*/
            var test1 = new Earthling("Jane", "Parker");
            TestClassForIsAndAsOperators instanceX = new TestClassForIsAndAsOperators();
            //instanceX.MehtodWithAsOPerator(test1);
            ///**The next won't exceed because the TestClass does not implement the IHuman */
            //var test2 = new TestClass();
            //instanceX.MehtodWithAsOPerator(test2);

            ///*The is operator testing*/
            //instanceX.MehtodWithIsOPerator(test1);
            ///**The next won't exceed because the TestClass does not implement the IHuman */
            //instanceX.MehtodWithIsOPerator(test2);

            /**See how what is the result this time */

            var test3 = new ClassWithTwoLayerInterfaces();
            instanceX.MehtodWithIsOPerator(test1);
            /**This will exceed too!! Because the class is implementing the interface  */
            instanceX.MehtodWithIsOPerator(test3);

#endif
            #endregion

            Console.WriteLine();

        }
    }
}
