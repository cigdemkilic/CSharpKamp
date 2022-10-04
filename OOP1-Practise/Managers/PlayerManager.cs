using System;
using System.Collections.Generic;
using System.Text;
using OOP1_Practise.Entities;
using OOP1_Practise.IClass;

namespace OOP1_Practise.Managers
{
    public class PlayerManager : IPlayerServices
    {
        // bir manager içinde başka bir manager kulanacaksan asla onu newleme
        // onun yerıne şunu yap:
        IUserValidationServices _userValidationServices;
        public PlayerManager(IUserValidationServices userValidationServices)
        {
            _userValidationServices = userValidationServices;
        }
        public void add(Player player)
        {
            if (_userValidationServices.Validate(player)== true) {
                Console.WriteLine("kayıt oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız..Kayıt başarısız!");
            }
        }

        public void Delete(Player player)
        {
            Console.WriteLine("kayıt silindi");
        }

        public void Update(Player player)
        {
            Console.WriteLine("kayıt güncellendi");
        }
    }
}
