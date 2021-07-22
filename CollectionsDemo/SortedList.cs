using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class SortedList
    {
        public static void SortedListDemo()
        {
            SortedList<int, string> sortedList = new SortedList<int, string>();
            //Add elements into list
            sortedList.Add(1, "Apple");
            sortedList.Add(2, "Mango");
            sortedList.Add(3, "Banana");
            sortedList.Add(4, "Orange");
            sortedList.Add(5, "Grapes");
            foreach(var element in sortedList)
            {
                Console.WriteLine(element);
            }

            //Count the number of elements in list
            int numOfElements=sortedList.Count();
            Console.WriteLine("\nThe number of elements in the list is : "+numOfElements+"\n");

            //Removes the element of given key
            sortedList.Remove(4);
            foreach (var element in sortedList)
            {
                Console.WriteLine(element);
            }

            //Return the index of the key
            int key=sortedList.IndexOfKey(5);
            Console.WriteLine("\nThe index of the key is : "+key+"\n");

            //Return the index of the value
            int value = sortedList.IndexOfValue("Mango");
            Console.WriteLine("The index of the value is : "+value+"\n");

            //Removes the element at given index
            sortedList.RemoveAt(2);
            foreach (var element in sortedList)
            {
                Console.WriteLine(element);
            }

            //Checks if the key is present
            if(sortedList.ContainsKey(1))
                Console.WriteLine("\nThe key is present in the list");
            else
                Console.WriteLine("\nThe key is not present in the list");

            //Checks if the value is present
            if(sortedList.ContainsValue("Apple"))
                Console.WriteLine("\nThe value is present in the list");
            else
                Console.WriteLine("\nThe value is not present in the list");
        }
    }
}
