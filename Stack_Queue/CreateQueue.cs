using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue
{
    public class CreateQueue
    {
        public class Node
        {
            public int data;
            public Node next;
        }

        public class LinkedListQueue
        {
            private Node front;
            private Node rear;

            public void Enqueue(int data)
            {
                Node newNode = new Node();
                newNode.data = data;

                // append the new node to the rear of the queue
                if (rear == null)
                {
                    front = rear = newNode;
                }
                else
                {
                    rear.next = newNode;
                    rear = newNode;
                }
            }

            public int Dequeue()
            {
                if (front == null)
                {
                    throw new Exception("Queue is empty");
                }

                // remove and return the front node
                int data = front.data;
                front = front.next;

                if (front == null)
                {
                    rear = null;
                }

                return data;
            }

            public int Peek()
            {
                if (front == null)
                {
                    throw new Exception("Queue is empty");
                }

                // return the front node's data without removing it
                return front.data;
            }

            public bool IsEmpty()
            {
                return front == null;
            }
        }
    }
}
 
