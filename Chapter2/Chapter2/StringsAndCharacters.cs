using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter2
{
    internal static class StringsAndCharacters
    {
        static string x = "Hello world";
        static string y = "good day";
        #region
        public static void CharAndStringDiff()
        {
            char mySingleChar = 'q';
            char[] myMultiChar = { 'F', 'D', 'D', (char)0x301 /*Note this is Unicode for a char; in this case the apostrophe */, };
            string myStringText = new string(myMultiChar);
            Console.WriteLine(myMultiChar);
            Console.WriteLine(myStringText);
        }
        public static void StringExpression()
        {
            string c = "hello";
            string d = "lad";
            string res = $"{c} good morning {d}";
            Console.WriteLine(res);
        }

        public static void StringInterpoltationMgic()
        {
            string res = string.Format("{0} how you doing? having {1} people?", x, y);
            Console.WriteLine(res);
        }
        public static void FormateTheFloatPointsUsingPlaceholdersInInterpoltation()
        {
            int x = 10;
            double y = x / 1.33;
            string res = $"How you doing {x}? how many floats do you got y? {y:f2}";
            Console.WriteLine(res);
        }
        #endregion

        //Format specifiers with invariant culture
        public static void CustomStringFormatingUsingStringFomatable()
        {
            var myInterdPolatedString = $"{x}, How is your day? \n {y}"; /*passing the string this way does not work*/
            string formatAble = FormattableString.Invariant($"{x}, How is your day?\n{y}.");
            string formatAble2 = FormattableString.CurrentCulture($"{x}, How is your day?\n{y}.");
            Console.WriteLine(formatAble2);
        }
    }
}
