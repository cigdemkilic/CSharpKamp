using System;
using System.Collections.Generic;
using System.Text;
using OOP1_Practise.Entities;

namespace OOP1_Practise.Services
{
    interface ICompaignServices
    {
        void Add(Compaign compaign);
        void Update(Compaign compaign);
        void Delete(Compaign compaign);
        double CalculateDiscount(Compaign compaign, Game game);

    }
}
