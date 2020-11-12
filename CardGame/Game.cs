using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CardGame
{
    class Game
    {
        public List<Player> PlayerList { get; }  = new List<Player>();

        public List<Card> CardDeck { get; private set; } = new List<Card>();

       public Game(params Player[] players) {
            if (players.Length >= 2)
            {
                foreach (Player item in players)
                    PlayerList.Add(item);
            }
            else {
                Console.WriteLine("гравців має бути 2 і більше");
            }

            NewCardDeck();
            InterfereDeck();
        }

        public void InterfereDeck() {
            Random beg = new Random();
            int z, y;
            for (int i = 0; i < 150; i++)
            {
                z = beg.Next(0, 36);
                y = beg.Next(0, 36);
                (CardDeck[z], CardDeck[y]) = (CardDeck[y], CardDeck[z]);
            }
        }

        public void DistributionCards() {
            do
            {
                for (int i = 0; i < PlayerList.Count(); i++)
                {
                    PlayerList[i].AddCard(CardDeck.First());
                    CardDeck.Remove(CardDeck.First());
                }
            } while (CardDeck.Count() >= PlayerList.Count());
        }

        public void NewCardDeck() {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 9; j++)
                    CardDeck.Add(new Card((CardSuit)i, (CardRank)j));

        }

        public void GameProcess() {
            List<Card> tmp = new List<Card>();
            do
            {

                foreach (Player i in PlayerList) {
                    Thread.Sleep(200);
                    Console.WriteLine($"гравець {i.Name} має {i.CardsInHand()} карт");
                }
               Console.WriteLine();
              foreach (Player i in PlayerList)
                {
                    Thread.Sleep(500);
                    if (i.CardsInHand() == 0) {
                        continue;
                    }
                    tmp.Add(i?.PutCard());
                }
                Thread.Sleep(500);
                Console.WriteLine($"\n{PlayerList[tmp.IndexOf(tmp.Max())].Name} виграв раунд\n");
                foreach (Card item in tmp) 
                    PlayerList[tmp.IndexOf(tmp.Max())].AddCard(item);
                tmp.Clear();
            } while (PlayerList.Where(x => x.CardsInHand() > 0).Count()!=1);

        }

    }
}
