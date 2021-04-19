using System;
using GameStore.Entities;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Abstract
{
    interface ISalesManager
    {
        public void Add(Gamer gamer, Game game, Campaign campaign);
        public void Delete(Gamer gamer, Game game, Campaign campaign);
        public void Update(Gamer gamer, Game game, Campaign campaign);
    }
}
