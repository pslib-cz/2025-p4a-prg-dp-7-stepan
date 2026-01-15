using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Models;

public interface IAuctionSubject
{
    void Attach(IPriceObserver observer);
    void Detach(IPriceObserver observer);
    void Notify();
}
