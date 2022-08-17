namespace DataStructures_And_Algorithms.DS_LinkedList
{
    public class Node1
    {
        public int value { get; set; }
        public Node1 next { get; set; }
        public Node1 previous { get; set; }

        public Node1(int value)
        {
            this.value = value;
            this.next = null;
            this.previous = null;
        }
    }

    public class MyDoublyLinkedList
    {
        private Node1 head;
        private Node1 tail;
        private int length;

        public MyDoublyLinkedList(int value)
        {
            this.head = new Node1(value);
            this.tail = this.head;
            this.length = 1;
        }

        public void append(int value)
        {
            Node1 newNode = new Node1(value);
            newNode.previous = this.tail;
            this.tail.next = newNode;
            this.tail = newNode;
            this.length++;
        }

        public void prepend(int value)
        {
            Node1 newNode = new Node1(value);
            newNode.next = this.head;
            this.head.previous = newNode;
            this.head = newNode;
            this.length++;
        }

        public void insert(int index, int value)
        {
            index = wrapIndex(index);
            if (index == 0)
            {
                prepend(value);
                return;
            }

            if (index == length - 1)
            {
                append(value);
                return;
            }

            Node1 newNode = new Node1(value);

            Node1 leader = traverseToIndex(index - 1);
            Node1 follower = leader.next;

            leader.next = newNode;
            newNode.previous = leader;
            newNode.next = follower;
            follower.previous = newNode;

            this.length++;

        }

        public void remove(int index)
        {
            index = wrapIndex(index);
            if (index == 0)
            {
                head = head.next;
                return;
            }

            Node1 leader = traverseToIndex(index - 1);
            Node1 nodeToRemove = leader.next;
            leader.next = nodeToRemove.next;
            nodeToRemove.next.previous = leader;
            this.length--;
        }

        public void printList()
        {
            if (this.head == null)
            {
                return;
            }
            Node1 current = this.head;
            while (current != null)
            {
                Console.Write("-->" + current.value);
                current = current.next;
            }
            Console.WriteLine();
        }

        public int getLength()
        {
            return this.length;
        }

        public Node1 getHead()
        {
            return this.head;
        }

        public Node1 getTail()
        {
            return this.tail;
        }

        private int wrapIndex(int index)
        {
            return Math.Max(Math.Min(index, this.length - 1), 0);
        }

        private Node1 traverseToIndex(int index)
        {
            int counter = 0;
            index = wrapIndex(index);
            Node1 currentNode = head;
            while (counter != index)
            {
                currentNode = currentNode.next;
                counter++;
            }
            return currentNode;
        }
    }
}
