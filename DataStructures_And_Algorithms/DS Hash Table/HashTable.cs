namespace DataStructures_And_Algorithms.DS_Hash_Table
{
    //Hash Table ==> Map ==> ["key"=>string : value=>integer]
    public class MyNode
    {
        public string Key { get; set; }
        public int Value { get; set; }
        public MyNode(string key , int value)
        {
            this.Key = key;
            this.Value = value;
        }
    }
    public class HashTable
    {
        private class MyNodes : List<MyNode> { };
        private int length;
        private MyNodes[] data;
        public HashTable(int size)
        {
            this.length = size;
            this.data = new MyNodes[size];
        }
        // "Kassem"
        private int hash(string key)//"Kassem"==> Length = 6
        {
            int hash = 0;
            for (int i = 0; i < key.Length; i++)
            {
                hash = (hash + (int)key[i] * i) % this.length;
            }
            return hash;
        }

        public void set(string key, int value) //["Key" : value]=> ["Kassem : 01224176036"]
        {
            int index = hash(key);
            if (this.data[index]==null)
            {
                this.data[index] = new MyNodes();
            }
            this.data[index].Add(new MyNode(key, value));
        }
        //get
        public int get(string key) 
        {
            int index = hash(key);
            if (this.data[index] == null)
                return 0;
            foreach (var node in this.data[index])
            {
                if (node.Key.Equals(key))
                    return node.Value;
            }
            return 0;
        }

        //Keys ==>get all Keys in Hash Table

        public List<string> keys()
        {
            List<string> result = new List<string>();
            for (int i = 0; i < this.data.Length; i++)
            {
                if (this.data[i] != null)
                {
                    for (int j = 0; j < length; j++)
                    {
                        result.Add(this.data[i][j].Key);
                    }
                }
            }
            return result;
        }
    }
}
