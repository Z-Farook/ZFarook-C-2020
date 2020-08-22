using System;

namespace GenericsBasics
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine();
            //Basic Overview understanding 
#if false
            TestClassForBoxingAndUnboxing.UnboxTheRefType();
            TestClassForBoxingAndUnboxing.BoxTheValueType2(5);

            //Generic list<T> usage which ensures type safety
            ClassWithGenericList.MakeAGenericList(6);
            var classForListAdding = new ClassGenericListTest();
            var res = ClassAddingDifferentDataToList.AddDifferentTypeToGenericList("The string", 12, classForListAdding);
            Console.WriteLine(res.Item1.GetType());
            Console.WriteLine(res.Item2.GetType());
            Console.WriteLine(res.Item3.GetType());
            object o = "Some string";
            Console.WriteLine(o.GetType()); // prints System.String
#endif
            // Non generic linked list 
#if false
            var linkedList = new NonGenericLinkedList();
            linkedList.AddLast(1);
            linkedList.AddLast(12);
            /*linkedList.AddLast("6");*/ // this gives us error because it cannot be converted to in the for each loop
            foreach (int item in linkedList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
#endif
            // generic linked list 
#if false
            var listOfints = new GenericLinkedList<int>();
            listOfints.AddLast(21);
            //genLink.AddLast("Test") /*Nope, i can't be added the Linked list is type safe now which is now int with this instance*/
            foreach (int item in listOfints)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            var listOfStr = new GenericLinkedList<string>();
            listOfStr.AddLast("hello");
            
            foreach (string item in listOfStr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            /**Note the class type an object you still be able to add things still unsafely */
            var listOfObjects = new GenericLinkedList<object>();

            /**Also note the first line is determining the type of all the entries. Not sure how is this behavior showing up   */
            listOfObjects.AddLast(12);
            listOfObjects.AddLast("TEst");

            foreach (var item in listOfObjects)
            {
                Console.Write(item  + " ");
            }
#endif
            // generic inheritance
#if false
            var t = new Derived<string>();
            t.X = "Wohaha";
            t.Y = "hello";
            // t.Y = 13; /*error*/
            // t.X = 13; /*error*/
            var y = new DerivedWithDifferentBaseType<string, int>();
            y.PropInDerived = "Test dance";
            //y.PropInDerived = 12;/*error*/
            Console.WriteLine($"assignNull: {y.SetThedefaultVar(101)}, PropInDerived: { y.PropInDerived}");/**This is powerful stuff see how the parameter type in this very method is determined */
#endif
            //generic constrains
            //var u = new GenericClassWithInterFaceConstrain<string>(); /*Error since the string class does not implement the interface required */
            //var u = new GenericClassWithInterFaceConstrain<int>(); /*Error since the int class does not implement the interface required */
            //var u = new GenericClassWithInterFaceConstrain<object>(); /*Error since the object class does not implement the interface required */

            /**Tda it works now since the class does inherits the required interface */
            
            var u = new ConstrainStuff<TheHardWay, IShowText>();
            u.WonderLandString(u);


            u.R(u);
            //Partial specialization
            var g = new EnglisBook<int>();
            g.BName = "The heaven highway";
            g.Bpage = 1;
            g.PrintBookInfo(g);

            Console.WriteLine();
        }
    }
}
