using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class Stack
    {
        public static void StackDemo()
        {
            Stack<string> stack = new Stack<string>();
            //Pushing the elements into stack
            stack.Push("Karan");
            stack.Push("Sridhar");
            stack.Push("Harish");
            stack.Push("Mahendra");
            foreach(var element in stack)
            {
                Console.WriteLine(element);
            }

            //Return the peek element in the list
            string top=stack.Peek();
            Console.WriteLine("\nThe Peek element in the list is : "+top+"\n");

            //Pop the peek element
            stack.Pop();
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            
            //Count the number of elements in the stack
            int numOfElements=stack.Count();
            Console.WriteLine("\nThe number of elements in the stack is : "+numOfElements+"\n");

            //Checks if the element is peresent
            bool result=stack.Contains("Sridhar");
            if(result)
                Console.WriteLine("The element is found in the stack");
            else
                Console.WriteLine("The element is not found in the stack");
        }
    }
}
