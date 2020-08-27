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

#if false
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
#endif
            //static members in generics 
#if false
            //var i = new StaticDemo<string>();
            //var s = new StaticDemo<int>();
            var i = StaticDemo<string>.x = 4;/*Note that the int and string are not have any affect on the field!!!, Because the field has its own type defined explicitly and that is int */
            var s = StaticDemo<int>.x = 4;   /*Note that the int and string are not have any affect on the field!!!, Because the field has its own type defined explicitly and that is int */
            Console.WriteLine("i: " + i.GetType());
            Console.WriteLine("s: " + s.GetType());
#endif
            // generic interfaces
#if false
            //StationCollection.PrintFakeChannels();

            //COVARIANCE with generic interfaces
            TreeCollection treesCollection = TreeCollection.GetTreeCollection();

            /** The magic of OUT keyword is to be seen in the next two lines*/

            IPlants<Flower> flower = treesCollection;  /*Note how we are going form more specific to more general*/

            IPlants<Plant> plant = flower; /*Note how we are going form more specific to more general*/

            for (int i = 0; i < plant.Count; i++)
            {
                /**Note you are calling the THIS[INT INDEX] method defined int the Flower class which RETURNS a Flower record AT INDEX I
                 * Each time a record is retrieved then the WRITELINE is and OFF-COURSE SINCE THE ARGUMENT TO IT IS A WHOLE OBJECT it goes to fire the overridden 
                 * ToString that is defined in some class in the hierarchy!!! */
                Console.WriteLine(treesCollection[i]);
            }

            //CONTRA-VARIANCE with Generic Interfaces
            IAnimals<Animal> quadruped = Zoo.GetAnimalCollection();
            IAnimals<Quadruped> genericToSpecific = quadruped; //from more GENERIC TO more SPECIFIC

            Animal[] zoodata = Zoo.GetAnimal;
            quadruped.PrintPalntInfo(zoodata);
#endif
            //Nullable<int> i; ==> is same as int? i ;
#if false
            int? x1 = ATest.GetNullableType(12);
            int? x2 = ATest.GetNullableType(null);
            int? x3 = x1 + x2;
            Console.WriteLine("X3: " + (x3.HasValue ? x3.Value : x3.GetValueOrDefault()));
#endif
            //generic methods
#if false
            int i = 4;
            int j = 5;
            MethodPlaceHolder.Swap<int>(ref i, ref j);

            /**Note the LIst implement some interface and one of those is IEnumerable 
             * which is the type of parameter of our method PrintAnimal
             * */
            var animalList = new List<Animal>() {
                new Animal{Name = "A" , Color = "B"},
                new Animal{Name = "C" , Color = "D"},
                new Animal{Name = "E" , Color = "F"}
             };
            //MethodPlaceHolder.PrintAnimalSimple(animalList);

            var sampleList = new List<MethodPlaceHolder>() {
                new MethodPlaceHolder{Age = "A1" , Height = 12},
                new MethodPlaceHolder{Age = "A2" , Height = 11},
                new MethodPlaceHolder{Age = "A3" , Height = 10},
             };

            MethodPlaceHolder.PrintAnimal1<MethodPlaceHolder>(sampleList);

           var res =  MethodPlaceHolder.PrintAnimal2<MethodPlaceHolder, decimal>(sampleList, (sampleList,sum)=> sum+=sampleList.Height);
            Console.WriteLine(res);

#endif
            //generic methods specialization 
#if true 
            MethodSpecialisationePlaceHolder.Test1(12);
            MethodSpecialisationePlaceHolder.Test2<int>(30);
            MethodSpecialisationePlaceHolder.Test2("Hello"); // The same method without type parameter
            MethodSpecialisationePlaceHolder.Test3<int, float>(13, 12.0f);
            MethodSpecialisationePlaceHolder.Test3(13, 134.0f); //The same method without type parameter
            MethodSpecialisationePlaceHolder.Test4<string>("Test", 12);
            MethodSpecialisationePlaceHolder.Test4("Test2", 12); //The same method without type parameter
            MethodSpecialisationePlaceHolder.YourSurprise<decimal>(12.000012m);
            MethodSpecialisationePlaceHolder.YourSurprise(12.000010002m); //The same method without type parameter
#endif

            Console.WriteLine();

        }
    }
}
