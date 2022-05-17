using System;

namespace O_SwichCase
{
	class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Lütfen Bir Gün seçiniz...");
			//int sayi = Convert.ToInt32(Console.ReadLine());
			//switch (sayi)
			//{
			//	case 1:Console.WriteLine("Pazartesi");break;
			//	case 2:Console.WriteLine("Salı");break;
			//	case 3: Console.WriteLine("Çarşamba"); break;
			//	case 4: Console.WriteLine("Perşembe"); break;
			//	case 5: Console.WriteLine("Cuma"); break;
			//	case 6: Console.WriteLine("Cumartesi"); break;
			//	case 7: Console.WriteLine("Pazar"); break;

			//	default: Console.WriteLine("Hata Böyle bir gün yok"); break;
			//}

			//Console.WriteLine("Lütfen Bir Ay seçiniz..");
			//int ay = Int32.Parse(Console.ReadLine());
			//switch (ay)
			//{
			//	case 1: Console.WriteLine("OCAK");break;
			//	case 2: Console.WriteLine("ŞUBAT"); break;
			//	case 3: Console.WriteLine("MART"); break;
			//	case 4: Console.WriteLine("NİSAN"); break;
			//	case 5: Console.WriteLine("MAYIS"); break;
			//	case 6: Console.WriteLine("HAZİRAN"); break;
			//	case 7: Console.WriteLine("TEMMUZ"); break;
			//	case 8: Console.WriteLine("AĞUSTOS"); break;
			//	case 9: Console.WriteLine("EYLÜL"); break;
			//	case 10: Console.WriteLine("EKİM"); break;
			//	case 11: Console.WriteLine("KASIM"); break;
			//	case 12: Console.WriteLine("ARALIK"); break;

			//	default: Console.WriteLine("Hatalı Bir Ay seçmiş oldunuz."); break;
			//}
			Console.WriteLine("Lütfen trafik lambası rengini giriniz");
			string renk = Console.ReadLine();

			switch (renk)
			{
				case "kırmızı": Console.WriteLine("Dur"); break;
				case "sarı": Console.WriteLine("Hazır Ol"); break;
				case "yeşil": Console.WriteLine("İlerle"); break;

				default: Console.WriteLine("Böyle bir trafik rengi yok"); break;
			}

			Console.ReadLine();


		}
	}
}
