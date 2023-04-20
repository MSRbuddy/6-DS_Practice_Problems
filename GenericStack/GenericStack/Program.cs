namespace GenericStack
{
    public class GenericNode<T>
    {
        public T data;
        public GenericNode<T> nextNode = null;

        public GenericNode(T data)
        {
            this.data = data;
        }
    }
    public class Stack<T>
    {
        private GenericNode<T> top;
        public Stack()
        {
            top = null;
        }
        public void push(T data)
        {
            GenericNode<T> newnode = new GenericNode<T>(data);
            newnode.nextNode = top;
            top = newnode;
        }
        public void pop()
        {
            if(top == null)
            {
                Console.WriteLine("Stack is empty!");
            }
            else
            {
                Console.WriteLine("\nRemoved element is : " + top.data);
                //Node temp = top;
                top = top.nextNode;             
            }
        }
        public void peek()
        {
            if(top == null)
            {
                Console.WriteLine("\nStack is empty!");
            }
            else
            {
                Console.WriteLine("Top element in stack is : " + top.data);
            }
        }
        public void Display()
        {
            if(top == null)
            {
                Console.WriteLine("Stack is empty!");
            }
            else
            {
                GenericNode<T> temp = top;
                while(temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp=temp.nextNode;
                }
            }
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Generic Class Custom Stack**********");
            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine("\nElements in the Stack:");
            Stack<Object> stack = new Stack<object>();
            stack.push(525);
            stack.push("Meghana");
            stack.push('D');
            stack.push(5.1f);
            stack.push(9876543210);
            stack.push("AssociateEngineer");
            stack.push(true);
            stack.Display();

            stack.peek();

            stack.pop();

            Console.WriteLine("\nAfter poping elements in the Stack:");
            stack.Display();
        }
    }
}