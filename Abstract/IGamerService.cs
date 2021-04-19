using System;
using GameStore.Entities;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Abstract
{
    interface IGamerService
    {
        public void Add(Gamer gamer);
        public void Update(Gamer gamer);
        public void Delete(Gamer gamer);
    }
}
