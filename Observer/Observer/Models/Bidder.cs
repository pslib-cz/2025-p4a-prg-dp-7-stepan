using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Models;

public class Bidder : IPriceObserver
{
    private readonly string _name;

    public string Name => _name;

    public Bidder(string name)
    {
        _name = name;
    }

    public void Update(string itemName, decimal newPrice)
    {
        Console.WriteLine($"[{_name}] Byla aktualizována cena předmětu '{itemName}' na {newPrice:C}");
    }

    public override string ToString() => _name;
}
