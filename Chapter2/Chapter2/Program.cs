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
#endif

#if flase
//  to:
//#if true
            //call to conditional debugging method
            PreprocessingDirectives.compilationWithCondition();

            /* Call the method annotated with: [System.Diagnostics.Conditional("DEBUG")]*/
            PreprocessingDirectives.ShowDebugInfo();
#endif
            #region Numeric conversion methods region
            NumericTypeConversion.IntToDouble();
            NumericTypeConversion.IntentionalOverflow();
            NumericTypeConversion.CheckedExpressions();
            #endregion

            #region Biginteger method call region
#if fale

            BigIntegerUse.PrintBigInteger();
#endif
            #endregion

            #region string and char region
            StringsAndCharacters.CharAndStringDiff();
            StringsAndCharacters.StringExpression();
            StringsAndCharacters.StringInterpoltationMgic();
            StringsAndCharacters.FormateTheFloatPointsUsingPlaceholdersInInterpoltation();
            StringsAndCharacters.CustomStringFormatingUsingStringFomatable();
            #endregion
        }
    }
}


