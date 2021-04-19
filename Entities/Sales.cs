using System;
using GameStore.Abstract;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Entities
{
    class Sales : IEntity
    {
        public int Id { get; set; }
        public DateTime SalesDate { get; set; }

    }
}
