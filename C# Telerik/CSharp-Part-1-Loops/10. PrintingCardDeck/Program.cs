using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PrintingCardDeck
{
    class Program
    {
        static void Main(string[] args)
        {

            string card = "";

            for (int CardSuit = 1; CardSuit <= 4; CardSuit++)
            {
                for (int CardNum = 2; CardNum <= 14; CardNum++)
                {
                    if (CardNum <= 10)
                    {
                        card += CardNum.ToString();
                    }
                    else
                    {
                        switch (CardNum)
                        {
                            case 11: card += "A"; break;
                            case 12: card += "J"; break;
                            case 13: card += "Q"; break;
                            case 14: card += "K"; break;
                        }
                    }

                    switch (CardSuit)
                    {
                        case 1: card += " ♠"; break;
                        case 2: card += " ♥"; break;
                        case 3: card += " ♦"; break;
                        case 4: card += " ♣"; break;
                    }

                    //Printing card
                    Console.WriteLine(card);
                    card = "";
                }
                Console.WriteLine();
            }
        }
    }
}
