using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructure;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        { /*
           LinkedList List = new LinkedList();
            List.add(56);
            List.add(30);
            List.add(70);
            // List.pop();
            // List.popLast();
            //int num = List.size();
            //Console.WriteLine(num);
            //List.isEmpty();

            // List.search(30);
            //List.getFirstElement();
            //List.append(40);
            List.push(27);
            List.Display();


            // List.InsertElementatParticularpostion(2, 30);
           
            LinkedListStack linkedliststack = new LinkedListStack();
            linkedliststack.push(70);
            linkedliststack.push(30);
            linkedliststack.push(56);
            linkedliststack.push(40);
            //linkedliststack.display();
            //linkedliststack.peek();
            linkedliststack.pop();

            linkedliststack.isEmpty();
            linkedliststack.display();
             */

            LinkedListQueue queue = new LinkedListQueue();
            queue.enqueue(30);
            queue.enqueue(20); 
            queue.enqueue(10);
            
          // int length = queue.size(); 
           // Console.WriteLine();
           // Console.WriteLine(length);
            //queue.dequeue();
            queue.display();

        }
    }
}