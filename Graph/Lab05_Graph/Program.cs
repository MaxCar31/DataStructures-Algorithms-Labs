namespace Lab05_Graph;

class Program
{

    //CARRION MAX 
    static void Main(string[] args)


            
    {

/*
        //PARTE II
            // Imprime un mensaje en la consola
            Console.Write("Undirected and Unweighted edges \n");

            // Crea una instancia de un grafo no dirigido y no ponderado
            Graph<int> graph = new Graph<int>(false, false);

            // Agrega nodos al grafo
            Node<int> n1 = graph.AddNode(1);
            Node<int> n2 = graph.AddNode(2);
            Node<int> n3 = graph.AddNode(3);
            Node<int> n4 = graph.AddNode(4);
            Node<int> n5 = graph.AddNode(5);
            Node<int> n6 = graph.AddNode(6);
            Node<int> n7 = graph.AddNode(7);
            Node<int> n8 = graph.AddNode(8);

            // Agrega aristas al grafo
            graph.AddEdge(n1, n2);
            graph.AddEdge(n1, n3);
            graph.AddEdge(n2, n4);
            graph.AddEdge(n3, n4);
            graph.AddEdge(n4, n5);
            graph.AddEdge(n5, n6);
            graph.AddEdge(n5, n7);
            graph.AddEdge(n5, n8);
            graph.AddEdge(n6, n7);
            graph.AddEdge(n7, n8);


            //PARTE 3

            // Imprime un mensaje en la consola
            Console.Write("Directed and Weighted Edges \n");

            // Crea una instancia de un grafo dirigido y ponderado
            Graph<int> graph = new Graph<int>(true, true);

            // Agrega nodos al grafo
            Node<int> n1 = graph.AddNode(1);
            Node<int> n2 = graph.AddNode(2);
            Node<int> n3 = graph.AddNode(3);
            Node<int> n4 = graph.AddNode(4);
            Node<int> n5 = graph.AddNode(5);
            Node<int> n6 = graph.AddNode(6);
            Node<int> n7 = graph.AddNode(7);
            Node<int> n8 = graph.AddNode(8);

            // Agrega aristas al grafo con pesos
            graph.AddEdge(n1, n2, 9);
            graph.AddEdge(n1, n3, 5);
            graph.AddEdge(n2, n1, 3);
            graph.AddEdge(n2, n4, 18);
            graph.AddEdge(n3, n4, 12);
            graph.AddEdge(n4, n2, 2);
            graph.AddEdge(n4, n8, 8);
            graph.AddEdge(n5, n4, 9);
            graph.AddEdge(n5, n6, 2);
            graph.AddEdge(n5, n7, 5);
            graph.AddEdge(n5, n8, 3);
            graph.AddEdge(n6, n7, 1);
            graph.AddEdge(n7, n5, 4);
            graph.AddEdge(n7, n8, 6);
            graph.AddEdge(n8, n5, 3);

            //PARTE 4

            // Imprime un mensaje en la consola
            Console.Write("Breadth-First Search\n");

            // Crea una instancia de un grafo dirigido y ponderado
            Graph<int> graph = new Graph<int>(true, true);

            // Agrega nodos al grafo
            Node<int> n1 = graph.AddNode(1);
            Node<int> n2 = graph.AddNode(2);
            Node<int> n3 = graph.AddNode(3);
            Node<int> n4 = graph.AddNode(4);
            Node<int> n5 = graph.AddNode(5);
            Node<int> n6 = graph.AddNode(6);
            Node<int> n7 = graph.AddNode(7);
            Node<int> n8 = graph.AddNode(8);

            // Agrega aristas al grafo con pesos
            graph.AddEdge(n1, n2, 9);
            graph.AddEdge(n1, n3, 5);
            graph.AddEdge(n2, n1, 3);
            graph.AddEdge(n2, n4, 18);
            graph.AddEdge(n3, n4, 12);
            graph.AddEdge(n4, n2, 2);
            graph.AddEdge(n4, n8, 8);
            graph.AddEdge(n5, n4, 9);
            graph.AddEdge(n5, n6, 2);
            graph.AddEdge(n5, n7, 5);
            graph.AddEdge(n5, n8, 3);
            graph.AddEdge(n6, n7, 1);
            graph.AddEdge(n7, n5, 4);
            graph.AddEdge(n7, n8, 6);
            graph.AddEdge(n8, n5, 3);
            graph.AddEdge(n8, n5, 3);

            // Realiza una búsqueda en anchura (BFS) en el grafo y almacena los nodos visitados en una lista
            List<Node<int>> bfsNodes = graph.BFS();

            // Imprime cada nodo visitado en la consola
            bfsNodes.ForEach(n => Console.WriteLine(n));

    */


            //PARTE 5

            Console.Write("Breadth-First Search\n");


            // Crea una instancia de la clase Graph con aristas dirigidas y ponderadas
            Graph<int> graph = new Graph<int>(true, true);

            // Agrega los nodos al grafo
            Node<int> n1 = graph.AddNode(1);
            Node<int> n2 = graph.AddNode(2);
            Node<int> n3 = graph.AddNode(3);
            Node<int> n4 = graph.AddNode(4);
            Node<int> n5 = graph.AddNode(5);
            Node<int> n6 = graph.AddNode(6);
            Node<int> n7 = graph.AddNode(7);
            Node<int> n8 = graph.AddNode(8);

            // Agrega las aristas al grafo con sus respectivos pesos
            graph.AddEdge(n1, n2, 9);
            graph.AddEdge(n1, n3, 5);
            graph.AddEdge(n2, n1, 3);
            graph.AddEdge(n2, n4, 18);
            graph.AddEdge(n3, n4, 12);
            graph.AddEdge(n4, n2, 2);
            graph.AddEdge(n4, n8, 8);
            graph.AddEdge(n5, n4, 9);
            graph.AddEdge(n5, n6, 2);
            graph.AddEdge(n5, n7, 5);
            graph.AddEdge(n5, n8, 3);
            graph.AddEdge(n6, n7, 1);
            graph.AddEdge(n7, n5, 4);
            graph.AddEdge(n7, n8, 6);
            graph.AddEdge(n8, n5, 3);
            graph.AddEdge(n8, n5, 3);

            // Realiza un recorrido BFS en el grafo
            List<Node<int>> bfsNodes = graph.BFS();

            // Imprime los nodos visitados en el recorrido BFS
            bfsNodes.ForEach(n => Console.WriteLine(n));

    
    
    }
}
