using System.Collections;
using System.Collections.Generic;

namespace Generics.LinkedList.Generic
{
    public class LinkedList<T> :IEnumerable<T>
    {
        public LinkedListNode<T> First { get; private set; }
        public LinkedListNode<T> Last { get; private set; }

        public LinkedListNode<T> Add (T node)
        {
            var newNode = new LinkedListNode<T>(node);

            if (First == null)
            {
                First = newNode;
                Last = First;
            }
            else
            {
                var previousNode = Last;
                Last.Next = newNode;
                Last = newNode;
                Last.Prev = previousNode;

            }

            return newNode;

        }


        public IEnumerator<T> GetEnumerator()
        {
            var current = First;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();



    }
}