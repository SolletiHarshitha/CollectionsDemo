using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class Dictionary
    {
        public static void DictionaryDemo()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            //Adding elements into Dictionary
            dictionary.Add(1, "Apple");
            dictionary.Add(2, "Mango");
            dictionary.Add(3, "Orange");
            dictionary.Add(4, "Grapes");
            dictionary.Add(5,"Banana");
            foreach (var element in dictionary)
            {
                Console.WriteLine(element);
            }

            //Count of elements in dictionary
            int numOfElements = dictionary.Count();
            Console.WriteLine("\nThe number of elements in dictionary is : "+numOfElements+"\n");

            //Removes element 
            dictionary.Remove(3);
            foreach (var element in dictionary)
            {
                Console.WriteLine(element);
            }

            //Checks if the key is present
            bool key = dictionary.ContainsKey(2);
            if(key)
                Console.WriteLine("\nThe key is present in the dictionary");
            else
                Console.WriteLine("\nThe key is not present in the dictionary");

            //Checks if the value is present
            bool value = dictionary.ContainsValue("Grapes");
            if (value)
                Console.WriteLine("\nThe value is present in the dictionary");
            else
                Console.WriteLine("\nThe value is not present in the dictionary");
        }
    }
}
