using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter2
{

    internal static class ControlFlow
    {

        public static void WannaDrink(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine($"Age: {age}, Cheers boy!");
            }
            else
            {
                Console.WriteLine($"Age: {age}, Grow up first kid!!");
            }
        }

        public static void IfStatementWithOutBlock(int age)
        {
            if (age >= 18)
                Console.WriteLine("Your age test passed, you got a beer!");
            WannaDrink(age); /*Note what kind if condition will also execute this code too?*/
            /*Here you cannot write the else block because there is no {} after the if statement */
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage(
          "Style",
          "IDE0011:Add braces",
          Justification = "This example deliberately shows the wrong way to do it")]

        //Not how it the second method will get called even you passed a false argument to the method
        internal static void DangrousIfStatement(bool launchCodesCorrect)
        {
            if (launchCodesCorrect)
                TurnOnMissileLaunchedIndicator();
            LaunchMissiles();
        }

        private static void LaunchMissiles()
        {
            Console.WriteLine("peheoooooooooooooooooooooooooooooooooooof");
        }

        private static void TurnOnMissileLaunchedIndicator()
        {
            Console.WriteLine("Code is correct");
        }

        public static void MoreThanTowIfElse(int x)
        {
            if (x >= 18)
            {
                Console.WriteLine($"You are almost a man since you got {x}");
            }
            /*Note we could also have written one block of extra {} after and then put the 2nd if in that. But we  have written the short form*/
            else if (x <= 18 && x >= 14)
            {
                Console.WriteLine($"You are a teenage boy! you are {x}");
            }
            else
            {
                Console.WriteLine($"Your too young kid!!");
            }
        }

        public static void SwithchWithStringInput(string x)
        {
            switch (x.ToLower())
            {
                case "dance":
                case "happy": /*second statement! here we don't need any blocks unlike if statements*/
                    Console.WriteLine($"You got me hear roar, oh ah auh auh");
                    break;
                case "sad":
                    Console.WriteLine($"You got drink beer?");
                    break;
                case "optimist":
                    Console.WriteLine($"You are enlightened");
                    break;
                case "pessimist":
                    Console.WriteLine($"Put a smile on your face every thing gonna be alright");
                    break;
                default:
                    Console.WriteLine($"Boring time, show us some human emotions dude");
                    break;
            }
        }

        public static void IllegalSwitchFallThrough(int x)
        {
#if false

            switch (x)
            {
                /*This will not work because you must have one case evaluating to true and from there you can do 
                 * whatever you want like: call 2 different method, but evaluating 2 case to true is not possible */
                case 2: 
                    Console.WriteLine("Even number");
                case 3:
                    Console.WriteLine("Not even number");
                default:
                    break;
            }
            Console.WriteLine();
#endif
        }

        /*The following is allowing to achieve the "fall through" */
        public static void FallThroughUsingGoTo(int x)
        {
            switch (x)
            {
                case 1:
                    Console.WriteLine($"It was case: {x}");
                    goto case 2;
                case 2:
                    Console.WriteLine($"I am from the fall trough case ");
                    break;
                default:
                    Console.WriteLine($"It, {x}, was in no case");
                    Console.WriteLine($"Nothing is happened ");
                    break;
            }
        }

        public static void WhileLoop(int x)
        {
            while (x > 0)
            {

                if (x % 2 == 0)
                {
                    Console.WriteLine($"{x} is even number!");

                }
                x -= 1;
            }
        }

        /*The consequence of wrongfully using a comma*/
        public static void MakingTheWhileLoopInfinateByUsingSemicolon(int x)
        {
            while (x > 0) ; /*Note this comma is problematic. The editor is also indicating it!!!*/
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine($"{x} is even number!");
                    Console.WriteLine($"All the code below this won't run");
                }
                x -= 1;
            }
            Console.WriteLine();
        }

        internal static void DoLoop()
        {
            char k;
            do
            {
                Console.WriteLine("Press x to exit");
                k = Console.ReadKey().KeyChar;
            }
            while (k != 'x');
        }

        public static void ForLooPInAction(int x)
        {
            var arr = new int[x];
            for (int i = 0; i < x; i++)
            {
                var filledArr = arr[i] = i + 1;
                Console.WriteLine(filledArr);
            }
        }

        public static void ForLooPWithMoreThan1Initialzer(int x)
        {
            var arr = new int[x];

            /*Note, the j does not defined it's own type AND used comma instead of semicolon 
             * both in the initialization and iteration*/
            for (int i = 0, j = 0; i < x; i++, j++)
            {
                var filledArr = arr[i] = j;
                Console.WriteLine(filledArr);
            }
        }

        public static void NestdForLooP(int argX, int argY)
        {
            var x = new int[argX, argY];
            int counter = 1;
            for (int j = 0; j < /*gets length of 1st dimension*/ x.GetLength(0); j++)
            {
                for (int i = 0; i < /*gets length of 2nd dimension*/ x.GetLength(1); i++)
                {
                    x[j, i] = counter * 2;
                    counter++;
                    Console.Write(x[j, i] + ", ");
                    //Console.Write(counter + " " );
                }
            }
        }

        public static void ItrateOveCollectionWithForeach(int x)
        {
            var arr = new int[x];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
            foreach (var item in arr)
            {
                Console.Write($"{item }, ");

            }
        }

        public static void IsForeachBetterThanFor (IEnumerable<string> messages)
        {
            /*Note how this is ACHIEVED WITH FOR LOOP that MORE code and your are still not able to mutate the value in the object itself */
            for (int i = 0; i < messages.Count(); i++)
            {
                string res = messages.ElementAt(i);
                res = res + "ad";
                Console.Write(res + ", ");
            }
            /*so this seems batter choice*/
            foreach (string message in messages)
            {
                Console.Write(message + " ");
            }
        }

    }
}
