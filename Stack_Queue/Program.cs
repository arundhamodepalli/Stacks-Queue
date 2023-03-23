using static Stack_Queue.CreateStack;

namespace Stack_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to stacks and queues");
            Stack<int> stack = new Stack<int>();

            stack.Push(56);
            stack.Push(30);
            stack.Push(70);
            Console.WriteLine(stack.Pop());
        }
    }
}