namespace Observer.Models;

public class AuctionItem : IAuctionSubject
{
    private readonly List<IPriceObserver> _observers = new();
    private string _name;
    private decimal _currentPrice;

    public string Name => _name;

    public decimal CurrentPrice
    {
        get => _currentPrice;
        set
        {
            if (_currentPrice != value)
            {
                _currentPrice = value;
                Notify();
            }
        }
    }

    public AuctionItem(string name, decimal startingPrice)
    {
        _name = name;
        _currentPrice = startingPrice;
    }

    public void Attach(IPriceObserver observer)
    {
        if (!_observers.Contains(observer))
        {
            _observers.Add(observer);
            Console.WriteLine($"[SYSTÉM] ({_name}) Pozorovatel '{observer.Name}' byl přidán. Celkem pozorovatelů: {_observers.Count}");
        }
    }

    public void Detach(IPriceObserver observer)
    {
        if (_observers.Remove(observer))
            Console.WriteLine($"[SYSTÉM] Pozorovatel byl odebrán. Celkem pozorovatelů: {_observers.Count}");
    }

    public void Notify()
    {
        Console.WriteLine($"[SYSTÉM] Notifikace {_observers.Count} pozorovatelů...");
        foreach (var observer in _observers)
            observer.Update(_name, _currentPrice);
    }

    public bool Bid(IPriceObserver bidder, decimal bidAmount)
    {
        if (bidAmount <= _currentPrice)
        {
            Console.WriteLine($"[SYSTÉM] Příhoz {bidAmount:C} od {bidder} byl zamítnut. Musí být vyšší než {_currentPrice:C}");
            return false;
        }

        Console.WriteLine($"[SYSTÉM] Příhoz {bidAmount:C} od {bidder} byl přijat!");
        CurrentPrice = bidAmount;
        return true;
    }

    public override string ToString() => $"{_name} - Aktuální cena: {_currentPrice:C}";
}
