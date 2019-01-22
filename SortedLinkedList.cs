using System;
using System.Collections.Generic;
namespace dev6a
{
    public class LNode<T> where T : IComparable 
    {
        
        internal T Value { get; set; }
        internal LNode<T> Next { get; set; }

       
    }

    public class LList<T> where T : IComparable
    {
        public LNode<T> Start { get; set; }



        public LNode<T> ListSearch<U>(U k) where U : T
        {
           var  p = Start;
            while (p != null && p.Value.CompareTo(k) != 0)
            {
                p = p.Next;
            }

            return p;
        }

        public  LNode<T> ListInsert<U>(U k) where U : T 
        {
            var p = Start;
            while (p.Next != null && p.Next.Value.CompareTo(k) <= 0)
            {
                p = p.Next;
            }

            p.Next = new LNode<T>()
            {
                Value = k,
                Next = Start
            };


            return p;
        }

        public LNode<T> ListDelete<U>(U k) where U : T 
        {
            LNode<T> p = Start;
            while (p.Next != null && p.Next.Value.CompareTo( k) <= 0)
            {
                if (p.Next.Value .CompareTo( k) == 0)
                {
                    p.Next = p.Next.Next;
                    
                }
            }

            p = new LNode<T>()
            {
                Value = k,
                Next = p.Next
            };


            return p;
        }
    }
}
    
   
