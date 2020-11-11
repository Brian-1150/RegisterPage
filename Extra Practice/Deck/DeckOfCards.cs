
	int[] deck = new int[52];
	String [] suits = {"Spades", "Hearts", "Diamonds", "Clubs"};
	String [] ranks = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
	
	// Initilaize the cards
	for (int i = 0; i < deck.Length; i++)
		deck[i] = i;
	
	// Shuffle
	for (int i = 0; i < deck.Length; i ++) {
		// generate index at random
		Random rnd = new Random();
		int index = rnd.Next(1, 52);
		int temp = deck[i];
		deck [i] = deck[index];
		deck [index] = temp;
	}
	//Display all cards
for (int i = 0 ; i < 52; i++) {
	String suit = suits[deck[i] / 13];
	String rank = ranks[deck[i]% 13];
	System.out.println("Card number " + deck[i] + ": " 
	+ rank + " of " + suit);
}
}
}