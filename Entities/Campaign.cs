using System;
using GameStore.Abstract;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Entities
{
    class Campaign : IEntity
    {
        public int Id { get; set; }
        public String CampaignName { get; set; }
        public double CampaignDiscount { get; set; }

    }
}
