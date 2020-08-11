using System;

namespace Inheritance_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            var human = new Human("John", "Doe");
            human.PrintHumanName();

            ClassHidingTheMethod.TestA(12);

            ChildOfB g = new ChildOfB();
            g.PrintBaseMethod();

            var p1 = new PizaTuna ();
            //var p1 = new PizaTuna(0.2, 0.5, .4 , .1);
            p1.PrintIngredient(p1);
        }

    }
}
