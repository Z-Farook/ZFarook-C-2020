using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Chapter2
{
    internal static class CSharpOperators
    {
        public static string x = "Hello test";
        public static string y = "Hell world ";
        public static Func<string, string> AndOrOperatorCheking = (x) =>
        {
            /**The use of the && operator here is important, because if s is null, 
             * evaluating the expression s.Length would cause a runtime error.If we had used the *& operator*, 
             * the compiler would have generated code **that always evaluates both operands**, meaning that we would see a 
             * NullReferenceException at runtime if s is null; however, by **using the conditional AND operator, we avoid that**,
             * because the second operand, s.Length > 0, will be **evaluated only if s is not null** */

            var faildChek = "The check isn't passed";
            if (x != null && x.Length > 0)
            {
                var passedChek = $"{x} is passed because the length is greater than the 0. It is: {x.Length}";
                Console.WriteLine(passedChek);
                return passedChek;
            }
            Console.WriteLine(faildChek);
            return faildChek;
        };

        public static void UsingTrinarOperator(string x2)
        {
            /*Note here is no check for the NULL exception*/
            var res = (x.Length > x2.Length) ? x : x2;
            var mathFun = Math.Max(x.Length, x2.Length); /*returns the grater value */
            Console.WriteLine($"res: {res}");
            Console.WriteLine($"mathFun: {mathFun}");
        }

        public static void ExploitedTrinaryForNullException(string x2)
        {
            var countChars = x2 == null ? 0 : x2.Length;
            Console.WriteLine("Length: " + countChars);
        }

        //using the null conditional
        public static Func<string, string> ModernCheckOFNullWith_NullCconditiona = (x) =>
        {
            /** A modern way of checking the NullReferenceException: 
            *  If you write** s?.Length instead of just s.Length **, the compiler generates code
            *  that checks s for null first! So, you can avoid typing extra code the: x != null &&
            */
            var failedCheck = "The check isn't passed";
            if (x?.Length > 0)
            {
                var myX = $"{x}! Check is passed because the length is greater than the 0. x is: {x.Length}";
                Console.WriteLine(myX);
                return myX;
            }
            Console.WriteLine(failedCheck);
            return failedCheck;
        };

        /*The null-coalescing operator ?? returns the value of its left-hand operand if it isn't null; 
         * otherwise, it evaluates the right-hand operand and returns its result. The ?? operator doesn't 
         * evaluate its right-hand operand if the left-hand operand evaluates to non-null. 
         * -
         * In other words, if the variable or object is not null you get its original value 
         * otherwise the right side will be assigned to it!
         */
        internal static void YetBetterWayToHandelNulls_CoalescingOperator(string s)
        {
            string neverNull = s ?? "That was empty/null, I am in now! ;)";
            int? a = null;
            int b = a ?? -1;
            Console.WriteLine(b);  // output: -1
            Console.WriteLine(neverNull);
        }

        //Null-conditional and null coalescing operators
        internal static void Combination_NullConditionalAndNullCoalescing(string s)
        {
            /* if s != null (s? prevent nullExceptions) then the |original length of s| *else the LEFT SIDE "??" and that is 0*/
            int characterCount = s?.Length ?? 0;
            Console.WriteLine($"You have supplied {characterCount} chars");
        }

        public static void ConditionalOperatorAsArgument(bool goLongDrive)
        {
            var fuel = 10.5;
            var distance = 5.0;
            int neededFuelForDistance = (int)(fuel / (distance / 1.3));
            var destination = "Let go to London";
            var music = "50 cent";

            CarWarningScreen(fuel > neededFuelForDistance && goLongDrive ? fuel : neededFuelForDistance, destination, neededFuelForDistance, music);

        }

        private static void CarWarningScreen(double fuel, string destination, int neededFuelForDistance, string music)
        {
            Console.WriteLine($"Your fuel tank is having {fuel}L and your long drive name is: {destination}! \nYou want to listen {music}." +
                $" Keep in mind you need total of {neededFuelForDistance}L fuel for the full journey!");

        }
    }
}
