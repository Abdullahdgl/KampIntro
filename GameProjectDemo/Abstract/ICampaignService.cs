using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
	public interface ICampaignService
	{
		void Add(Campaign campaign);
		void Delet(Campaign campaign);

		void Update(Campaign campaign);

	}
}
