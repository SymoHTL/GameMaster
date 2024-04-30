namespace Model.Entities.Cards;

public class Two(Suit suit) : Card(suit), IPointCard {
    public override int GetRank() => 2;
    public int GetPoints() => 2;
}