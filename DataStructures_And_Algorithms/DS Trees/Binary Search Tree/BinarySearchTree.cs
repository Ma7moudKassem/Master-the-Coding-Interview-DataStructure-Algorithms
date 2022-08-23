namespace DataStructures_And_Algorithms.DS_Trees.Binary_Search_Tree
{
    public class BSTNode
    {
        public int Value { get; set; }
        public BSTNode Rigth { get; set; }
        public BSTNode Lift { get; set; }
        public BSTNode(int value)
        {
            this.Value = value;
            this.Rigth = null;
            this.Rigth = null;
        }
    }
    public class BinarySearchTree
    {
        private BSTNode Root { get; set; }
        public BinarySearchTree()
        {
            this.Root = null;
        }
        public void insert(int value)
        {
            BSTNode newNode = new BSTNode(value);
            if (this.Root == null)
            {
                Root = newNode;
                return;
            }
            BSTNode currentNode = this.Root;
            while (true)
            {
                if (value < currentNode.Value)
                {
                    if (currentNode.Lift == null)
                    {
                        currentNode.Lift = new BSTNode(value);
                        return;
                    }
                    currentNode = currentNode.Lift;
                }
                else 
                {
                    if (currentNode.Rigth == null)
                    {
                        currentNode.Rigth = new BSTNode(value);
                        return;
                    }
                    currentNode = currentNode.Rigth;    
                }
            }
        }
        public BSTNode lookup(int value)
        {
            if (Root == null)
                return null;
            BSTNode currentNode = this.Root;
            while (currentNode != null)
            {
                if (value < currentNode.Value)
                {
                    currentNode = currentNode.Lift;
                }
                else if (value > currentNode.Value)
                {
                    currentNode = currentNode.Rigth;
                }
                else
                {
                    return currentNode;
                }
            }
            return null;
        }
        public void remove(int value)
        {
            
        }
    }
}
