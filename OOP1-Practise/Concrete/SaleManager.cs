using System;
using System.Collections.Generic;
using System.Text;
using OOP1_Practise.Entities;
using OOP1_Practise.Services;

namespace OOP1_Practise.Managers
{
    class SaleManager : ISaleServices
    {
        ICompaignServices _compaignServices;

        public SaleManager(ICompaignServices compaignServices)
        {
           _compaignServices = compaignServices;
        }


        public void SellTo(Game game, Player player,Compaign compaign)
        {
            game.Price = _compaignServices.CalculateDiscount(compaign, game);
            Console.WriteLine(player.FirstName + " adlı kullanıcı " + game.GameName + " adlı oyunu " + game.Price + " fiyatında aldı ");

        }
    }
}
