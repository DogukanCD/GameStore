using System;
using GameStore.Abstract;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Entities
{
    class Game : IEntity
    {
        public int Id { get; set; }
        public String GameName { get; set; }
        public double GamePrice { get; set; }

    }
}
