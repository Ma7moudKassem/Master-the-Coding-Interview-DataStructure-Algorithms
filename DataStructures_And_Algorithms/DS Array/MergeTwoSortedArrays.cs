namespace DataStructures_And_Algorithms
{
    public class MergeTwoSortedArrays
    {
        public static void mergingTwoSortedArray(int[] arr1, int[] arr2, int[] mergedArray, int n1, int n2) //5 
        {
            int i = 0, j = 0, k = 0;
            while (i < n1 && j < n2)
            {
                if (arr1[i] > arr2[j])
                    mergedArray[k++] = arr1[i++];
                else
                    mergedArray[k++] = arr2[j++];
            }
            while (i < n1)
                mergedArray[k++] = arr1[i++];
            while (i < n2)
                mergedArray[k++] = arr2[j++];

        }
    }
}
