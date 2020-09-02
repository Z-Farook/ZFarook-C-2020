using System;

namespace OperatorsAndCasts
{
    #region For C# arithmetic operators overloading
#if true
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
#endif
    #endregion

    #region For C# Comparison operators overloading
#if true
    /*Note the interface: IEquatable type argument is our own type: DayTemperature. This interface forces us to implement the
     * STRONGLY TYPED VERSION of the EQUALS METHOD that IS DEFINED BY the BASE CLASS OBJECT*/
    public struct DayTemperature : IEquatable<DayTemperature>
    {
        public int Day { get; private set; }
        public int Night { get; private set; }

        public DayTemperature(int day, int night)
        {
            Day = day;
            Night = night;
        }

        public static bool IsTempSame(DayTemperature d1, DayTemperature d2)
        {
            /*This will ALWAYS return FALSE IF THE arguments TYPE are VALUE TYPE BECAUSE OF THE BOXING AND UNBOXING*/
            if (ReferenceEquals(d1, d2)) return true;

            /**This is used to determine the result when arguments are value types */
            var res = d1.Night == d2.Night && d1.Day == d2.Day;
            Console.WriteLine($"IsTempSame: {res}");
            return res;
        }

        public static bool operator ==(DayTemperature d1, DayTemperature d2)
        {
            if (ReferenceEquals(d1, d2))
                return true;
            var res = d1.Night == d2.Night && d1.Day == d2.Day;
            Console.WriteLine($"The operator == resulted in: {res}");
            return res;
        }

        public static bool operator !=(DayTemperature d1, DayTemperature d2)
        {
            /*Note the == is calling the overload defined above and to the result of that operator
              * we add the operator: ! So, if the result was true it become false and the other way around applies too*/
            Console.WriteLine($"The operator != called  ==(DayTemperature d1, DayTemperature d2) and the MODIFIED its RESULT BY THE NOT OPERATOR !");
            bool res = !(d1 == d2);
            Console.WriteLine($"So, The operator != resulted in: {res}");
            return res;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            /*Note the == is calling the overload defined above. The keyword this is the first argument to the operator overload*/
            return this == (DayTemperature)obj;
        }

        public override int GetHashCode()
        {
            var res = Day.GetHashCode() ^ Night.GetHashCode();
            Console.WriteLine($"HasCode is: {res}");
            return res;
        }

        /**NOte, this method is different then: public override bool Equals(object obj) */
        public bool Equals(DayTemperature other)
        {
            /*Note the == is calling the overload defined above. The keyword this is the first argument to the operator overload*/
            bool res = this == other;
            Console.WriteLine($"The: Equals(DayTemperature other) returned: {res}");
            return res;
        }
    }
#endif
    #endregion

}
