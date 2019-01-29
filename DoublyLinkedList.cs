using System;


namespace dev6a
{
    public class DoublyLinkedNode<T> where T : IComparable
    {

        internal T Value { get; set; }
        internal DoublyLinkedNode<T> Next { get; set; }
        internal DoublyLinkedNode<T> Prev { get; set; }


    }

    public class DoublyLinkedList<T> where T : IComparable
        {
            public DoublyLinkedNode<T> Start { get; set; }
            public DoublyLinkedNode<T> End { get; set; }



            public DoublyLinkedNode<T> DListSearch<U>(U k) where U : T
            {
                var p = Start;
                while (p != null && p.Value.CompareTo(k) != 0)
                {
                    p = p.Next;
                }

                if (p != null)
                {
                    
                    Console.WriteLine(p.Value);
                }
                else{Console.WriteLine("not found");}
                return p;
            }

            public void DoublyInsertStart<U>(U k) where U : T
            {
                if (Start == null)
                {
                    Start = new DoublyLinkedNode<T>(){Value = k, Next = null, Prev = null};
                }
                else
                {
                    var temp = Start;
                    Start = new DoublyLinkedNode<T>(){Value = k, Next = temp, Prev = null};
                }
            }
            public DoublyLinkedNode<T> ListInsertAfter<U>(U k, T l) where U : T
            {

                var n = DListSearch(l);
                DoublyLinkedNode<T> tempNext = n.Next;
                n.Next = new DoublyLinkedNode<T>()
                             {
                                 Value = k,
                                 Next = tempNext,
                                 Prev = n,
                             };
             
             
                             return n.Next;
                         }
            public DoublyLinkedNode<T> ListInsertBefore<U>(U k, DoublyLinkedNode<T> n) where U : T
            {

                var tempPrev = n.Prev;
                n.Prev = new DoublyLinkedNode<T>()
                {
                    Value = k,
                    Prev = tempPrev,
                    Next = n,
                };


                return n.Prev;
            }

            public DoublyLinkedNode<T> ListDelete<U>(U k) where U : T
            {
                DoublyLinkedNode<T> p = Start;
                while (p.Next != null && p.Next.Value.CompareTo(k) <= 0)
                {
                    if (p.Next.Value.CompareTo(k) == 0)
                    {
                        p.Next = p.Next.Next;

                    }
                }

                p = new DoublyLinkedNode<T>()
                {
                    Value = k,
                    Next = p.Next
                };


                return p;
            }
        }
    }





