using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace GenericsBasics
{
    #region For C# Generic classes
#if true

    public class GenericLikedListNode<T>
    {
        public GenericLikedListNode(T value)
        {
            Value = value;
        }

        public T Value { get; }

        public GenericLikedListNode<T> Next { get; set; }

        public GenericLikedListNode<T> Previous { get; set; }
    }

    public class GenericLinkedList<T> : IEnumerable<T>
    {
        //very very important to know is that the TYPE OF FIELlds will be the SAME AS that of this CLASS ITSELF because THE SAME T is being used in the: <>
        public GenericLikedListNode<T> First { get; private set; }

        public GenericLikedListNode<T> Last { get; private set; }

        //very very important to know is that the TYPE OF PARAMETER will be the SAME AS that of this CLASS ITSELF
        public GenericLikedListNode<T> AddLast(T nodeToAdd)
        {
            var newNode = new GenericLikedListNode<T>(nodeToAdd);
            if (First == null)
            {
                First = newNode;
                Last = First;
            }
            else
            {
                GenericLikedListNode<T> previous = Last;
                Last.Next = newNode;
                Last = newNode;
                Last.Previous = previous;

            }
            return newNode;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = First;
            while (current != null)
            {
                yield return First.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }

#endif
    #endregion
}




