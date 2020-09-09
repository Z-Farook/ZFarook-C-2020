using System;
using System.Collections;
using System.Collections.Generic;

namespace BasicsOfArrays
{
    #region implicit  and explicit IEnumerator
    /**When we use the for each statement then the compiler do some calling to different thing one of those is the method called: GetEnumerator() */


    /*The *default iteration *supported by* a class *is the *GetEnumerator method, which is defined to return IEnumerator.
      * Named iterations custom named return IEnumerable.*/
    internal class TheMigicHolder
    {
        public TheMigicHolder(int[] testX)
        {
            MyArr = testX;
        }

        public static int[] MyArr { get; private set; }


        /// <summary>
        /// *default iteration *supported by* a class *is the *GetEnumerator method, *which is defined to return IEnumerator
        /// </summary>
        /// <returns>IEnumerator</returns>
        public IEnumerator<int> GetEnumerator()
        {
            Console.WriteLine($"I, {nameof(GetEnumerator)}, am always called. And I return an IEnumerator type defined by the yield return statement" +
                $" and this time it was: {MyArr.GetType()} ");
            for (int i = 0; i < MyArr.Length; i++)
            {
                yield return MyArr[i];
            }
        }

        /// <summary>
        /// Named iterations custom named return IEnumerable.
        /// </summary>
        /// <returns> IEnumerable<int> </returns>
        public IEnumerable<int> Not_Default_Iterator_For_ForEach()
        {
            Console.WriteLine($"I, {nameof(Not_Default_Iterator_For_ForEach)}, am *not default* And I DO NOT RETURN AN IENUMERATOR " +
                $"but IEnumerABLE type defined by the yield return statement" +
               $" and this time it was: {MyArr.GetType()} ");
            for (int i = MyArr.Length - 1; i >= 0; i--)
            {
                yield return MyArr[i];
            }
        }

        /// <summary>
        /// Named iterations custom named return IEnumerable.
        /// </summary>
        /// <returns> IEnumerable<int> </returns>
        public IEnumerable<int> NotReverse()
        {
            for (int i = 0; i < MyArr.Length; i++)
            {
                yield return MyArr[i];
            }
        }
    }
    #endregion

    #region For C# Compiler generating *yield type* behind the scene 
#if true

    /** To see how things are working put a line break in the main method on the line:  foreach (var item in compilerMagic) 
     * and Run in the debug mode */
    public class EnumeratorsPalceHolder
    {
        /**The GetEnumerator method of the outer class INSTANTIATES and RETURNS a new yield type. */
        public IEnumerator GetEnumerator() => new Enumerator(0);


        /**The yield type (in this case it's called Enumerator) implements the properties and methods of the interfaces IENUMERATOR
         * and IDISPOSABLE. See, the YIELD TYPE AS the inner CLASS Enumerator*/
        public class Enumerator : IEnumerator<string>, IEnumerator, IDisposable
        {
            private int _state;
            private string _current;
            public Enumerator(int state) => _state = state;
            bool System.Collections.IEnumerator.MoveNext()
            {
                switch (_state)
                {
                    case 0:
                        _current = "Hello";
                        _state = 1;
                        return true;
                    case 1:
                        _current = "World";
                        _state = 2; return true;
                    case 2:
                        break;
                }
                return false;
            }
            void System.Collections.IEnumerator.Reset() => throw new NotSupportedException();
            string System.Collections.Generic.IEnumerator<string>.Current => _current;
            object System.Collections.IEnumerator.Current => _current;
            void IDisposable.Dispose() { }
        }
#endif
        #endregion

    }
}
