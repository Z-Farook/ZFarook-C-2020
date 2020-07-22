using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter2
{
    internal class MyDynamicType
    {
        public string field1 { get; set; }
        public string field2 { get; set; }
        public dynamic dyn { get; set; }
        public void MethodX() => Console.WriteLine("Hello from the dynamic Type!");
      
        public void PrintSomeDynamics() {
            dyn = 100;
            Console.WriteLine(dyn.GetType());
            Console.WriteLine(dyn);
            dyn = "This is a string";
            Console.WriteLine(dyn.GetType());
            Console.WriteLine(dyn);
        }

    }
}
