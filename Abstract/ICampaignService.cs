using System;
using GameStore.Entities;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Abstract
{
    interface ICampaignService 
    {
        public void Add(Campaign campaign);
        public void Update(Campaign campaign);
        public void Delete(Campaign campaign);

    }
}
