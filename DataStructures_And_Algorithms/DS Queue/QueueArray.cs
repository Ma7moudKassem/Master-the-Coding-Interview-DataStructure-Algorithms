using DataStructures_And_Algorithms.DS_LinkedList;

namespace DataStructures_And_Algorithms.DS_Queue
{
    class QueueNode
    {
        public int Value { get; set; }
        public QueueNode Next { get; set; }
        public QueueNode(int value)
        {
            this.Value = value;
            this.Next = null;
        }
    }
     public class QueueArray
     {
         QueueNode first;
         QueueNode last;
        public int length;
        public QueueArray()
        {
            this.first = null;   
            this.last = null;   
            this.length = 0;   
        }
        public int peek()
        {
            if (this.length > 0)
                return this.first.Value;
            return -1;
        }
        public void enqueue(int value)
        { 
            QueueNode queueNode = new QueueNode(value);
            if (this.length == 0)
            {
                this.first = queueNode;
                this.last = queueNode;

            }
            else 
            {
                this.last = queueNode;
                this.last.Next = queueNode;
            }
            length++;
        }
        public int dequeue()
        {
            if (this.first == null)
            { return -1; };
            if (this.length == 0)
            { this.last = null};
            QueueNode holdingPointer = this.first;
            this.first = this.first.Next;
            this.length--;
            return holdingPointer.Value;
        }
        
    }
    
}
