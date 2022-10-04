using System;
using OOP1_Practise.Managers;
using OOP1_Practise.Entities;

namespace OOP1_Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------OYUNCU İŞLEMLERİ----------");
            PlayerManager playerManager = new PlayerManager(new UserValidationManager());
            Player player1 = new Player();
            player1.Id = 1;
            player1.BirthDay = 2001;
            player1.FirstName = "CIGDEM";
            player1.LastName = "KILIC";
            player1.IdentityNumber = 1234;

            playerManager.add(player1);
            // kişi gerçek mi diye UserValidationManagerda check edilir gerçekse kişi oyuncu olarak eklenir.

            Player player2 = new Player();
            player1.Id = 1;
            player1.BirthDay = 2001;
            player1.FirstName = "CIGDEM";
            player1.LastName = "KILIC";
            player1.IdentityNumber = 78378;

            Console.WriteLine("");
            Console.WriteLine("kimlik no değiştim ve kayıt yapmasını istedim sonuc: ");
            playerManager.add(player1);

            Console.WriteLine("");
            playerManager.Update(player1);
            playerManager.Delete(player1);

            Console.WriteLine("");
            Console.WriteLine("----------OYUN İŞLEMLERİ------------");
            Game game1 = new Game() { Id = 1, GameName = "Counter Strike 1.6", Price = 100 };
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);

            Console.WriteLine("");
            Console.WriteLine("----------KAMPANYA İŞLEMLERİ---------");
            CompaignManager compaignManager = new CompaignManager();
            Compaign compaign1 = new Compaign() { Id = 1, CompaignName = "For Counter Strike", DiscountRate = 20 };
            compaignManager.Add(compaign1);

            Console.WriteLine("");
            Console.WriteLine("----------SATIŞ İŞLEMLERİ------------");
            SaleManager saleManager = new SaleManager(new CompaignManager());
            saleManager.SellTo(game1, player1, compaign1);




        }
    }
}
