namespace MyLibraryClass.NET6.Collections
{
    public class Stacks
    {
        public void Examples()
        {
            // LIFO: Last In - First Out 
            Stack<string> stack = new();

            stack.Push("val 1");
            stack.Push("val 2");
            stack.Push("val 3");

            stack.Pop();
            stack.Pop();

            foreach(var val in stack)
            {
                Console.WriteLine(val);
            }
        }
    }
}