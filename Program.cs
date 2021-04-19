using System;
using GameStore.Concrete;
using GameStore.Entities;

namespace GameStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer
            {
                IdentityNumber = 123456;
                FirstName = "Doğukan";
                LastName = "Orhan";
                BirthYear = 1996;
            };
            Game game = new Game
            {
                GameName = "Snake";
                GamePrice = 10;
            };
            Campaign campaign = new Campaign
            {
                CampaignName = "Sales Discount";
                CampaignDiscount = 0.50;
            };
            GamerManager gamerManager = new GamerManager();
            gamerManager.Add(gamer);
            SalesManager salesManager = new SalesManager();
            salesManager.Add(gamer, game, campaign);

        }
    }
}
