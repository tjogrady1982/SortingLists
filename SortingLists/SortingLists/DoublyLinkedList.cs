using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingLists
{
    public class DoublyLinkedList
    {
        public class Node
        {
            public Node previous = null;
            public Node next = null;
            public object data;

            public Node Next
            {
                get { return next; }
                set { next = value; }
            }

            public Node Previous
            {
                get { return previous; }
                set { previous = value; }
            }

            public Object Data
            {
                get { return data; }
                set { data = value; }
            }

            public Node(object value)
            {
                data = value;
            }
        }

        int _length;
        Node _head;

        public int Length
        {
            get { return _length; }
        }


        public DoublyLinkedList()
        {
            _length = 0;
            _head = null;
        }

        public void Add(object value)
        {
            Console.WriteLine(String.Format("Add node [{0}].", value.ToString()));
            // Create a new Node with given data;
            Node newNode = new Node(value);
            Node current = _head;
            if (_head == null)
            {
                newNode.previous = null;
                _head = newNode;
            }
            else
            {
                // Traverse till the end of the list.
                while (current.Next != null)
                {
                    current = current.Next;
                }
                // Add new node as the next node to the last node.
                current.Next = newNode;
                newNode.Previous = current;
            }
            _length++;
        }

        public void Delete(object value)
        {
            Console.WriteLine();
            Console.WriteLine(String.Format("Delete node [{0}].", value.ToString()));
            // Find the node to be deleted. 
            Node current = _head;

            if (current != null)
            {
                // Handle the case for 'head' node when first node matches the node to be deleted.
                if (current.Data == value)
                {
                    // If first node is not the only node
                    if (current.Next != null)
                    {
                        current = current.Next;
                        current.Previous = null;
                    }
                    else
                    {
                        current = null;
                        
                    }
                    _head = current;
                    _length--;
                }
                else
                {
                    while (current.Next != null && current.Next.Data != value)
                    {
                        current = current.Next;
                    }
                    if (current.Next != null && current.Next.Data == value)
                    {
                        // Set the next pointer of the previous node to be the node next to the one that is being deleted.
                        if (current.Next.Next != null)
                        {
                            current.Next = current.Next.Next;
                            current.Next.Previous = current;
                        }
                        else
                        {
                            current.Next = null;
                        }
                        
                        // Delete the node
                        current = null;
                        _length--;
                    }
                    else
                    {
                        Console.WriteLine(value.ToString() + " could not be found in the list.");
                    }
                }
            }
        }
        public void Find(object value)
        {
            Console.WriteLine(String.Format("Find node [{0}].", value.ToString()));
            Node current = _head;
            if (current != null)
            {
                int counter = 1;
                while (current.Next != null && current.Data != value)
                {
                    current = current.Next;
                    counter++;
                }
                if (current.Data == value)
                {
                    Console.WriteLine(String.Format("Found {0} in the list at position [{1}].", value.ToString(), counter.ToString()));
                }
                else
                {
                    Console.WriteLine(String.Format("{0} was not found in the list.", value.ToString()));
                }
            }
            else
            {
                Console.WriteLine(String.Format("{0} was not found in the list.", value.ToString()));
            }
        }
        public void ShowNodes()
        {
            // Print all nodes till the end of the list.
            Node current = _head;
            if (current == null)
            {
                Console.WriteLine("No nodes to display.");
                Console.WriteLine();
            }
            else
            {

                while (current != null)
                {
                    Console.WriteLine("Node: " + current.Data);
                    current = current.Next;
                }
                Console.WriteLine();
            }
        }
    }
}
