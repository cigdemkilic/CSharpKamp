using System;
using System.Collections.Generic;
using System.Text;
using OOP1_Practise.Entities;
using OOP1_Practise.Services;

namespace OOP1_Practise.Managers
{
    class GameManager : IGameServices
    {
        List<Game> games = new List<Game>() { };
        public void Add(Game game)
        {
            games.Add(game);
            Console.WriteLine(game.GameName + " adlı "+ game.Price+ " fiyatındaki oyun kaydedildi");
        }
    }
}
