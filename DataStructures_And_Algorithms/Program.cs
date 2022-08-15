////using DataStructures_And_Algorithms.BigO.WhatIsGoodCode;
////using System.Diagnostics;

////string[] mody = { "mody" };
////string[] manyUsers = { "n" , "Kassem" , "Esraa" , "Ahmed" , "Abdo" };

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

using DataStructures_And_Algorithms.DS_Hash_Table;

HashTable hashTable = new HashTable(50);

hashTable.set("Kassem", 1224176036);
hashTable.set("Ahmed", 1224376036);
hashTable.set("Esraa", 1224676036);


