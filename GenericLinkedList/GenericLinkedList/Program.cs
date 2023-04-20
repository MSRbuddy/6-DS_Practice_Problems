namespace GenericLinkedList
{
    // generic linked list node
    public class GenericNode<T>
    {
        public T data;
        public GenericNode<T> nextNode = null;

        public GenericNode(T data)
        {
            this.data = data;
        }
    }

    // generic linked list
    public class GenericLinkedList<T>
    {
        private GenericNode<T> head = null;

        public void Add(T newListItem)
        {
            if (head == null)
            {
                head = new GenericNode<T>(newListItem);
            }
            else
            {
                GenericNode<T> curr = head;
                while (curr.nextNode != null)
                {
                    curr = curr.nextNode;
                }
                curr.nextNode = new GenericNode<T>(newListItem);
            }
        }

        public void DisplayNodes()
        {
            GenericNode<T> curr = head;
            while (curr != null)
            {
                Console.WriteLine(curr.data);
                curr = curr.nextNode;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Generic Class Custom Linked-List**********");
            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine("\nElements in the Linked-List:");
            GenericLinkedList<Object> genericll = new GenericLinkedList<Object>();
            genericll.Add(525);
            genericll.Add("Meghana");
            genericll.Add('D');
            genericll.Add(5.1f);
            genericll.Add(9876543210);
            genericll.Add("SoftwareEngineer");
            genericll.Add(true);
            genericll.DisplayNodes();
        }
    }
}