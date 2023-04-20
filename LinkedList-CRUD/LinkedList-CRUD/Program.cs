namespace LinkedList_CRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Linked-List CRUD Operations!**********");
            Console.WriteLine("---------------------------------------------------");

            // Creating a linkedlist using LinkedList class
            LinkedList<String> Llist = new LinkedList<String>();

            // Adding elements in the LinkedList using AddLast() method
            Llist.AddFirst("Ananya");
            Llist.AddFirst("Srishanth");
            Llist.AddFirst("PranavAdithya");
            Llist.AddFirst("Shravan");
            Llist.AddFirst("Avinash");
            Llist.AddLast("Keerthi");
            Llist.AddLast("Meghana");
            Llist.AddLast("Bhargavi");
            Llist.AddLast("Bharath");

            // Initial number of elements
            Console.WriteLine("\nEmployees of XYZ Company initially : ");

            // Accessing the elements of Linkedlist Using foreach loop
            foreach (var item in Llist)
            {
                Console.WriteLine(item);
            }

            // After using Remove(LinkedListNode) method
            Console.WriteLine("\nAfter using Remove(LinkedListNode) method, Employees of XYZ Company : ");
            Llist.Remove(Llist.First);
            foreach (var item in Llist)
            {
                Console.WriteLine(item);
            }

            // After using Remove(T) method
            Console.WriteLine("\nAfter using Remove(T) method, Employees of XYZ Company : ");
            Llist.Remove("Shravan");
            foreach (var item in Llist)
            {
                Console.WriteLine(item);
            }

            // After using RemoveFirst() method
            Console.WriteLine("\nAfter using RemoveFirst() method, Employees of XYZ Company : ");
            Llist.RemoveFirst();
            foreach (var item in Llist)
            {
                Console.WriteLine(item);
            }

            // After using RemoveLast() method
            Console.WriteLine("\nAfter using RemoveLast() method, Employees of XYZ Company : ");
            Llist.RemoveLast();
            foreach (var item in Llist)
            {
                Console.WriteLine(item);
            }

            // After using Clear() method
            Llist.Clear();
            Console.WriteLine("\nAfter using Clear() method, Employees of XYZ Company : {0}", Llist.Count);           
        }
    }
}