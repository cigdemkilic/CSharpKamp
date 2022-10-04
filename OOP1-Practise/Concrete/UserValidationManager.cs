using System;
using System.Collections.Generic;
using System.Text;
using OOP1_Practise.Entities;
using OOP1_Practise.IClass;

namespace OOP1_Practise.Managers
{
    class UserValidationManager : IUserValidationServices
    {
        public bool Validate(Player player)
        {
            if (player.BirthDay == 2001 && player.FirstName == "CIGDEM"
                && player.LastName == "KILIC" && player.IdentityNumber == 1234)
            {
                return true;
            }
            else
                return false;
        }
    }
}
