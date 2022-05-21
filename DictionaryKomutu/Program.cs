using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryKomutu
{
	internal class Program
	{
		static void Main(string[] args)
		{

			MyDictionary<string,int> myDictionaries = new MyDictionary<string, int>();
			myDictionaries.Add("ALPHA", 15);
			myDictionaries.Add("TETHE", 24);

			for (int i = 0; i < myDictionaries.Values.Length; i++)
			{
				Console.WriteLine(myDictionaries.Keys[i] + " " + myDictionaries.Values[i]);
			}
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			///*
			//1-) Dictionary Classı içinde sizin belirleyeceğiniz bir key e uygun olarak değer saklar 
			//zorunluluğu var.
			//2-) Key türünü belirlemeniz şart(string, int vs...) 
			// */
		
			
			//Dictionary<string, int> AdYas = new Dictionary<string, int>();
			////veri ekliyoruz...
			//AdYas.Add("Abdullah", 28);
			//AdYas.Add("Mehmet", 27);
			//AdYas.Add("Muhammed", 28);
			//foreach (var degeroku in AdYas)
			//{
			//	Console.WriteLine(degeroku);
			//}
		}
	}
}
