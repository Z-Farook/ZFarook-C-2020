using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GenericsBasics
{
    #region For C# Non Generic classes
#if true

    public class NonGenericListNode
    {
        public NonGenericListNode(object v) => Value = v;

        public object Value { get; }

        public NonGenericListNode Next { get; internal set; }
        public NonGenericListNode Previous { get; internal set; }
    }

    public class NonGenericLinkedList : IEnumerable
    {
        public NonGenericListNode First { get; private set; }

        public NonGenericListNode Last { get; private set; }

        public NonGenericListNode AddLast(object obj)
        {
            var newNode = new NonGenericListNode(obj);
            if (First == null)
            {
                First = newNode;
                Last = First;
            }
            else
            {
                Last.Next = newNode;
                Last = newNode;

            }

            return newNode;
        }

        public IEnumerator GetEnumerator()
        {
            var current = First;
            while (current != null)
            {
                yield return current.Value; //yield statement for creating an enumerator type
                current = current.Next;
            }
        }
    }

#endif
    #endregion
}
