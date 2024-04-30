namespace Model.Entities.Cards;

public class Four(Suit suit) : Card(suit), IPointCard {
    public int GetPoints() => 4;
    public override int GetRank() => 4;
}