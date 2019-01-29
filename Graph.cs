using System;
using System.Collections.Generic;
namespace dev6a
{
    public class Graph<T> where T : IComparable
    {
        public Vertice<T> Root { get; set; }
        public List<Vertice<T>> Nodes { get; set; }

        public Graph()
        {
            Root = null;
            Nodes = null;
        }
        public void Insert<V>(V value, List<T> vertices) where V : T
        {
            if (Root == null)
            {
                Root = new Vertice<T>(value, null);
                Nodes = new List<Vertice<T>> { Root };
                Console.WriteLine("Added Root");
            }
            else
            {
                var verti = new List<Vertice<T>> { };
                foreach (T n in vertices)
                {
                    for (int i = 0; i < Nodes.Count; i++)
                    {
                        if (Nodes[i].Value.Equals(n))
                        {
                            Vertice<T> SearchedNode = Nodes[i];
                            verti.Add(SearchedNode);
                        }
                    }

                }
                var newVertice = new Vertice<T>(value, verti);
                // for (int i = 0; i < verti.Count; i++)
                // {
                if (Nodes[0].Value != null)
                {
                    if (Nodes[0].Vertices == null)
                    {
                        Nodes[0].Vertices = new List<Vertice<T>> { newVertice };
                        Nodes.Add(newVertice);

                        Console.WriteLine("Added first vertice" + newVertice.Value);
                    }
                    else
                    {
                        for (int i = 0; i < Nodes.Count ; i++)
                        {
                            foreach (var m in verti)

                                if (Nodes[i].Value.Equals(m.Value))
                                {
                                    Nodes[i].Vertices.Add(newVertice);
                                    Nodes.Add(newVertice);

                                    Console.WriteLine("Added arc" + newVertice.Value);
                                }

                                else
                                {
                                    Console.WriteLine("searching...");
                                }
                        }
                    }
                }
            }

        }

        public void BFS()
        {
            var que = new Queue<Vertice<T>>();
            que.enqueue(Root);
            var set = new List<Vertice<T>>();

            while (que._list.Count != 0)
            {
                var current = que._list[0];
                que.dequeue();

                set.Add(current);
                Console.WriteLine(current.Value);

                foreach (Vertice<T> n in current.Vertices) if (!set.Contains(n))
                    {
                        que.enqueue(n);
                    }
            }
        }

        public void DFS()
        {
            var stak = new Stack<Vertice<T>>();
            stak.push(Root);
            var labeled = new List<Vertice<T>>();

            while (stak._list.Count != 0)
            {
                var v = stak.peek();
                labeled.Add(v);
                Console.WriteLine(v.Value);
                stak.pop();
                foreach (Vertice<T> w in v.Vertices) if (!labeled.Contains(w))
                    {
                        stak.push(w);
                    }
            }
        }

        /*public void Dijkstra()
        {
            List<Vertice<T>> q = new List<Vertice<T>>();
            int count;
            int[] distance =new int[ count];
            foreach (Vertice<T> v in Nodes)
            {
              distance[v.Value] = int.IsNegativeInfinity;
                int[] previous;
            }
        }*/

  
    }
    public class Vertice<T> where T : IComparable
    {
        public Vertice(T value, List<Vertice<T>> vertices)
        {
            Value = value;
            Vertices = vertices;
        }
        public T Value { get; set; }
        public List<Vertice<T>> Vertices { get; set; }
    }
}