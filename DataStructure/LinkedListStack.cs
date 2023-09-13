using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructure
{
    internal class LinkedListStack
    {
        private Node top;
        public LinkedListStack()
        {
            this.top = null;
        }

        internal void display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp=temp.next;
            }
        }

        internal void isEmpty()
        {
            if (this.top != null)
            {
                peek();
                pop();
            }
        }

        internal void peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("stack is empty");
                return;
            }
            Console.WriteLine(this.top.data);

        }

        internal void pop()
        {
           if(this.top == null)
            {
                Console.WriteLine("deletation is not possible");
                return;
            }
            Console.WriteLine(this.top.data);
            this.top= this.top.next;
           

            }
        

        internal void push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
            {
               node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            
        }

    }
}
