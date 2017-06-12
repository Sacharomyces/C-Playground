using System.Collections;

namespace Generics.LinkedList
{
    public class LinkedList :IEnumerable
    {
        public LinkedListNode First { get; private set; }
        public LinkedListNode Last { get; private set; }

        public LinkedListNode Add (object node)
        {
            var newNode = new LinkedListNode(node);

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


        public IEnumerator GetEnumerator()
        {
            var current = First;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
    }
}