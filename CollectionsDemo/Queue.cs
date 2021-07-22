using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class Queue
    {
        public static void QueueDemo()
        {
            Queue<string> queue = new Queue<string>();
            //Adding the elements into queue
            queue.Enqueue("Indrani");
            queue.Enqueue("Deepthi");
            queue.Enqueue("Vyshnavi");
            queue.Enqueue("Keerthika");
            queue.Enqueue("Pavani");
            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }

            //Returns the first element in the queue
            string top=queue.Peek();
            Console.WriteLine("\nThe Peek element in the queue is : "+top+"\n");

            //Removes the first element in the queue
            queue.Dequeue();
            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
            
            //Count the number of elements in a queue
            int numOfElements=queue.Count();
            Console.WriteLine("\nThe number of elements in a queue is : " + numOfElements+"\n");
            if(queue.Contains("Vyshnavi"))
                Console.WriteLine("The element is found in the queue");
            else
                Console.WriteLine("The element is not found in the queue");
        }
    }
}
