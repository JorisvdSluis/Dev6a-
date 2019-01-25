using System;

namespace dev6a
{
    public class BinaryTree<T> where T: IComparable
    {
       public BNode<T> Root {get; set;}
       public BinaryTree(){
           Root = null;
       }

       public void Insert<V>(V value) where V : T{

           if(Root == null){
               Root = new BNode<T>(value, null, null, null);
               return;
           }
           insertRecursive(Root, new BNode<T>(value, null, null, null) );
       }


       public void insertRecursive(BNode<T> Root, BNode<T> newNode){
           if(Root == null){
               Root = newNode;
           }
           if(newNode.Value.CompareTo(Root.Value) < 0){
               if(Root.Left == null){
                   Root.Left = newNode;
               }
               else{insertRecursive(Root.Left, newNode);}
           }
           else { 
               if(Root.Right == null){
                   Root.Right = newNode;
               }
               else{insertRecursive(Root.Right,newNode);}
           }
       }

        public void Delete<V>(V value) where V: T{
           if (Root == null){
               throw new Exception("can't delete empty binarytree");
              
           }
           if(Root.Value.Equals(value)){
               if(Root.Left != null){
               Root = Root.Left;
               Console.WriteLine("Deleted Root to left");}

               if(Root.Right != null){
               Root = Root.Right;}

               else{ Root = null;}
               Console.WriteLine("Deleted Root");
           }
           deleteRecursive(Root, value);
       }

       public void deleteRecursive<V>(BNode<T> Root, V value)where V : T{
            if(Root == null){throw new Exception("can't delete empty binarytree");}
            
            if(value.CompareTo(Root.Value) < 0){
                if(Root.Left.Value.Equals(value)){
                    if(Root.Left.Left != null){
                        Root.Left = Root.Left.Left;
                        Console.WriteLine("Deleted left.left");
                        
                    }
                     if(Root.Left.Right != null){
                        Root.Left = Root.Left.Right;
                        Console.WriteLine("Deleted left.right");
                    }
                    else Root.Left = null;
                    Console.WriteLine("Deleted left");
                    }
                else{deleteRecursive(Root.Left, value);}
                
            }
            else{
                 if(Root.Right.Value.Equals(value)){
                    if(Root.Right.Left == null){
                        Root.Right = Root.Right.Left;
                        Console.WriteLine("Deleted right.left");
                    }
                    if(Root.Right.Right != null){
                        Root.Right = Root.Right.Right;
                        Root.Right.Right = null;
                        Console.WriteLine("Deleted right.right");
                    }
                    else{ Root.Right = null;
                    Console.WriteLine("Deleted right");}
                    }
                else{deleteRecursive(Root.Right, value);}
            }
          
       }
        private void DisplayTree(BNode<T> Root)
        {
            if (Root == null) return;

            DisplayTree(Root.Left);
            System.Console.Write(Root.Value + " ");
            DisplayTree(Root.Right);
        }
        public void DisplayTree()
        {
            DisplayTree(Root);
        }


    }

    public class BNode<T> where T: IComparable{
    
    public BNode(T value, BNode<T> parent , BNode<T> right, BNode<T> left){
        Parent =parent;
        Right = right;
        Left = left;
        Value = value;
    }
     public BNode<T> Parent{get; set;}
     public BNode<T> Right { get; set; }
     public BNode<T> Left{get; set;}

    public T Value {get; set;}

    }
}
