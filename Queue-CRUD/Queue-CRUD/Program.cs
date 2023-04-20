using System.Collections;

namespace Queue_CRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Queue CRUD Operations!**********");
            Console.WriteLine("----------------------------------------------");

            //Creating a queue collection
            Queue queue = new Queue();
            //Adding item to the queue using the Enqueue method
            queue.Enqueue('D');
            queue.Enqueue('A');
            queue.Enqueue('M');
            queue.Enqueue('E');
            queue.Enqueue('G');
            queue.Enqueue('H');
            queue.Enqueue('A');
            queue.Enqueue('N');
            queue.Enqueue('A');
            //Printing the queue items using foreach loop
            foreach (var item in queue)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine($"\nNo.of Queue Elements initially : {queue.Count}");

            //Removing and Returning an item from the queue using the Dequeue method
            Console.WriteLine($"\nDeleted Element: {queue.Dequeue()}");
            //Printing item after removing the first item
            Console.WriteLine($"\nQueue Elements After Deletion: Count {queue.Count}");
            foreach (var item in queue)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine($"\n\nDeleted Element: {queue.Dequeue()}");
            //Printing item after removing the first item
            Console.WriteLine($"\nQueue Elements After Deletion: Count {queue.Count}");
            foreach (var item in queue)
            {
                Console.Write(item + " ");
            }

            // Fetch the topmost element from Queue Using Peek method
            Console.WriteLine($"\n\nFirst Element of Queue is : {queue.Peek()}");
            Console.WriteLine($"\nTotal Elements present in Queue : {queue.Count}");

            Console.WriteLine("\nChecking if the given element is present in the queue or not : ");
            // Checking if the element Hello is present in the Stack or not
            if (queue.Contains('A'))
            {
                Console.WriteLine("\nElement A is found");
            }
            else
            {
                Console.WriteLine("\nElement A is not found");
            }
            if (queue.Contains('B'))
            {
                Console.WriteLine("\nElement B is found");
            }
            else
            {
                Console.WriteLine("\nElement B is not found");
            }

            //Printing Items After Clearing the Queue
            queue.Clear();
            Console.WriteLine($"\nQueue Elements After Clear Operation: {queue.Count}");
            foreach (var item in queue)
            {
                Console.Write(item + " ");
            }
        }
    }
}