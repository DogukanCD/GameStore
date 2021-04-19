using System;
using GameStore.Abstract;
using GameStore.Entities;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Concrete
{
    class GamerCheckManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
