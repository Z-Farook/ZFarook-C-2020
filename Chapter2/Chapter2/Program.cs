using Microsoft.VisualBasic;
using System;
using System.Security.Cryptography.X509Certificates;
using Chapter2;
namespace Chapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*to get dimmed code working do: */

#if false
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
#endif

#if false
//  to:
//#if true
            //call to conditional debugging method
            PreprocessingDirectives.compilationWithCondition();

            /* Call the method annotated with: [System.Diagnostics.Conditional("DEBUG")]*/
            PreprocessingDirectives.ShowDebugInfo();
#endif
            #region Numeric conversion methods region
#if false

            NumericTypeConversion.IntToDouble();
            NumericTypeConversion.IntentionalOverflow();
            NumericTypeConversion.CheckedExpressions();
#endif
            #endregion

            #region Biginteger method call region
#if false

            BigIntegerUse.PrintBigInteger();
#endif
            #endregion

            #region string and char region
#if false
            StringsAndCharacters.CharAndStringDiff();
            StringsAndCharacters.StringExpression();
            StringsAndCharacters.StringInterpoltationMgic();
            StringsAndCharacters.FormateTheFloatPointsUsingPlaceholdersInInterpoltation();
            StringsAndCharacters.CustomStringFormatingUsingStringFomatable();
#endif
            #endregion

            #region Region of dynamic 
            var staticType = new MyDynamicType();
            dynamic dType = new MyDynamicType();

            //staticType.MethodX("this method doesn't expect any args and is statically typed so you see the error right away!");

            //turn the next line to if true to see the error 
#if false
            dType.MethodX("I will work now, because you disabled the static type-checking ;( I have surprise at runtime");
            dType = "some wrong stuff"; /*not how badly we changed the type form MyDynamicType -> simple STRING*/
#endif

#if false
            var printDynamics = new MyDynamicType();
            printDynamics.PrintSomeDynamics();
#endif
            #endregion
        }
    }
}


