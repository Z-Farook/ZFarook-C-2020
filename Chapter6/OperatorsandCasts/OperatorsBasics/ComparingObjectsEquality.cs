using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorsAndCasts
{
    internal class A
    {
    }
    internal class B
    {
        public static void Test()
        {
            var r = object.ReferenceEquals(new A(), new B());
            Console.WriteLine("A == B: " + r);
        }
    }

    class Point
    {
        /*Here the get hasCode is intentionally not overridden so compiler gives you a waring
         * to understand why visit: https://www.tddapps.com/2016/01/30/Compiler-Warning-CS0659/ */
        protected int x, y;
        public Point() : this(0, 0)
        { }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType())) /*This keyword refers to each instance of the Point class */
            {
                return false;
            }
            else
            {
                Point p = (Point)obj; /*The Point3D is being converted to its parent class Point!!! */
                return (x == p.x) && (y == p.y); /**Compare the Point.x and Point.y with the Point3D.x Point3D.y 
                                                  * the  Point3D.x Point3D.y are coming with the instance  */
            }
        }
    }
    sealed class Point3D : Point
    {
        int z;
        public Point3D(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }
    }
    public class Person
    {
        private string idNumber;
        private string personName;

        public Person(string name, string id)
        {
            this.personName = name;
            this.idNumber = id;
        }

        public override bool Equals(Object obj)
        {
            Person personObj = obj as Person;
            if (personObj == null)
                return false;
            else
                return idNumber.Equals(personObj.idNumber);
        }

        public override int GetHashCode()
        {
            return this.idNumber.GetHashCode();
        }
    }
    public struct StrA
    {

    }
    public struct StrB
    {

        public static void ValueTypeComparison(StrA a , StrB b)
        {
            /*ReferenceEquals ALWAYS RETURNS FALSE when applied to VALUE TYPES BECAUSE, 
             * to call this method, the value types need to be boxed into objects*/

            Console.WriteLine(object.ReferenceEquals(12, 13)); /*The reason is that value is boxed separately 
                                                                * when converting each parameter, which means 
                                                                * you get different references*/
            Console.WriteLine(object.ReferenceEquals(a,b));
        }
    }
}
