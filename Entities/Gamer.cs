using System;
using GameStore.Abstract;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Entities
{
    class Gamer : IEntity
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int BirthYear { get; set; }
        public long IdentityNumber { get; set; }

    }
}
