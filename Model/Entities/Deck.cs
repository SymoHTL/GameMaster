using System.Security.Cryptography;
using Model.Factories;

namespace Model.Entities;

public class Deck {
    private readonly List<Card> _cards;

    public List<Card> Cards => [.._cards];

    public Deck() {
        _cards = new List<Card>();
        foreach (var suit in new[] { Suit.Clubs, Suit.Diamonds, Suit.Hearts, Suit.Spades })
            for (var rank = 1; rank <= 13; rank++)
                _cards.Add(CardFactory.FromRank(suit, rank));

        Shuffle();
    }

    public void Shuffle() {
        var n = Cards.Count;
        for (var i = 0; i < n - 1; i++) {
            var j = RandomNumberGenerator.GetInt32(i, n);
            if (i != j) (Cards[i], Cards[j]) = (Cards[j], Cards[i]);
        }
    }

    public Card Draw() {
        var card = _cards[0];
        _cards.RemoveAt(0);
        return card;
    }
}