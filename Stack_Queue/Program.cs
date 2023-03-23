using static Stack_Queue.CreateStack;
using static Stack_Queue.DequeueStack;

namespace Stack_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to stacks and queues");
            LinkedListQueue queue = new LinkedListQueue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            Console.WriteLine("Front value of the queue: " + queue.Peek());
            while (!queue.IsEmpty())
            {
                Console.WriteLine("Dequeued value from queue: " + queue.Dequeue());
            }
        }
    }
}