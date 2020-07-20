using System;
using System.Security.Cryptography.X509Certificates;

namespace Chapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*to get dimmed code working do: */
#if flase
//  to:
//#if true
            //call to some variables 
            variablesBasics.someVariablePrinting();
            //call to some statements
            StatementsAndExpressions.myStatements();
            StatementsAndExpressions.blockStatement();
            //call to some expression 
            StatementsAndExpressions.myExepression();
            StatementsAndExpressions.uselessExepressionAsStatement();

            //call to assignment expression
            StatementsAndExpressions.assignmentIsExepression();

            // an expression in which operands call some 
            static int seeWatIsTheOrderOfEvaluation(string lable, int x)
            {
                Console.WriteLine(lable);
                return x;
            }

            Console.WriteLine(
                seeWatIsTheOrderOfEvaluation("a", 1) +
                seeWatIsTheOrderOfEvaluation("b", 1) +
                seeWatIsTheOrderOfEvaluation("c", 1) +
                seeWatIsTheOrderOfEvaluation("d", 1)
                /*Note we could have nested call to the same function and will see the different abc order in the output */
                );

            //call comment method
            CommentAndWhiteSpaces.myDelimitedCommnet();

        }
    }
}


