using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public struct School
    {
        public String Name { get; }
        public String City { get; }

        public School(string name, string city)
        {
            Name = name;
            City = city;
        }

        public void GetSchoolAndCity() => Console.WriteLine($"School name: {Name}, City: {City}");

        /*To avoid some performance issue using REF keyword when defining a parameter of type struct */
        public void GetSchoolAndCity(ref School s) => Console.WriteLine($"School name: {s.Name}, City: {s.City}");
    }

    public struct ReadOnlyStruct
    {
        public bool RainDrop { get; }
        public bool IsCarWet { get; }

        public ReadOnlyStruct(bool rainDrop, bool isCarWet)
        {
            RainDrop = rainDrop;
            IsCarWet = isCarWet;
        }

        public void CanWeUndoTheRain() => Console.WriteLine(
            $"Was it raining?: {RainDrop}, \nWas the car wet?: {IsCarWet } " +
            $"\nWe cannot undo the rain once it has happened! So, the same goes for this type! Once initialized" +
            $"you cannot change its members values!");
    }

    public ref struct ExampleTypeRefStruct
    {
        public int MyProperty { get; private set; }

        public ExampleTypeRefStruct(int myProperty)
        {
            MyProperty = myProperty;
        }
        public void TheBarkingDog() => Console.WriteLine($"The dog barked {MyProperty} times");
    }
}
