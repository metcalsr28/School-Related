public class Card implements CardInterface
{
    private int _rank;
    private int _suit;


    public Card()
    {
        this.setRank(TWO);
        this.setSuit(SPADES);
    }
    public Card(int suit, int rank)
    {
        if (rank > 1 && rank < 15)
        {
            this.setRank(rank);
        }
        else
        {
            this.setRank(TWO);
        }
        if (suit > 0 && suit < 5)
        {
            this.setSuit(suit);
        }
        else
        {
            this.setSuit(SPADES);
        }
    }

    @Override
    public void setRank(int rank) {
        this._rank = rank;
    }

    @Override
    public int getRank() {
        return _rank;
    }

    @Override
    public void setSuit(int suit) {
        this._suit = suit;
    }

    @Override
    public int getSuit() {
        return _suit;
    }

    @Override
    public boolean sameSuit(Card other) {
        return _suit == other.getSuit();
    }

    @Override
    public int compareTo(Card other) {
        if (other != null)
        {
            return _rank - other.getRank();
        }
        else
            {
                return Integer.MAX_VALUE;
            }

    }

    @Override
    public String getRankAsString() {
        String rankString = "2";
        switch (_rank)
        {
            case 2:
                rankString = "2";
                break;
            case 3:
                rankString = "3";
                break;
            case 4:
                rankString = "4";
                break;
            case 5:
                rankString = "5";
                break;
            case 6:
                rankString = "6";
                break;
            case 7:
                rankString = "7";
                break;
            case 8:
                rankString = "8";
                break;
            case 9:
                rankString = "9";
                break;
            case 10:
                rankString = "10";
                break;
            case 11:
                rankString = "JACK";
                break;
            case 12:
                rankString = "QUEEN";
                break;
            case 13:
                rankString = "KING";
                break;
            case 14:
                rankString = "ACE";
                break;
        }
        return "rank: " +rankString;
    }

    @Override
    public String getSuitAsString() {
        String suitString = "None";
        switch (_suit) {
            case 1:
                suitString = "SPADES";
                break;
            case 2:
                suitString = "HEARTS";
                break;
            case 3:
                suitString = "CLUBS";
                break;
            case 4:
                suitString = "DIAMONDS";
                break;
        }
        return suitString;
    }

    @Override
    public String toString() {
        String rankString = "2";
        switch (_rank)
        {
            case 2:
                rankString = "2";
                break;
            case 3:
                rankString = "3";
                break;
            case 4:
                rankString = "4";
                break;
            case 5:
                rankString = "5";
                break;
            case 6:
                rankString = "6";
                break;
            case 7:
                rankString = "7";
                break;
            case 8:
                rankString = "8";
                break;
            case 9:
                rankString = "9";
                break;
            case 10:
                rankString = "10";
                break;
            case 11:
                rankString = "JACK";
                break;
            case 12:
                rankString = "QUEEN";
                break;
            case 13:
                rankString = "KING";
                break;
            case 14:
                rankString = "ACE";
                break;
        }

        String suitString = "None";
        switch (_suit) {
            case 1:
                suitString = "SPADES";
                break;
            case 2:
                suitString = "HEARTS";
                break;
            case 3:
                suitString = "CLUBS";
                break;
            case 4:
                suitString = "DIAMONDS";
                break;
        }
        return "This card is a " + rankString + " of " + suitString;
    }
}
