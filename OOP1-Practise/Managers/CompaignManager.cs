using System;
using System.Collections.Generic;
using System.Text;
using OOP1_Practise.Entities;
using OOP1_Practise.Services;

namespace OOP1_Practise.Managers
{
    class CompaignManager : ICompaignServices
    {
        public void Add(Compaign compaign)
        {
            Console.WriteLine(compaign.CompaignName + " adlı " + compaign.DiscountRate + " indirim oranlı kampanya eklendi");
        }

        public double CalculateDiscount(Compaign compaign, Game game)
        {
            double newPrice = (game.Price / 100) * compaign.DiscountRate;
            newPrice = game.Price - newPrice;
            game.Price = newPrice;

            return game.Price;
        }

        public void Delete(Compaign compaign)
        {
            Console.WriteLine(compaign.CompaignName + " silindi");
        }

        public void Update(Compaign compaign)
        {
            Console.WriteLine(compaign.CompaignName + " güncellendi");
        }
    }
}
