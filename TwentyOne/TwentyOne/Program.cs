using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            // ********uncomment to shuffle, leave comment to keep in order, this is a call 
            int timesShuffled = 0;
            deck = Shuffle(deck, out timesShuffled, 3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            

            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("Times shuffled {0}", timesShuffled);
            Console.ReadLine();
        }
        ///**************Method shuffling the deck*************************************
        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
        {
            
                timesShuffled = 0;
                for (int i = 0; i < times; i++)
                {
                    timesShuffled++;
                    List<Card> TempList = new List<Card>();
                    Random random = new Random();

                    while (deck.Cards.Count > 0)
                    {
                        int randomIndex = random.Next(0, deck.Cards.Count);
                        TempList.Add(deck.Cards[randomIndex]);
                        deck.Cards.RemoveAt(randomIndex);
                    }
                    deck.Cards = TempList;
                }
            
           
            return deck;
        }
        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;

        //}
    }
}




//***************Example to show too much work to add each card one at a time
//Deck deck = new Deck();
//deck.Cards = new List<Card>();

//Card cardOne = new Card();
//cardOne.Face = "Queen";
//cardOne.Suit = "Spades";

//deck.Cards.Add(cardOne);
//***************************************************************************