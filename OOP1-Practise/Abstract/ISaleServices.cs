using System;
using System.Collections.Generic;
using System.Text;
using OOP1_Practise.Entities;

namespace OOP1_Practise.Services
{
    interface ISaleServices
    {
        void SellTo(Game game, Player player,Compaign compaign);
    }
}
