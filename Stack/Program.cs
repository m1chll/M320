namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new GenericStack<char>(3);

            stack.Push('O');
            stack.Push('n');
            stack.Push('e');


            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}