using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryKomutu
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			1-) Dictionary Classı içinde sizin belirleyeceğiniz bir key e uygun olarak değer saklar 
			zorunluluğu var.
			2-) Key türünü belirlemeniz şart(string, int vs...) 
			 */
		
			
			Dictionary<string, int> AdYas = new Dictionary<string, int>();
			//veri ekliyoruz...
			AdYas.Add("Abdullah", 28);
			AdYas.Add("Mehmet", 27);
			AdYas.Add("Muhammed", 28);
			foreach (var degeroku in AdYas)
			{
				Console.WriteLine(degeroku);
			}
		}
	}
}
