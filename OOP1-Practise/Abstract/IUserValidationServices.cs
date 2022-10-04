using System;
using System.Collections.Generic;
using System.Text;
using OOP1_Practise.Entities;

namespace OOP1_Practise.IClass
{
    public interface IUserValidationServices
    {
        bool Validate(Player player);
    }
}
