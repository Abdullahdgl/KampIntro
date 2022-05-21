using System;

namespace Dictonary
{
	class Program
	{
		static void Main(string[] args)
		{
			MyDictonary<string> dictonarys = new MyDictonary<string>();
			dictonarys.Add("Hasan");
			dictonarys.Add("Muhammed");
			dictonarys.Add("Mehmet");
			dictonarys.Add("Abdullah");
			Console.WriteLine(dictonarys.Length);

			dictonarys.Add("Ahmet");
			Console.WriteLine(dictonarys.Length);

			foreach (var dictonary in dictonarys.Items)
			{
				Console.WriteLine(dictonary);
			}
		}
	}
}
