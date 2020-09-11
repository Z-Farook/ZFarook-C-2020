using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace BasicsOfArrays
{
    //--------------------------------------IStructuralEquatable. ---------------------------------------------

    #region Array or tuple's content comparison--
    /**--by casting them to: *IStructuralEquatable interface* and then Invoking the Equals method —that is: 
     * bool quals(object other, IEqualityComparer comparer); 
     * —you can define how the comparison should be done by passing an object that implements IEqualityComparer<T> interface.
     * A default implementation of the IEqualityComparer<T> interface is done by the EqualityComparer<T> class. 
     * This implementation checks whether the type (Your_ClassX) implements the interface IEquatable --(so you have had implemented the virtual Equals 
     * method of IEquatable which will be then seen as the method implementation of the IEqualityComparer<T>), --and invokes the IEquatable.Equals method. 
     * If the type does not implement IEquatable, the Equals method from the base class Object is invoked to do the comparison.
     *
     **/
#if true
    public class Circle : IEquatable<Circle>
    {
        public int Diameter { get; set; }
        public int Radius { get; set; }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return base.Equals(obj);
            return Equals(obj as Circle);
        }
        public override int GetHashCode() => Radius.GetHashCode();

        /// This is the implementation of IEquatable<Circle> Members 
        
      public bool Equals(Circle other)
        {
            if (other == null)
                return base.Equals(other);
            return Diameter == other.Diameter && Radius == other.Radius;
        }
    }



#endif
    #endregion
    #region Using the IEqualityComparer<T> directly for comparison of content in objects
#if true
    public class Rectangle2
    {
        private static int _Id = 0;
        public int Id { get; }
        public Rectangle2()
        {
            Id = ++_Id;
        }
        public int Heigth { get; set; }
        public int Width { get; set; }
    }
    class RectangleComparer : IEqualityComparer<Rectangle2>
    {
        /// <summary> 
        /// This is the override of the object's virtual Equal method. Compares the content of the objects
        /// Rectangle x, Rectangle y. 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>bool</returns>
        public bool Equals([AllowNull] Rectangle2 x, [AllowNull] Rectangle2 y)
        {
            if (x == null && y == null) return true;
            if (x == y) return true;
            if (x == null) return false;
            if (y == null) return false;
            var res = x.Heigth == y.Heigth && x.Width == y.Width;
            return res;

        }

        public int GetHashCode([DisallowNull] Rectangle2 obj)
        {
            return obj.Id.GetHashCode();
        }
    }
#endif
    #endregion

}
