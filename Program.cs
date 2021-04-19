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
                IdentityNumber = 11111111111,
                FirstName = "Gökhan",
                LastName = "Karakuş",
                BirthYear = 1111
            };
            Game game = new Game
            {
                GameName = "Snake",
                GamePrice = 99
            };
            Campaign campaign = new Campaign
            {
                CampaignName = "Sales Discount",
                CampaignDiscount = 0.50
            };
            GamerManager gamerManager = new GamerManager();
            gamerManager.Add(gamer);
            SalesManager salesManager = new SalesManager();
            salesManager.Add(gamer, game, campaign);

        }
    }
}