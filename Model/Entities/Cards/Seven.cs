namespace Model.Entities.Cards;

public class Seven(Suit suit) : Card(suit), IPointCard {
    public int GetPoints() => 7;
    public override int GetRank() => 7;
}