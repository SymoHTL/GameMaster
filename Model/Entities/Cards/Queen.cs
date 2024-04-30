namespace Model.Entities.Cards;

public class Queen(Suit suit) : Card(suit), IPointCard {
    public int GetPoints() => 10;
    public override int GetRank() => 12;

    public override string ToString() {
        return $"Queen of {Suit.Name}";
    }
}