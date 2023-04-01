namespace MyLibraryClass.NET6.Collections
{
    public class Queues
    {
        public void Examples()
        {
            // FIFO: First In - First Out
            Queue<string> queue = new();
            
            queue.Enqueue("val 1");
            queue.Enqueue("val 2");
            queue.Enqueue("val 3");

            queue.Dequeue();
            queue.Dequeue();

            foreach(var val in queue)
            { 
                Console.WriteLine(val);
            }
        }
    }
}