using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;


namespace GameProjectDemo.Concrete
{
	public class CampaignManager : ICampaignService
	{
		public void Add(Campaign campaign)
		{
			Console.WriteLine(campaign.CampaingnName + "Kampanya Eklendi.");
			Console.WriteLine("Kampanya İndirimi : % " + campaign.CampaingnDiscount);
		}

		public void Delet(Campaign campaign)
		{
			Console.WriteLine(campaign.CampaingnName + " Kampanya Kaldırıldı.");
			
		}

		public void Update(Campaign campaign)
		{
			Console.WriteLine(campaign.CampaingnName + "Kampanya Güncellendi.");
			Console.WriteLine("Kampanya İndirimi : % " + campaign.CampaingnDiscount);
		}
	}
}
