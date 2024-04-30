namespace Model.Entities.Cards;

public class Jack(Suit suit) : Card(suit), IPointCard {
    public int GetPoints() => 10;
    public override int GetRank() => 11;

    public override string ToString() {
        return $"Jack of {Suit.Name}";
    }
}