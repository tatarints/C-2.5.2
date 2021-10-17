class Graph
{
        private int Vertices;
        private List<Int32>[] adj;
        public Graph(int v)
        {
            Vertices = v;
            adj = new List<Int32>[v];
            
            for (int i = 0; i < v; i++)
            {
                adj[i] = new List<Int32>();
            }

        }

        public void Add(int v, int w)
        {
            adj[v].Add(w);
        }
       
        public void DFS(int s)
        {
            bool[] visited = new bool[Vertices];

            
            Stack<int> stack = new Stack<int>();
            visited[s] = true;
            stack.Push(s);

            while (stack.Count != 0)
            {
                s = stack.Pop();
                Console.WriteLine("Следующий: " + s);
                foreach (int i in adj[s])
                {
                    if (!visited[i])
                    {
                        visited[i] = true;
                        stack.Push(i);
                    }
                }
            }
        }
           
        public static void Main()
        {
            Graph graph = new Graph(4);
            graph.Add(0, 1);
            graph.Add(0, 2);
            graph.Add(1, 2);
            graph.Add(2, 0);
            graph.Add(2, 3);
            graph.Add(3, 3);

           Console.WriteLine("Введите с какой вершины начнём от 0 до 3:");
           int u = Convert.ToInt32(Console.ReadLine());
           graph.DFS(u);
        }
}
