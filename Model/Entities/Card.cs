namespace Model.Entities;

public abstract class Card(Suit suit) {
    public readonly Suit Suit = suit;
    public abstract int GetRank();
    
    public string GetImgUrl() => $"images/{Suit.Name.ToLower()}/{GetRank()}.png";
    
    public bool Equals(Card other) {
        return GetRank() == other.GetRank() && Suit.Equals(other.Suit);
    }

    public override bool Equals(object? obj) {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == GetType() && Equals((Card)obj);
    }

    public override int GetHashCode() {
        return HashCode.Combine(GetRank(), Suit);
    }

    public override string ToString() {
        return $"{GetRank()} of {Suit.Name}";
    }
}