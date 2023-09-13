using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class LinkedList
    {
        internal Node head;
        internal Node tail;
        internal void add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine(node.data);
        }

        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("linked list is empty");
                return;
            }

            while (temp != null)
            {
                Console.Write(temp.data + " -> ");
                temp = temp.next;
            }
            Console.WriteLine();

        }
        public int elementAtPosition(int position)
        {
            if (head == null)
            {
                Console.WriteLine("it is empty");
            }

            Node current = this.head;
            int currentPosition = 0;

            while (current != null)
            {
                if (currentPosition == position)
                {
                    Console.WriteLine(current.data);
                }

                current = current.next;
                currentPosition++;
            }
            return currentPosition;
        }

        internal Node InsertElementatParticularpostion(int Position, int data)
        {
            if (Position < 1)
            {
                Console.WriteLine(" Invalid Position");
            }
            if (Position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                this.head = newNode;
            }
            else
            {
                while (Position-- != 0)
                {
                    if (Position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if (Position == 1)
                    Console.WriteLine("position out of range");
            }
            return head;
        }

        internal void pop()
        {
            Node temp = head;
            head = head.next;

        }

        internal Node popLast()
        {
            if (head == null)
            {
                return null;
            }
            if (head.next == null)
            {
                return null;
            }
            Node newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return head;
        }

        public int size()
        {

            Node temp = this.head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }

        public void isEmpty()
        {
            Node temp = this.head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            if (count == 0)
            {
                Console.WriteLine("list is empty");
            }
            else
            {
                Console.WriteLine("list is not empty");
            }

        }
        public void search(int data)
        {
            Node temp = head;
            while (temp != null)
            {
                if (temp.data.Equals(data))
                {
                    Console.WriteLine("the data is found");
                }
                temp = temp.next;
            }
        }

            public void getFirstElement()
        {
            Node temp = head;
            int value;
            if (head == null)
            {
                Console.WriteLine("list is empty");
            }
            else if (head != null)
            {
                value = head.data;
                Console.WriteLine(value);
            }

        }
        public void append(int data)
    
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = newNode;
            }
        }

        public void push(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
        }
    }

 }

    


