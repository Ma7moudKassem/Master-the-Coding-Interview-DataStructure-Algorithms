namespace DataStructures_And_Algorithms
{
    public class MyArray
    {
        
        public int length;
        private object[] data;
        public MyArray()
        {
            length = 0;
            data = new object[1];
        }
        public object get(int index) => data[index];
        public object[] push(object item)
        {
            if (data.Length == length)
            {
                object[] temp = new object[length]; // creates a temp array 
                Array.Copy(data, temp, length); //copies all data to temp array     
                data = new object[length + 1]; //increases size of temp array
                Array.Copy(temp, data, length);
            }
            data[length] = item;
            length++;
            return data;
        }
        public object pop()
        {
            object lastItem = data[length - 1];
            data[length - 1] = null;
            length--;
            return lastItem;
        }
        public object delete(int index)
        {
            object itemToDelete = data[index]; // 3==>e
            shiftItems(index);
            return itemToDelete;

        }
        private void shiftItems(int index)
        {
            for (int i = index; i < length - 1; i++)
            {
                data[i] = data[i + 1];
            }
            data[length - 1] = null;
            length--;
        }
    }
}
