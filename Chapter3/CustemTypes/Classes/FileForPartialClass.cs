using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{

    internal partial class ClassWithPartialKeyWord
    {
        public void MethodTwo() { Console.WriteLine("I am the method TWO from the partial class in different file"); }
    }

    internal partial class ClassWithPartialFuncion
    {
        /*Note the method signature (Name, return, static) is exactly the same*/
        static partial void TPartialMethod()
        {
            Console.WriteLine("implementation of APartialMethod");
        }
    }

    static partial class csharp
    {
       static partial void Show()
        {
            Console.WriteLine("csharp: Partial Method is Implemented");
        }
    }
}
