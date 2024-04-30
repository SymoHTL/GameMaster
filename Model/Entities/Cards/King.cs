namespace Model.Entities.Cards;

public class King(Suit suit) : Card(suit), IPointCard {
    public int GetPoints() => 10;
    public override int GetRank() => 13;

    public override string ToString() {
        return $"King of {Suit.Name}";
    }
}