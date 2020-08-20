using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Versioning;
using System.Text;

namespace GenericsBasics
{
    #region For C# ArrayList and understanding of the boxing and unboxing
#if true
    public static class TestClassForBoxingAndUnboxing
    {
        public static ArrayList BoxTheValueType()
        {
            /*The reference type*/
            ArrayList arrayList = new ArrayList();
            ArrayList a = arrayList;
            /**Invoking the method of the ArrayList class which take an argument of type object and we are passing the value type so the boxing
             * is happening */
            a.Add(23);
            return a;
        }
        /**Unboxing is happing on the next line because the ArrayList is being read and giving us int back  */
        public static void UnboxTheRefType() => Console.WriteLine(BoxTheValueType()[0]);

        public static void BoxTheValueType2(int l)
        {

            ArrayList a = new ArrayList(); /*The reference type*/

            //var g = a.Capacity; /*can be used for condition if we had given the initial capacity to the variable a */

            for (int i = 0; i < l; i++)
            {
                /**Invoking the method of the ArrayList class which take an argument of type object and we are passing the value type so the boxing
                 * is happening */
                a.Add(i + 1);
            }

            /*Calls the method to print the ArrayList */
            UnboxTheRefType2(a);
        }

        /// <summary>
        /// The printer for unboxing
        /// Boxing and unboxing are easy to use but have a big performance impact, especially when iterating through many items.
        /// </summary>
        /// <param name="ar"></param>
        public static void UnboxTheRefType2(ArrayList ar)
        {
            foreach (var item in ar)
            {
                Console.WriteLine(item);
            }
        }
    }
#endif
    #endregion

    #region For C# Generic list<T> and its use
#if true
    /**The boxing and unboxing with OBJECTS have some performance issues that can be limited using the List<T> generic class from the Microsoft .Net*/
    public class ClassWithGenericList
    {
        public static List<int> MakeAGenericList(int length)
        {
            List<int> aListC = new List<int>(length);
            for (int i = 0; i < length; i++)
            {
                aListC.Add(i + 1);
            }
            PrintListT(aListC);
            return aListC;
        }

        public static Func<List<int>, int> PrintListT = (List<int> listToIterate) =>
         {
             int res = 0;
             foreach (var item in listToIterate)
             {
                 res = item;
                 Console.WriteLine(item);
             }
             return res;
         };
    }

    public static class ClassAddingDifferentDataToList
    {
        public static (List<string>, List<int>, List<ClassGenericListTest> ) AddDifferentTypeToGenericList(string s, int u, ClassGenericListTest classGenericListTest)
        {
            var addString = new List<string>();
            addString.Add(s);
            var addInt = new List<int>();
            addInt.Add(u);
            var addClass = new List<ClassGenericListTest>();
            addClass.Add(classGenericListTest);
            return (addString, addInt, addClass);
        }
    }
    public class ClassGenericListTest
    {

    }

#endif
    #endregion

}
