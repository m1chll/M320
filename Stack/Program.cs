namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringStack stack = new StringStack(3);

            stack.Push("One");
            stack.Push("Two");
            stack.Push("Three");

            stack.Clear();

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

        }
    }
}