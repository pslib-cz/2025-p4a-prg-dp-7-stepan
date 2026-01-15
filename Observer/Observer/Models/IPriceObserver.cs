namespace Observer.Models;

public interface IPriceObserver
{
    string Name { get; }

    void Update(string itemName, decimal newPrice);
}
