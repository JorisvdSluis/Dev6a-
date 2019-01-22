using System;
using System.Collections.Generic;
using System.Linq;

namespace dev6a
{
    public class Stack<T>
    {
        public List<T> _list;

        public int _top;

        public Stack()
        {
            _list = new List<T>();
                _top = 0;
        }

        public void push<U>(U k) where U : T
        {
            _list.Add(k);
            _top += 1;
        }

        public  void pop()
        {
            if (_top != 0)
            {
                _list.RemoveAt(_top -1);
                _top -=1;
            }

            else{throw new Exception("bottom");}
        }
        
       public T peek()
        {
            return _list.ElementAt(_top - 1);
        }
        
    }
}