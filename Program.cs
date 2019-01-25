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

        static BinaryTree<int> bst = new BinaryTree<int>();
       
        static Graph<int> graph = new Graph<int>();
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
         //  hash.Put(2,"hoi6");
          //  hash.Put(3,"hoi6");
           // hash.Put(4,"hoi5");
        //     hash.Put(5,"hoi4");
        //     hash.Put(15,"hoi3");
        //   //  hash.Put(25,"hoi2");
        //     int key = (15);
        //    // int codekey = key.GetHashCode();
        //     // int code = (7.GetHashCode() % hash.Size);
        //     // string cod = hash.Slots[code].Value;
        //     // //  Console.WriteLine(cod);
        //    var getValue = hash.Get(key);
        //    //Console.WriteLine(codekey);
           
        //  Console.WriteLine(getValue);

        //BST

    //     bst.Insert(5);
    //      bst.Insert(4);
    //       bst.Insert(6);
    //        bst.Insert(3);
    //         bst.Insert(7);
    //     //    bst.Insert(2);
    //     //    bst.Insert(8);

    //       //bst.Delete(3);
    //  bst.Delete(7);

    //     bst.DisplayTree();

    //graph
    graph.Insert(1, null);
    graph.Insert(2, new List<int>{1});
  graph.Insert(3, new List<int>{2});
graph.Insert(4, new List<int>{3});
       graph.Insert(5,new List<int>{3} );
        graph.Insert(6, new List<int>{2});
     graph.Insert(7, new List<int>{1});
   graph.Insert(8, new List<int>{1});
   graph.Insert(9, new List<int>{8});
   graph.Insert(10, new List<int>{9});
   graph.Insert(11, new List<int>{9});
   graph.Insert(12, new List<int>{8});

           graph.BFS();
           Console.WriteLine("next dfs");
           graph.DFS();
           Console.WriteLine("next dijkstra");
           //graph.Dijkstra();
           Console.WriteLine("Succesfull");
        //  Console.WriteLine(graph.Nodes[3].Value.ToString() + graph.Nodes[3].Vertices[4].ToString());
        }
    }
}


