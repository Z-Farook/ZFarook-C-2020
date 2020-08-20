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

            Console.WriteLine();

        }
    }
}
