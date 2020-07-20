#define DEBUG
#define MYTEST
#define ENTERPRISE
#define W10
#define PROFESSIONAL
using System;
/*You need to place any #define and #undef directives at the beginning
of the C# source file*/
namespace Chapter2
{
    internal static class PreprocessingDirectives
    {
        //#if, #elif, #else, and #endif

        #region  conditional compilation code region 
        internal static void debugCondi()
        {

#if (DEBUG && !MYTEST)
        Console.WriteLine("DEBUG is defined");
#elif (!DEBUG && MYTEST)
        Console.WriteLine("MYTEST is defined");
#elif (DEBUG && MYTEST)
            Console.WriteLine("DEBUG and MYTEST are defined");
#else
        Console.WriteLine("DEBUG and MYTEST are not defined");
#endif
        }

        internal static void compilationWithCondition()
        {
#if ENTERPRISE && W10
            // do something
            Console.WriteLine("Code for enterprise Application");
            DoWork();
#elif ENTERPRISE || W10
            // some code that is only relevant to enterprise
            // edition running on W10
            Console.WriteLine("Code for  the non enterprise Application");
#else
           LazyYou();
#endif
        }

        [System.Diagnostics.Conditional("DEBUG")]
        internal static void ShowDebugInfo()
        {
            Console.WriteLine("Hello, I am ShowDebugInfo and i am printed because the DEBUG is declared");
        }
        private static void DoWork()
        {
            Console.WriteLine("OK, i did the work for you");
        }
        private static void LazyYou()
        {
            Console.WriteLine("OK, i didn't do the work for you");
        }
        #endregion  

#if DEBUG && RELEASE
#error "You've defined DEBUG and RELEASE simultaneously!"
#endif
#line 164 "Core.cs" // We happen to know this is line 164 in the file Core.cs, before the intermediate
        // package mangles it.
        // later on
#line default // restores default line numbering

#pragma warning disable 169
        public class MyClass
        {
            int neverUsedField;
        }
#pragma warning restore 169
    }

}
