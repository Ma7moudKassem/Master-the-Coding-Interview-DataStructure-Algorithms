namespace DataStructures_And_Algorithms.BigO.WhatIsGoodCode
{
    public class FindMody
    {
		public string findMody(string[] arr)
		{
	
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] == "mody")
				{
					return "Mody has finded!!";
				}
			}
			return "Ooh Sorry Mody hasn't findrd";

		}
	}
}
