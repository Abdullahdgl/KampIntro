using System;
using System.Collections.Generic;

namespace DictionaryKomutu2
{
	class Program
	{
		static void Main(string[] args)
		{
			//4.Gün 5.Odev Mylistin ekleme method formatını Dictionary Methodunu kullanarak sadece ekleme yapılması.
			Dictionary<string, int> myDictionary = new Dictionary<string, int>();
			myDictionary.Add("Elma", 60);
			myDictionary.Add("Portakal", 35);
			myDictionary.Add("Kiraz", 48);
			myDictionary.Add("Karpuz", 98);
			Console.WriteLine(myDictionary.Count);


		}
	}
}
