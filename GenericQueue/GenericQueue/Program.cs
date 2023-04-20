namespace GenericQueue
{
    public class GenericNode<T>
    {
        public T data;
        public GenericNode<T> front = null;
        public GenericNode<T> rear = null;
        public GenericNode<T> Next = null;

        public GenericNode(T data)
        {
            this.data = data;
        }
    }
    public class Queue<T>
    {
        GenericNode<T> front, rear, Next;
        public void Enqueue(T data)
        {
            GenericNode<T> newNode = new GenericNode<T>(data);
            if(front == null)
            {
                rear = newNode;
                front = rear;
            }
            else
            {
                rear.Next = newNode;
                rear = rear.Next;
            }
        }
        public void Dequeue()
        {
            if(this.front == null)
            {
                Console.WriteLine("Queue is empty, Deletion not possible!");
                return;
            }
            else
            {
                front = front.Next;
            }
        }
        public void Display()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is empty!");
            }
            else
            {
                GenericNode<T> temp = front;
                while(temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.Next;
                }
            }
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Generic Class Custom Queue**********");
            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine("\nElements in the Queue:");
            Queue<Object> que = new Queue<object>();
            que.Enqueue(525);
            que.Enqueue("Meghana");
            que.Enqueue('D');
            que.Enqueue(5.1f);
            que.Enqueue(9876543210);
            que.Enqueue("ProjectManager");
            que.Enqueue(true);
            que.Display();

            Console.WriteLine("\nAfter Dequeueing elements in Queue : ");
            que.Dequeue();
            que.Dequeue();
            que.Display();
        }
    }
}