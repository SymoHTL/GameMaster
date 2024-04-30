namespace Model.Entities.Cards;

public class Three(Suit suit) : Card(suit), IPointCard {
    public override int GetRank() => 3;

    public int GetPoints() => 3;
}