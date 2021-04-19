using System;
using GameStore.Abstract;
using GameStore.Entities;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Concrete
{
    class SalesManager : ISalesManager
    {
        public void Add(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine("'A' oyunu 'B' a 'C' kampanyası ile D '$' karşılığında  satıldı", game.GameName, gamer.FirstName, campaign.CampaignName, game.GamePrice);
        }
        public void Update(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine("Kayıt güncellendi.");
        }
        public void Delete(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine("Kayıt silindi.");
        }
    }
}
