using System;
using System.Collections.Generic;
using System.Threading;

namespace OperatorsBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            #region For C#  OPERATOR
#if false
            /**Pre- and post increment */
            OperatorHolder.PreAndPsotOper();
            Console.WriteLine(OperatorHolder.TheTernaryOper(12));

            /**The checked and unchecked operator */
            OperatorHolder.TheCheckedOper();
            OperatorHolder.TheUncheckedoper();
#endif

#if false
            AsAndIsHolder.TheIsOper();
            AsAndIsHolder.CreatAvarUsingIsOper(new AsAndIsHolder());
            Console.WriteLine();
            AsAndIsHolder.TheAsOper();
#endif

#if false
            SizeOfHolder.PrintBytes();
#endif
            #endregion
        
            Console.WriteLine();

        }
    }
}
