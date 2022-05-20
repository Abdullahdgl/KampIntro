using System;
using System.Collections.Generic;

namespace GenericsIntro
{
	class Program
	{
		static void Main(string[] args)
		{
			MyList<string> isimler = new MyList<string>();
			isimler.Add("Engin");

			List<string> Liste = new List<string>();
			Console.WriteLine(Liste.Count);

			Console.WriteLine("Hello World!");
		}
	}
}
