
////using DataStructures_And_Algorithms.BigO.WhatIsGoodCode;
////using System.Diagnostics;

////string[] mody = { "mody" };
////string[] manyUsers = { "n" , "Kassem" , "Ahmed"};

////FindMody obj = new FindMody();

//////DateTime t0 = DateTime.Now;
////Stopwatch stopwatch = new Stopwatch();
////string[] largArray = new string[100000];
////Array.Fill(largArray, "mody");
////stopwatch.Start();
////Console.WriteLine(obj.findMody(manyUsers));
////stopwatch.Stop();

//////DateTime t1 = DateTime.Now;

////Console.WriteLine("The time had tooken for search on mody is " + stopwatch.Elapsed.TotalMilliseconds+" milliconds");
////[]

////bool IsSimelar(string[] arr1 , string[] arr2)
////{
////    for (int i = 0; i < arr1.Length; i++)
////    {
////        for (int j = 0; j < arr2.Length; j++)
////        {
////            if (arr1[i] == arr2[j])
////                return true;
////        }

////    }
////    return false;
////}


//////['m' , 'c' , 'o' ,]

////Console.WriteLine($"This is {IsSimelar(n, m)}"); 
////O(n^2)

//using System.IO;
//Dictionary<string, string> map = new Dictionary<string, string>();
//string[] array1 = { "a", "b", "c", "d" };
//string[] array2 = { "m", "b", "o" };


////var map = new{ };

//bool containsCommonItem2(string[] arr1, string[] arr2)
//{
//    for (int i = 0; i < arr1.Length; i++)
//    {
//        if (!map.Contains(Index[i]))
//        {
//            item = array1[i];
//            map[item] = true;
//        }
//    }

//}

//bool IsContain(string[] arr1 , string[] arr2)=>
//    arr1.First(e=>arr2.i)



//MyArray myArr = new MyArray();

//myArr.push('a');
//myArr.push('b');
//myArr.push('d');
//myArr.push('e');
//myArr.push('f');
////myArr.pop();
////myArr.pop();
//myArr.delete(3);
//for (int i = 0 ; i< 5;i++)
//    Console.WriteLine($"{myArr.get(i)}");

//string m = "mahmoud";
//var item=m.ToArray();
//for(int i = 6; i>=0;i-- )
//    Console.Write(item[i]);

//void reverseString(string word)
//{
//    var items2 =new { };
//    var item= word.ToArray();
//    for(int i = item.Length-1; i>=0;i-- )
//        Console.Write(item[i]);

//}

////reverseString("Hi My name is Andrei");

//string m = "Kassem";
//var item = m.Reverse();
//Console.WriteLine(item.GetType().FullName);

//[1, 3, 5, 7]
//[2, 4, 6, 8]



//Merge Sorted Array

/*
int[] Array1 = { 1, 3, 5, 7 };
int n1 = Array1.Length;
int[] Array2 = { 2, 4, 6, 8 };
int n2 = Array2.Length;
int[] Array3 = new int[n1 + n2];

MergeTwoSortedArrays.mergingTwoSortedArray(Array1, Array2, Array3,n1,n2);


for (int i = 0; i < Array3.Length; i++)
    Console.Write(Array3[i]);
*/

/* ==> HashTable
using DataStructures_And_Algorithms.DS_Hash_Table;

HashTable hashTable = new HashTable(50);

hashTable.set("Kassem", 1224176036);
hashTable.set("Ahmed", 1224376036);
 */

/*
 using System.Collections;
using System.Collections.Specialized;

int[] arr1 = { 3 , 2,1,3};
int findFirstRecuringNumber(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] == arr[j])
            {
                Console.WriteLine(arr[i]);
                return 0;
            }
        }
    }
    Console.WriteLine("Undefined");
    return 0;
}
findFirstRecuringNumber(arr1);// O(n^2)

int findFirstRecuringNumber2(int[] arr)
{
    Hashtable hashtable = new Hashtable();
    for (int i = 0; i < arr.Length; i++)
    {
        if (hashtable.ContainsKey(arr[i]))
            return arr[i];
        else
            hashtable[arr[i]] = arr[i];
    }
    return 0;

}// O(n)

Console.WriteLine(findFirstRecuringNumber2(arr1));
 */

//using Microsoft.VisualBasic.FileIO;
//using System.Security.Cryptography.X509Certificates;

//object mody = new object();
//object mody1 = new object();
//mody = new 
//{
//     name = "Kassem",
//    num = 0123444,
//};
//mody1 = mody;
//Console.WriteLine(mody);
//Console.WriteLine(mody1);

//using DataStructures_And_Algorithms.DS_LinkedList;

//MyLinkedList myLinkedList = new MyLinkedList(10);

//myLinkedList.append(20);
//myLinkedList.append(30);
//myLinkedList.append(40);
//myLinkedList.append(50);
//myLinkedList.insert(3, 99);
//myLinkedList.remove(0);
//myLinkedList.printList();

/*  ==> Stack By Array and LinkedList
 using DataStructures_And_Algorithms.DS_Stack;

StackArray newStack = new StackArray();
newStack.push(3);
newStack.push(5);
newStack.peek();
newStack.printStack();
 */