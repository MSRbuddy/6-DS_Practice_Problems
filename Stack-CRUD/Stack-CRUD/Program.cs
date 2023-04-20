using System.Collections;

namespace Stack_CRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Stack CRUD Operations!**********");
            Console.WriteLine("----------------------------------------------");

            // Creating a stack collection
            Stack stack = new Stack();
            //Adding item to the stack using the push method
            stack.Push(12);
            stack.Push(34);
            stack.Push(56);
            stack.Push(67);
            stack.Push(78);
            stack.Push(89);
            stack.Push(90);
            
            Console.WriteLine($"\nElements in Stack initially : {stack.Count}");
            //Printing the stack items using foreach loop
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            
            //Removing and Returning an item from the stack using the pop method
            Console.WriteLine($"\nDeleted Element: {stack.Pop()}");
            Console.WriteLine($"\nDeleted Element: {stack.Pop()}");
            //Printing item after removing the last item in stack
            Console.WriteLine($"\nStack Elements After Deletion: {stack.Count}");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            // Fetch the topmost element from Stack Using Peek method
            //stack.Peek();
            Console.WriteLine($"\nTopmost element of Stack is {stack.Peek()}");
            Console.WriteLine($"\nTotal elements present in stack : {stack.Count}");

            // Checking if 56 is present in the Stack or not
            if (stack.Contains(56))
            {
                Console.WriteLine("\nElement 56 is found");
            }
            else
            {
                Console.WriteLine("\nElement 56 is not found");
            }
            // Checking if 25 is present in the Stack or not
            if (stack.Contains(25))
            {
                Console.WriteLine("\nElement 25 is found");
            }
            else
            {
                Console.WriteLine("\nElement 25 is not found");
            }
            
            Console.WriteLine($"\nFinal Elements in Stack : {stack.Count}");
            //Printing the stack items using foreach loop
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}