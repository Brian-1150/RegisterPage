using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck
{
    class Program
    {
        static void Main(string[] args) {

		int[] deck = new int[52];
			String[] suits = { "Spades", "Hearts", "Diamonds", "Clubs" };
			String[] ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

			// Initilaize the cards
			for (int i = 0; i < deck.Length; i++)
				deck[i] = i;

			// Shuffle
			/*
			for (int i = 0; i < deck.Length; i++) {
				// generate index at random
				int index = IntUtil.Random(1, 52);
				int temp = deck[i];
				deck[i] = deck[index];
				deck[index] = temp;
			*/

			
			int key = 0;
			int picks = 0;
			int total = 0;
			Boolean[] getCard = new bool[4];
			while (total < 4) {
				picks++;
				key = IntUtil.Random(1, 52);
				if (!getCard[key / 13]) {
					getCard[key / 13] = true;
					total++;
					Console.WriteLine(ranks[key % 13] + " of " + suits[key / 13] + picks);
				}
			}

            //Display all cards
			/*
            for (int i = 0; i < 52; i++) {
				String suit = suits[deck[i] / 13];
				String rank = ranks[deck[i] % 13];

				Console.WriteLine("Card number " + deck[i] + ": "
				+ rank + " of " + suit);
						*/
			}
		}
	}

    

