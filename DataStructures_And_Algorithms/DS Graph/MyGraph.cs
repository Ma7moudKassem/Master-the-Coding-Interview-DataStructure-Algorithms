namespace DataStructures_And_Algorithms.DS_Graph
{
    public class MyGraph
    {
        private Dictionary<int, List<int>> adjacentList;
        private int numberOfNodes;
        public MyGraph()
        {
            adjacentList = new Dictionary<int, List<int>>();
            numberOfNodes = 0;
        }
        public void addVertix(int node)
        {
          adjacentList.Add(node, new List<int>());
          numberOfNodes++;
        }
        public void addEdge(int node1 , int node2)
        {
            adjacentList[node1].Add(node2);
            adjacentList[node2].Add(node1);
        }
        public void showConnections()
        {
            foreach (var item in adjacentList)
            {
                List<int> nodeConnections = adjacentList[item.Key];
                StringBuilder connections = new StringBuilder();
                foreach (int edge in nodeConnections)
                {
                    connections.Append(edge).Append(" ");   
                }
                Console.WriteLine(item.Key + "-->" + connections);
            }
        }
    }
}
