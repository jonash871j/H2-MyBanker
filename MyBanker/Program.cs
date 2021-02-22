using MyBanker.Cards;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Card> cards = new List<Card>();
        cards.Add(new Haevekort("Name 1"));
        cards.Add(new Maestro("Name 2", 2024, 2));
        cards.Add(new Mastercard("Name 3", 2023, 5));
        cards.Add(new VISA("Name 4", 2022, 4));
        cards.Add(new VISAElectron("Name 5", 2024, 3));

        foreach (Card card in cards)
        {
            Console.WriteLine(card.ToString());
        }
    }
}
