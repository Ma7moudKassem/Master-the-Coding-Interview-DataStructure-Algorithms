namespace DataStructures_And_Algorithms.Sorting;
public class InsertionSort
{   //[0,1,2,3,4]
    //[3,4,2,4,5]
    public int[] Sort(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int length = arr.Length;
            int key = arr[i]; //2
            int j = i - 1;//1
                                //4 > 2
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
        return arr;
    }
}
