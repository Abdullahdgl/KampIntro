using System;

namespace Vasita
{
	class Program
	{
		static void Main(string[] args)
		{
			Otomobil otomobil1 = new Otomobil();
			otomobil1.Marka = "BMW";
			otomobil1.Model = "X5";
			otomobil1.Kilometre = 150000;
			otomobil1.Yas = 15;

			Otomobil otomobil2 = new Otomobil();
			otomobil2.Marka = "MERCEDES";
			otomobil2.Model = "AMG 180";
			otomobil2.Kilometre = 43000;
			otomobil2.Yas = 4;

			Motosiklet motosiklet1 = new Motosiklet();
			motosiklet1.Marka = "SUZUKİ";
			motosiklet1.Model = "B-KING";
			motosiklet1.Kilometre = 71000;
			motosiklet1.Yas = 7;

			Motosiklet motosiklet2 = new Motosiklet();
			motosiklet2.Marka = "KAWASAKİ";
			motosiklet2.Model = "EL 250";
			motosiklet2.Kilometre = 41000;
			motosiklet2.Yas = 1;

			Otomobil[] otomobilller = new Otomobil[] { otomobil1, otomobil2 };
			Motosiklet[] motosikletler = new Motosiklet[] { motosiklet1, motosiklet2 };

			int j = 0;
			while (j<otomobilller.Length )
			{
				Console.WriteLine(otomobilller[j].Marka + " / " + otomobilller[j].Model + " / " + otomobilller[j].Kilometre + " / " + otomobilller[j].Yas);
				

				j++;
			}
			int k = 0;
			while (k < motosikletler.Length)
			{
				
				Console.WriteLine(motosikletler[k].Marka + " / " + motosikletler[k].Model + " / " + motosikletler[k].Kilometre + " / " + motosikletler[k].Yas);

				k++;
			}






			//Otomobil[] otomobilller = new Otomobil[] { otomobil1, otomobil2 };
			//for (int i = 0; i < otomobilller.Length; i++)
			//{
			//	Console.WriteLine(otomobilller[i].Model +" / "+ otomobilller[i].Model +" / "+ otomobilller[i].Kilometre+ " / "+ otomobilller[i].Yas);
			//}

			//Motosiklet[] motosikletler = new Motosiklet[] { motosiklet1, motosiklet2 };
			//for (int i = 0; i < motosikletler.Length; i++)
			//{
			//	Console.WriteLine(motosikletler[i].Model + " / " + motosikletler[i].Model + " / " + motosikletler[i].Kilometre + " / " + motosikletler[i].Yas);
			//}


			//Otomobil[] otomobilller = new Otomobil[] {otomobil1,otomobil2};
			//foreach (var otomobil in otomobilller)
			//{
			//	Console.WriteLine(otomobil.Marka + " / " + otomobil.Model + " /  " + otomobil.Kilometre + " / " + otomobil.Yas);

			//}

			//Motosiklet[] motosikletler = new Motosiklet[] {motosiklet1,motosiklet2 };
			//foreach (var motosiklet in motosikletler)
			//{
			//	Console.WriteLine(motosiklet.Marka +"  / "+ motosiklet.Model + " / " + motosiklet.Kilometre + " / " + motosiklet.Yas);
			//}


		}
	}

	class Otomobil
	{
		public string Marka { get; set; }
		public string Model { get; set; }
		public int Kilometre { get; set; }
		public int Yas { get; set; }
	}
	class Motosiklet
	{
		public string Marka { get; set; }
		public string Model { get; set; }
		public int Kilometre { get; set; }
		public int Yas { get; set; }

	}
	
}
