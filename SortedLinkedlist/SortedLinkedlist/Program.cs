namespace SortedLinkedlist
{
    public class LinkedList
    {
        Node head; // head of list

        // Linked list Node
        class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }
        //function to insert a new_node in a list.
        void sortedInsert(Node newNode)
        {
            Node current;

            // Special case for head node 
            if (head == null || head.data <= newNode.data)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                // Locate the node before point of insertion. 
                current = head;
                while (current.next != null && current.next.data > newNode.data)
                {
                    current = current.next;
                }
                newNode.next = current.next;
                current.next = newNode;
            }
        }

        // Utility functions

        // Function to create a node 
        Node newNode(int data)
        {
            Node x = new Node(data);
            return x;
        }

        // Function to print linked list 
        void printList()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        static void Main(string[] args)
        {
            LinkedList llist = new LinkedList();
            Node newNode;

            Console.WriteLine("*****Created a Sorted(descending order) LinkedList*****");
            Console.WriteLine("----------------------------------------------------------");

            newNode = llist.newNode(1);
            llist.sortedInsert(newNode);

            newNode = llist.newNode(10);
            llist.sortedInsert(newNode);

            newNode = llist.newNode(7);
            llist.sortedInsert(newNode);

            newNode = llist.newNode(3);
            llist.sortedInsert(newNode);

            Console.WriteLine("\nInitial Elements in Linked List : ");
            llist.printList();

            //inserting a newNode = 5 in a existing LinkedList
            newNode = llist.newNode(5);
            llist.sortedInsert(newNode);
            
            Console.WriteLine("\n\nAfter inserting 5, Linked List : ");
            llist.printList();

            //inserting a newNode = 9 in a existing LinkedList
            newNode = llist.newNode(9);
            llist.sortedInsert(newNode);

            Console.WriteLine("\n\nAfter inserting 9, Linked List : ");
            llist.printList();

            Console.WriteLine();
        }
    }
}