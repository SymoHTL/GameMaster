namespace Model.Entities.BlackJack;

public class BjRound {
    public List<Card> HouseHand { get; } = [];
    public List<Card> PlayerHand { get; } = [];


    public void AddHouseCard(Card card) {
        HouseHand.Add(card);
    }

    public void AddPlayerCard(Card card) {
        PlayerHand.Add(card);
    }

    public bool? HasPlayerWon() {
        var playerSum = CalculatePlayerSum();
        var houseSum = CalculateHouseSum();

        if (playerSum > 21) return false;
        if (houseSum > 21) return true;

        return playerSum > houseSum ? true : playerSum == houseSum ? null : false;
    }
    
    public int CalculateHouseSum() {
        return CalculateSum(HouseHand);
    }

    public int CalculatePlayerSum() {
        return CalculateSum(PlayerHand);
    }

    private int CalculateSum(IReadOnlyCollection<Card> hand) {
        var sum = hand.Sum(card => card switch {
            IPointCard pointCard => pointCard.GetPoints(),
            IMultiPointCard multiPointCard => multiPointCard.GetPoints().Max(),
            _ => 0
        });

        if (sum <= 21) return sum;
        
        foreach (var card in hand.OfType<IMultiPointCard>()) {
            var maxPoint = card.GetPoints().Max();
            var minPoint = card.GetPoints().Min();
            if (maxPoint > minPoint && sum > 21) sum -= maxPoint - minPoint;
        }

        return sum;
    }
}