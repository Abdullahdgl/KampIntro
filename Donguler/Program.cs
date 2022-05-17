using System;

namespace Donguler
{
	class Program
	{
		static void Main(string[] args)
		{
			string Kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
			string Kurs2 = "Programlamaya başlangiç için temel kurs";
			string Kurs3 = "Java";

			// array - dizi

			string[] Kursalar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
				"Programlamaya başlangiç için temel kurs",
				"Java" };


			for (int i = 0; i < Kursalar.Length; i++)
			{
				Console.WriteLine(Kursalar[i]);
			}
			Console.WriteLine("for bitti.");

			foreach (string kurs in Kursalar)
			{
				Console.WriteLine(kurs);
			}

			Console.WriteLine("Sayfa Sonu - Footer");
		}
	}
}
