using DataStructures_And_Algorithms.BigO.WhatIsGoodCode;
using System.Diagnostics;

string[] mody = { "mody" };
string[] manyUsers = { "n" , "Kassem" , "Esraa" , "Ahmed" , "Abdo" };

FindMody obj = new FindMody();

//DateTime t0 = DateTime.Now;
Stopwatch stopwatch = new Stopwatch();
string[] largArray = new string[100000];
Array.Fill(largArray, "mody");
stopwatch.Start();
Console.WriteLine(obj.findMody(manyUsers));
stopwatch.Stop();

//DateTime t1 = DateTime.Now;

Console.WriteLine("The time had tooken for search on mody is " + stopwatch.Elapsed.TotalMilliseconds+" milliconds");

