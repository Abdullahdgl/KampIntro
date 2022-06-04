using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
	public class GamerManager : IGamerService
	{
		public GamerManager()
		{

		}
		private IVerificationService verificationService;
		public GamerManager(IVerificationService verificationService)
		{
			this.verificationService = verificationService;

		}
		public void Add(Gamer gamer)
		{
			if (verificationService.CheckIfRealPerson(gamer))
			{
				Console.WriteLine(gamer.FirstName + " " + gamer.LastName + "Adlı oyuncu Kaydedilmiştir.");
			}
			else
			{
				Console.WriteLine( " Bilgileriniz Tekrar Kontrol Ediniz.");
			}
		}

		public void Delete(Gamer gamer)
		{
			Console.WriteLine(gamer.FirstName + " "+ gamer.LastName + " Adlı Oyuncu Silindi.");
		}

		public void Update(Gamer gamer)
		{
			Console.WriteLine(gamer.FirstName + gamer.LastName  + " Adlı oyuncunun bilgileri güncellendi.");

		}
	}
}
