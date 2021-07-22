using System;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------Collections-----------------");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.List\n2.Stack\n3.Queue\n4.SortedList\n5.Dictionary");
                Console.WriteLine("Choose an option :");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        List.ListDemo();
                        break;
                    case 2:
                        Stack.StackDemo();
                        break;
                    case 3:
                        Queue.QueueDemo();
                        break;
                    case 4:
                        SortedList.SortedListDemo();
                        break;
                    case 5:
                        Dictionary.DictionaryDemo();
                        break;
                    default:
                        Console.WriteLine("Invalid .... Choose an Valid option");
                        break;
                }
            }
        }
    }
}
