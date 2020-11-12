using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Player
    {
        public string Name { get; set; }

        private List<Card> cardInHand = new List<Card>();

        public Player(string name) => Name = name;
 
        public void ShowCards() {
            //Sort();
            Console.WriteLine($"Player {Name} cards:\n");
            foreach (Card item in cardInHand)
                item.ShowCard();
            Console.WriteLine();
        }

        public Card PutCard() {
                Card tmp = cardInHand.First();
                Console.WriteLine($"гравець {Name} кладе карту: ");
                cardInHand.First().ShowCard();
                cardInHand.Remove(cardInHand.First());
                return tmp;
         }
       
        public void AddCard(params Card[] z) => cardInHand.AddRange(z);

        //private void Sort() => cardInHand.Sort(new Sorted());

        public int CardsInHand() => cardInHand.Count();
    }
}
