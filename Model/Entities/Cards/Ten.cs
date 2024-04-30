namespace Model.Entities.Cards;

public class Ten(Suit suit) : Card(suit), IPointCard {
    public int GetPoints() => 10;
    public override int GetRank() => 10;
}