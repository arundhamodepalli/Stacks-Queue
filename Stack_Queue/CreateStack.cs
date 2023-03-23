using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue
{
    internal class CreateStack
    {
        public class Node
        {
            public int data;
            public Node next;
        }

        public class LinkedListStack
        {
            private Node top;

            public void Push(int data)
            {
                Node newNode = new Node();
                newNode.data = data;

                // add the new node to the top of the stack
                newNode.next = top;
                top = newNode;
            }

            public int Pop()
            {
                if (top == null)
                {
                    throw new Exception("Stack is empty");
                }

                // remove and return the top node
                int data = top.data;
                top = top.next;
                return data;
            }

            public int Peek()
            {
                if (top == null)
                {
                    throw new Exception("Stack is empty");
                }

                // return the top node's data without removing it
                return top.data;
            }
        }
    }
}
