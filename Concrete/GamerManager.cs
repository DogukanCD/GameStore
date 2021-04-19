using System;
using GameStore.Abstract;
using GameStore.Entities;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Concrete
{
    class GamerManager : IGamerService
    {
        private IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Kişi doğrulandı. '{0}' eklendi.", gamer.FirstName);
            }
            else
            {
                Console.WriteLine("Kişi doğrulanamadı. '{0}' eklenemedi.", gamer.LastName);
            }
        }
            public void Update(Gamer gamer)
            {
                Console.WriteLine("Kayıt güncellendi.");
            }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi.");
        }
        }
    }

