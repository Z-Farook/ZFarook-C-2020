using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;

namespace Chapter2
{
    internal static class CommentAndWhiteSpaces
    {
        //I am a single line comment line!

        /*I am a multi lime comment:
         *c
         *a
         *x
         *y
         *
        */

        /*I can also be a form of delimited comments see below*/

        internal static void myDelimitedCommnet()
        {
            Console.WriteLine(/*i am ignored*/ "the text behind this is ignored ");

            //There are some problems when using multi line comment see the next lines:
            
            Console.WriteLine("This will run");    /* This comment includes not just the
                Console.WriteLine("This won't");      * text on the right, but also the text
                Console.WriteLine("Nor will this");    /* on the left except the first and last
                Console.WriteLine("Nor this");          * lines. */
            Console.WriteLine("This will also run");
        }
    }
}
