namespace Model.Entities.Cards;

public class Ace(Suit suit) : Card(suit), IMultiPointCard {
    public override int GetRank() => 1;
    
    public int[] GetPoints() {
        return [1, 11];
    }

    public override string ToString() {
        return $"Ace of {Suit.Name}";
    }
}