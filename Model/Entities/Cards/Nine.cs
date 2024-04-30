namespace Model.Entities.Cards;

public class Nine(Suit suit) : Card(suit), IPointCard {
    public int GetPoints() => 9;
    public override int GetRank() => 9;
}