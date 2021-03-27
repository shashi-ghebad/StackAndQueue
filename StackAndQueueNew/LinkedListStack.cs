using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    class LinkedListStack
    {
        private Node top;
        public LinkedListStack()
        {
            this.top = null;
        }

        //30
        internal void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
                node.next = null;
            else
                node.next = this.top;//1300
            this.top = node;
            Console.WriteLine("{0} pushed to stack ", value);
        }
        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;//1400
            }
        }

    }

}