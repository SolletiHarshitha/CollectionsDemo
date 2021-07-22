using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class List
    {
        public static void ListDemo()
        {
            List<string> list = new List<string>();
            //Adding the elements into the list
            list.Add("Ajay");
            list.Add("Varma");
            list.Add("Saranya");
            list.Add("Kasturi");
            foreach(var element in list)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            //Inserting the elements at specified position
            list.Insert(2, "Ashok");
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
            
            //Count the number of elements in a list
            int numOfElements=list.Count();
            Console.WriteLine("\nThe number of elements in list are : "+numOfElements+"\n");

            //Sort the elements
            list.Sort();
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }

            //Checking if the element is present in the list
            if (list.Contains("Ajay"))
                Console.WriteLine("The element is found in the list\n");
            else
                Console.WriteLine("The element is not found in the list\n");
            Console.WriteLine();
            
            //Removes the specific element
            list.Remove("Ashok");
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            //Removes the element at given index
            list.RemoveAt(3);
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }

            //Return the index of an element
            int index=list.IndexOf("Saranya");
            Console.WriteLine("\nThe index of the element is : "+index);
            Console.WriteLine();

            //Check if the element exists in the list 
            if(list.Exists(x=>x.Contains("Varma")))
               Console.WriteLine("The element exist in the list");
            else
                Console.WriteLine("The element does not exist in the list");

        }
    }
}
