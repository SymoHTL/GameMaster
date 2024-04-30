namespace Model.Entities.Cards;

public class Six(Suit suit) : Card(suit), IPointCard {
    public int GetPoints() => 6;
    public override int GetRank() => 6;
}