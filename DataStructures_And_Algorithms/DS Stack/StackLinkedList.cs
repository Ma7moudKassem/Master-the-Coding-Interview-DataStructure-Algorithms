namespace DataStructures_And_Algorithms.DS_Stack
{
    //(10-->20-->null)
    public class StackNode
    {
        public int Value { get; set; }
        public StackNode Next { get; set; }
        public StackNode(int value)
        {
            this.Value = value;
            this.Next = null;
        }
    }
    public class StackLinkedList
    {
        public int length;
        public StackNode top;
        public StackNode bottom;
        public StackLinkedList()
        {
            this.top = null;
            this.bottom = null;
            this.length = 0;
        }

        public StackNode peek() 
        {
            Console.WriteLine(this.top);
            return this.top;
        } 
        public void push(int value)
        {
            StackNode newNode = new StackNode(value);
            if (length == 0)
            {
                this.top = newNode;
                this.bottom = newNode;
            }
            else 
            {
                StackNode holdingPointer = this.top;
                this.top = newNode;
                this.top.Next = holdingPointer;
            }
            this.length++;

        }
        public int pop() 
        {
            if (this.top == null)
            { return 0; }
            else 
            {
                StackNode holdingPointer = this.top;
                this.top = this.top.Next;
                this.length--;
                return holdingPointer.Value;
            }
        }
        public void printStack()
        {
            if (top == null)
            {
                return;
            }
            StackNode currentNode = top;
            Console.Write(currentNode.Value);
            currentNode = currentNode.Next;
            while (currentNode != null)
            {
                Console.Write("-->" + currentNode.Value);
                currentNode = currentNode.Next;
            }
            Console.WriteLine();
        }
    }
}
