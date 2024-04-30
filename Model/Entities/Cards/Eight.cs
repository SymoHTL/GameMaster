namespace Model.Entities.Cards;

public class Eight(Suit suit) : Card(suit), IPointCard {
    public int GetPoints() => 8;
    public override int GetRank() => 8;
}