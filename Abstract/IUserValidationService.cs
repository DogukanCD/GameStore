using System;
using GameStore.Entities;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Abstract
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
