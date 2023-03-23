using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue
{
    internal class DequeueStack
    {
        public class Node
        {
            public int data;
            public Node next;
        }

        public class LinkedListQueue
        {
            private Node head;

            public void Enqueue(int data)
            {
                Node newNode = new Node();
                newNode.data = data;

                // If the head is null, then the queue is empty and the new node becomes the head
                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    // Traverse the list until the last node is found and add the new node to the end
                    Node current = head;
                    while (current.next != null)
                    {
                        current = current.next;
                    }
                    current.next = newNode;
                }
            }

            public int Dequeue()
            {
                if (head == null)
                {
                    throw new Exception("Queue is empty");
                }

                // Remove the head node and return its data
                int data = head.data;
                head = head.next;

                return data;
            }

            public int Peek()
            {
                if (head == null)
                {
                    throw new Exception("Queue is empty");
                }

                // Return the data of the head node without removing it
                return head.data;
            }

            public bool IsEmpty()
            {
                return head == null;
            }
        }
    }
}
