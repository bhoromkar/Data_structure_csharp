using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class LinkedListQueue
    {
        Node head = null;

        internal int dequeue()
        {
            if (head == null) // If the queue is empty
            {
                Console.WriteLine("Queue is empty");
            }

            int item = head.data;
            head = head.next;

            return item;
        }
    




    


    internal void display()
        {
            Node temp = this.head;
            if(temp ==null)
                  {
                Console.WriteLine("queue is empty");
            }
            while(temp != null) 
            {
                Console.Write(temp.data + " ->");
                temp = temp.next;   
            }
        }

        internal void enqueue(int data)
        {
            Node node = new Node(data);
         if (head == null)
            {
                head = node;    
            }
            else
            {
                Node temp = head; 
                while(temp.next != null)
                {
                    temp= temp.next;    

                }
                temp.next = node;
            
            }

        }
        internal int size()
        {
            int count = 0;
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("queue is empty");
            }
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count; 
        }
    }
}
