using Microsoft.VisualBasic;
using System;
using System.Security.Cryptography.X509Certificates;
using Chapter2;
using System.Collections.Generic;
using System.Linq;

namespace Chapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            var newLine = "\n";
            Action<object> Cwr = Console.WriteLine;
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

            #region Tuple's region
#if false
            Tuples.DeconstructTuple();
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

            #region For C# Operators 
#if false
            var x = "Random string";
            CSharpOperators.AndOrOperatorCheking(CSharpOperators.x);
            CSharpOperators.AndOrOperatorCheking(null);
            CSharpOperators.ModernCheckOFNullWith_NullCconditiona("We are advanced now");
            CSharpOperators.UsingTrinarOperator("We are advanced now");
            CSharpOperators.ExploitedTrinaryForNullException(null);
            CSharpOperators.ExploitedTrinaryForNullException("We are advanced now");
            CSharpOperators.Combination_NullConditionalAndNullCoalescing(null);
            CSharpOperators.Combination_NullConditionalAndNullCoalescing(x);
            CSharpOperators.ConditionalOperatorAsArgument(true);
#endif
            #endregion

            #region For C# Control flows
#if false
            Console.WriteLine(newLine);
            /* If Statements*/
#if false

            ControlFlow.WannaDrink(16);
            ControlFlow.WannaDrink(19);
            ControlFlow.IfStatementWithOutBlock(16);
            ControlFlow.IfStatementWithOutBlock(19);
            ControlFlow.DangrousIfStatement(true);
            ControlFlow.DangrousIfStatement(false);
            ControlFlow.MoreThanTowIfElse(15);
#endif
            // switch statements
#if false
            ControlFlow.SwithchWithStringInput("print default");
            ControlFlow.SwithchWithStringInput("happy");
            ControlFlow.FallThroughUsingGoTo(3);
            ControlFlow.FallThroughUsingGoTo(2);
#endif
            //Loops
#if false
            ControlFlow.WhileLoop(5);
            /*Causing a infinite loop */
            //ControlFlow.MakingTheWhileLoopInfinateByUsingSemicolon(5);
            ControlFlow.DoLoop();
            ControlFlow.ForLooPInAction(10);
            ControlFlow.ForLooPWithMoreThan1Initialzer(10);
            ControlFlow.NestdForLooP(5, 7);
            ControlFlow.ItrateOveCollectionWithForeach(10);
            IEnumerable<string> m_oEnum = new List<string>() { "1", "2", "3" };
            ControlFlow.IsForeachBetterThanFor(m_oEnum);

#endif
            Console.WriteLine(newLine);
            //parent end if
#endif
            #endregion


            #region For C# patterns
#if true
            Cwr(newLine);
            CSharpPatterns.PatternWithTupleSwitchCase((0, 2));
            CSharpPatterns.CheckTheArgTypeAndCallAMethod(3);
            CSharpPatterns.CheckTheArgTypeAndCallAMethod("S");
            CSharpPatterns.CheckTheArgTypeAndCallAMethod(0.0);
            /*this causes the var x var y CASR*/
            CSharpPatterns.MoreThanOneKinfOfPositionalPattern(("0", 0));
            /*cause the 1st two switch statement*/
            CSharpPatterns.Propertypatterns((""));
            /*cause the last switch statement*/
            CSharpPatterns.Propertypatterns(("0"));
            CSharpPatterns.ConditionalPatternUsigWhen((5, 4));
            CSharpPatterns.SwitchStatementWithoutExpression(4);
            CSharpPatterns.SwitchStatementWithoutExpression((4, 4));
            Cwr(CSharpPatterns.SwitchStatementWithExpression(4));
            Cwr(CSharpPatterns.SwitchStatementWithExpression((4, 4)));
            CSharpPatterns.BooleanPatternWithIs((1, 2));
            CSharpPatterns.UseTheVariableOfBoolPattern((",", 1));
            CSharpPatterns.UseTheVariableOfBoolPattern((5, 1));
            CSharpPatterns.ConditionalPatternWithOutUsingWhenKeyWord((",", 1));
            CSharpPatterns.ConditionalPatternWithOutUsingWhenKeyWord((5, 1));
            Cwr(newLine);
#endif
            #endregion
        }
    }
}


