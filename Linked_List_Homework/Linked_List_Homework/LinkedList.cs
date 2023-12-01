using System;

namespace Linked_List_Homework
{
    public class LinkedList
    {
        public Node First { get; set; }

        public void Print()
        {
            Node move = First;
            while (move != null)
            {
                Console.Write(move.Data+"\t");
                move = move.Next;
            }
            Console.WriteLine();
        }

        // methods
        public void Add(int val)
        {
            // TODO: add item to the end of the list

         
            Node newNode = new Node(val);

           
            if (First == null)
            {
                First = newNode;
            }
            else
            {
            
                Node last = First;
                while (last.Next != null)
                {
                    last = last.Next;
                }

                last.Next = newNode;
            }
            // consider when the list is empty

            // create a new node with the given data
        }
        public void RemoveKey(int key)
        {
            // TODO: search for the key and remove it from the list

            if (First == null)
            { 
                return;
            }

            if (First.Data == key)
            {
                First = First.Next;
                return;
            }
            Node current = First;
            Node previous = null;

            while (current != null && current.Data != key)
            {
                previous = current;
                current = current.Next;
            }

           
            if (current == null)
            {
               
                return;
            }

            previous.Next = current.Next;

            // consider when the key does not exist and when the list is empty
        }

        public void Merge(LinkedList other)
        {
            // TODO: merge this list with the other list

            
                // TODO: merge the current list with the otherList
                // consider when either list is empty

                
                if (First == null)
                {
                    First = other.First;
                    return;
                }

               
                if (other.First == null)
                {
                    return;
                }

               
                Node current = First;
                while (current.Next != null)
                {
                    current = current.Next;
                }

                
                current.Next = other.First;
            
        }
        public void Reverse()
        {
            // TODO: revers the nodes of this list

            
            if (First == null || First.Next == null)
            {
                return;
            }

            Node prev = null;
            Node curr = First;
            Node next = null;

            while (curr != null)
            {
             
                next = curr.Next;

                curr.Next = prev;

                prev = curr;
                curr = next;
            }

            First = prev;
            
            // initialize three pointers: prev, curr, and next
        }
    }
}
