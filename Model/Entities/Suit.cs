namespace Model.Entities;

public class Suit {
    public static readonly Suit Clubs = new("Clubs");
    public static readonly Suit Diamonds = new("Diamonds");
    public static readonly Suit Hearts = new("Hearts");
    public static readonly Suit Spades = new("Spades");

    public readonly string Name;

    private Suit(string name) {
        Name = name;
    }

    public bool Equals(Suit other) {
        return Name == other.Name;
    }

    public override bool Equals(object? obj) {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == GetType() && Equals((Suit)obj);
    }

    public override int GetHashCode() {
        return Name.GetHashCode();
    }
    
    public override string ToString() {
        return Name;
    }
}