using System;
using System.Collections;

// Stack Implementation Source: https://www.geeksforgeeks.org/implementing-stack-c-sharp/
// Queue Implementation Source: https://www.tutorialspoint.com/csharp/csharp_queue.htm

namespace StackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            // STACK
            // create a new stack object
            Stack myStack = new Stack();

            // formatting
            Console.WriteLine("====================================");
            Console.WriteLine("Stack:");
            Console.WriteLine("====================================");

            // push 4 items on to the stack
            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40);
            // print the contents of the stack
            myStack.PrintStack();
            // show the topmost element of the stack
            myStack.Peek();
            // pop the top element off the stack
            Console.WriteLine("Item popped from Stack : {0}", myStack.Pop());
            // show the contents of the stack again
            myStack.PrintStack();

            // formatting
            Console.WriteLine("====================================");
            // formatting
            Console.WriteLine("====================================");

            // wait for user input to close program
            Console.ReadLine();
        }
    }
    // Stack data structure implementation class
    internal class Stack
    {
        static readonly int MAX = 1000;
        int top;
        int[] stack = new int[MAX];

        bool IsEmpty()
        {
            return (top < 0);
        }
        public Stack()
        {
            top = -1;
        }
        // Push: Adds an item in the stack. If the stack is full, then it is said to be a stack Overflow condition.
        internal bool Push(int data)
        {
            if (top >= MAX)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            else
            {
                stack[++top] = data;
                return true;
            }
        }
        // Pop: Removes an item from the stack. The items are popped in the reversed order in which they are pushed. If the stack is empty, then it is said to be a stack Underflow condition.
        internal int Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }
            else
            {
                int value = stack[top--];
                return value;
            }
        }
        // Peek : Return the topmost element of stack.
        internal void Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
                Console.WriteLine("The topmost element of Stack is : {0}", stack[top]);
        }
        // PrintStack : Prints the contents of the stack
        internal void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
    }
}