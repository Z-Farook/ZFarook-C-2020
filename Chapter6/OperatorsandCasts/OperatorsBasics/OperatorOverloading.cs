using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorsAndCasts
{
    public class AdditionHolder
    {
        public AdditionHolder(int age, double height)
        {
            Age = age;
            Height = height;
        }

        public int Age { get; }
        public double Height { get; }

        public static (int age, double grownedHeight) AgeDeterminer(int growth, AdditionHolder additionHolder) =>
            (additionHolder.Age + 1, additionHolder.Height + growth);

        public static (int age, double grownedHeight) operator +(int growth, AdditionHolder additionHolder) =>
            (additionHolder.Age + 1, additionHolder.Height + growth);
    }
    public struct ThreeDMoves
    {
        public ThreeDMoves(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public ThreeDMoves(ThreeDMoves v)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
        }

        public double X { get; }
        public double Y { get; }
        public double Z { get; }

        public override string ToString() => $"( {X}, {Y}, {Z} )";

        /*all operator overloads be declared as public and static, which means they are associated
         * with their class or struct, not with a particular instance*/
        public static ThreeDMoves operator *(double left, ThreeDMoves right) =>
             new ThreeDMoves(left * right.X, left * right.Y, left * right.Z);

        public static ThreeDMoves operator *(ThreeDMoves left, double right) =>
          right * left; /*Note this is calling/ reusing the code of overload that is above this one otherwise
                         * we must again write: new Vector(left * right.X, left * right.Y, left * right.Z);
                         */
        public static double operator *(ThreeDMoves left, ThreeDMoves right) =>
          left.X * right.X + left.Y * right.Y + left.Z * right.Z;
    
        /*In the same way we can use other arithmetic operators can be overloaded like: /, -   */
    }
    
}
