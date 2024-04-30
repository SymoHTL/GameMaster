namespace Model.Factories;

public static class CardFactory {
    public static Card FromRank(Suit suit, int rank) {
        return rank switch {
            1 => new Ace(suit),
            2 => new Two(suit),
            3 => new Three(suit),
            4 => new Four(suit),
            5 => new Five(suit),
            6 => new Six(suit),
            7 => new Seven(suit),
            8 => new Eight(suit),
            9 => new Nine(suit),
            10 => new Ten(suit),
            11 => new Jack(suit),
            12 => new Queen(suit),
            13 => new King(suit),
            _ => throw new ArgumentException("Invalid rank")
        };
    }
}