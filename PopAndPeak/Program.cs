using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackAndQueue;

namespace PopAndPeak
{
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");
                LinkedListStack linkedListStack = new LinkedListStack();
                linkedListStack.Push(70);
                linkedListStack.Push(30);
                linkedListStack.Push(56);
                linkedListStack.Display();
                linkedListStack.Peek();
                linkedListStack.Pop();
                linkedListStack.IsEmpty();
                linkedListStack.Display();
                Console.ReadKey();
            }

        }
    }
