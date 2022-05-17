using System;

namespace KampIntro
{
	class Program
	{
		static void Main(string[] args)
		{
			//type safety - tip güvenliği
			//Do not repeat yourself - Kendini Tekrarlama
			//Deger Tutucu - Alians

			string KategoriEtiketi = "Kategoriler";
			int OgrenciSayisi = 32000;
			double FaizOrani = 1.45;
			bool SistemGirisYapmismi = true;
			double DolarDun = 7.35;
			double DolarBugun = 7.45;


			if (DolarDun > DolarBugun)
			{
				Console.WriteLine("Azalış Butonu Göster");

			}

			else if (DolarDun<DolarBugun)
			{
				Console.WriteLine("Artış Butonu Göster");
			}
			else
			{
				Console.WriteLine("Değişmedi. Butonu Göster");
			}

			if (SistemGirisYapmismi == true)
			{
				Console.WriteLine("Kullanıcı Ayarlar Butonu ");
			}
			else
			{
				Console.WriteLine("Giriş Yap Butonu");

			}
			Console.WriteLine(KategoriEtiketi);


		}
	}
}
