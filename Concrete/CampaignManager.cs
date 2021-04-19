using System;
using GameStore.Abstract;
using GameStore.Entities;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "isimli yeni kampanya eklendi.");
        }
        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "isimli kampanya güncellendi.");
        }
        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "isimli kampanya silindi.");
        }
    }
}
