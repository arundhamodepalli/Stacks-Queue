using static Stack_Queue.CreateStack;

namespace Stack_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to stacks and queues");
            LinkedListStack stack = new LinkedListStack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            Console.WriteLine(stack.Peek());
        }
    }
}