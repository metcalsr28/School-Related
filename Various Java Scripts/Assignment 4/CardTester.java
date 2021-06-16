public class CardTester {
    public static void main(String [] args)
    {
        System.out.println("*TESTING Card()*");
        Card card1 = new Card();
        System.out.println(card1.toString());

        System.out.println("*TESTING Card(int suit, int rank)*");
        Card card2 = new Card(2, 2);
        Card card3 = new Card(3, 6);
        System.out.println(card2.toString());
        System.out.println(card3.toString());

        System.out.println("*TESTING getRank()*");
        System.out.println("*getRank()*");
        System.out.println(card1.getRank());
        System.out.println("*getRank()*");
        System.out.println(card2.getRank());
        System.out.println("*getRank()*");
        System.out.println(card3.getRank());

        System.out.println("*TESTING getSuit()*");
        System.out.println("*getSuit()*");
        System.out.println(card1.getSuit());
        System.out.println("*getSuit()*");
        System.out.println(card2.getSuit());
        System.out.println("*getSuit()*");
        System.out.println(card3.getSuit());

        System.out.println("*TESTING setRank(int rank)*");
        System.out.println("*setRank()*");
        card1.setRank(7);
        System.out.println("*setRank()*");
        card2.setRank(8);
        System.out.println("*setRank()*");
        card3.setRank(9);
        System.out.println("*getRank()*");
        System.out.println(card1.getRank());
        System.out.println("*getRank()*");
        System.out.println(card2.getRank());
        System.out.println("*getRank()*");
        System.out.println(card3.getRank());

        System.out.println("*TESTING setSuit (int suit)*");
        System.out.println("*setSuit()*");
        card1.setSuit(4);
        System.out.println("*setSuit()*");
        card2.setSuit(3);
        System.out.println("*setSuit()*");
        card3.setSuit(2);
        System.out.println("*getSuit()*");
        System.out.println(card1.getSuit());
        System.out.println("*getSuit()*");
        System.out.println(card2.getSuit());
        System.out.println("*getSuit()*");
        System.out.println(card3.getSuit());

        System.out.println("*TESTING sameSuit(Card other)*");
        System.out.println("Card 1 = Card 2");
        System.out.println(card1.sameSuit(card2));

        System.out.println("*TESTING compareTo(Card other)*");
        System.out.println("Card 1 - Card 2");
        System.out.println(card1.compareTo(card2));
        System.out.println("*TESTING card3.getRankAsString()*");
        System.out.println(card3.getRankAsString());

        System.out.println("*TESTING card3.getSuitAsString()*");
        System.out.println(card3.getSuitAsString());

        System.out.println("*TESTING card1.toString()*");
        System.out.println(card1.toString());


    }
}

//*TESTING Card()*
//        This card is a 2 of SPADES
//        *TESTING Card(int suit, int rank)*
//        This card is a 2 of HEARTS
//        This card is a 6 of CLUBS
//        *TESTING getRank()*
//        *getRank()*
//        2
//        *getRank()*
//        2
//        *getRank()*
//        6
//        *TESTING getSuit()*
//        *getSuit()*
//        1
//        *getSuit()*
//        2
//        *getSuit()*
//        3
//        *TESTING setRank(int rank)*
//        *setRank()*
//        *setRank()*
//        *setRank()*
//        *getRank()*
//        7
//        *getRank()*
//        8
//        *getRank()*
//        9
//        *TESTING setSuit (int suit)*
//        *setSuit()*
//        *setSuit()*
//        *setSuit()*
//        *getSuit()*
//        4
//        *getSuit()*
//        3
//        *getSuit()*
//        2
//        *TESTING sameSuit(Card other)*
//        Card 1 = Card 2
//        false
//        *TESTING compareTo(Card other)*
//        Card 1 - Card 2
//        -1
//        *TESTING card3.getRankAsString()*
//        rank: 9
//        *TESTING card3.getSuitAsString()*
//        HEARTS
//        *TESTING card1.toString()*
//        This card is a 7 of DIAMONDS
