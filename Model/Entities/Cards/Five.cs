namespace Model.Entities.Cards;

public class Five(Suit suit) : Card(suit), IPointCard {
    public int GetPoints() => 5;
    public override int GetRank() => 5;
}