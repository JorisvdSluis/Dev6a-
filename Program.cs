using System;
using System.Linq;
using System.Collections.Generic;
using static Search.Search;
using static Sort.Sort;
using static dev6a.LList<int>;
namespace dev6a
{
    class Program
    {
        int[] array = new[] {6, 5, 2, 9, 4};
         string[] stringArray = new[] {"hoi", "doei", "hello", "bye"};
        static LNode<int> node3 = new LNode<int>(){Value = 4, Next = null};
        static LNode<int> node2 = new LNode<int>() {Value = 3, Next = node3};

      
        static LNode<int> node = new LNode<int>() {Value = 2, Next = node2};
        static LList<int> list = new LList<int>(){Start = node};
        static Stack<int> stack= new Stack<int>();
        static HashTable<int, string> hash = new HashTable<int, string>(10);
         static void Main()
        {
            //Generic Linear Search
        //    int search = LinearSearch(array, 2);
        //     Console.WriteLine(search);
            
        //     int searchString = LinearSearch(stringArray, "doei");
        //     Console.WriteLine(searchString);

        // Generic binary search
//        int search = BinarySearch(array, 1, Comparer<int>.Default);
//        Console.WriteLine(search);

//            int[] sort = InsertionSort(array, Comparer<int>.Default);
//            int[] sort = MergeSort(array, Comparer<int>.Default);
//            foreach (var VARIABLE in sort)
//            {
//                Console.WriteLine(VARIABLE);
//            }
            
            // search linked list

//            LNode<int> search = list.ListSearch(4);
//            
//            Console.WriteLine(search.Value);
            // insert linked list

//            LNode<int> insert = list.ListInsert(5);
//            Console.WriteLine(list.Start.Next.Next.Next.Value);

            //stack
//             stack.push(3);
//            stack.push(5);
//            stack.push(1);
//            stack.pop();
//            stack.pop();
//            stack.push(8);
//            stack.pop();
//            stack.pop();
//            stack.push(2);
//            stack.push(4);
//            stack.pop();
//            stack.push(7);
//            
//            Console.WriteLine(stack._list[1]+","+stack._list[0]);
            
            //hashtable
           hash.Put(2,"hoi6");
            hash.Put(3,"hoi6");
            hash.Put(4,"hoi5");
            hash.Put(5,"hoi4");
            hash.Put(6,"hoi3");
            hash.Put(7,"hoi2");
            int code = (7.GetHashCode() % hash.Size);
            string cod = hash.Slots[code].Value;
            Console.WriteLine(cod);
        }
    }
}


