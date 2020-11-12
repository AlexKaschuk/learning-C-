using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Alex = new Player("Alex");
            Player Bob = new Player("Bob");
            Player John = new Player("John");
            Game game = new Game(Alex, Bob, John);

            game.DistributionCards();

           

            game.GameProcess();


            

        }
    }
}
