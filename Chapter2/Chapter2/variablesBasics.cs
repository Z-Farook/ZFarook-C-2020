using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Chapter2
{
    internal static class variablesBasics
    {
        //declaration and variable assignment
        internal static void someVariablePrinting()
        {
            string part1 = "the ultimate question";
            string part2 = "of something";
            int theAnswer = 42;
            part2 = "of life, the universe, and everything";
            string questionText = "What is the answer to " + part1 + ", " + part2 + "?";
            string answerText = "The answer to " + part1 + ", " +
             part2 + ", is: " + theAnswer;
            Console.WriteLine(questionText);
            Console.WriteLine(answerText);
        }


        /* when an unassigned variable is being accessed
        Use of unassigned local variable 'willNotWork'*/
#if false
//to:      see the error comment the line above
//#if true
        internal static void BadCode()
        {
            int willNotWork;
            Console.WriteLine(willNotWork);
        }
        //example of accessing a variable outside of scoop and incompatible method

        static void myFunc()
        {
            int thisWillNotWork = 42;
        }

        static void getVarForm_myFunc()
        {
            Console.WriteLine(thisWillNotWork);
        }

        //despite the scope you get the error because of declaration space 
        static void cofusion()
        {
            int someValue = 12;
            if (someValue > 100)
            {
                int anotherValue = someValue - 100;  // Compiler error
                Console.WriteLine(anotherValue);
            }
            int anotherValue = 123;
        }
    }
#endif
    }
}