using Observer.Models;

Console.WriteLine("=== AUKČNÍ SYSTÉM - OBSERVER PATTERN ===\n");

AuctionItem[] auctionItems = [new AuctionItem("Radek_item", 1000m), new AuctionItem("Tonda_item", 1000m), new AuctionItem("Kubík_item", 1)];

foreach (var item in auctionItems)
    Console.WriteLine(item);

Console.WriteLine();

var bidder1 = new Bidder("Zase Tonda");
var bidder2 = new Bidder("Ahoj Tondo");

Console.WriteLine("--- Přihlášení pozorovatelů ---");
auctionItems[0].Attach(bidder1);
auctionItems[0].Attach(bidder2);
auctionItems[1].Attach(bidder2);
auctionItems[2].Attach(bidder2);
Console.WriteLine();

Console.WriteLine("--- Příhozy  ---");
auctionItems[0].Bid(bidder1, 1500m);
Console.WriteLine();

Console.WriteLine("--- Pokus o změnu ceny ---");
auctionItems[0].Bid(bidder2, 1400m);
Console.WriteLine();

Console.WriteLine("--- Změna ceny ---");
auctionItems[0].Bid(bidder2, 2000m);
Console.WriteLine();

Console.WriteLine("--- Odhlášení  ---");
auctionItems[0].Detach(bidder1);
Console.WriteLine();

Console.WriteLine("--- Změna ceny ---");
auctionItems[0].Bid(bidder2, 25000m);
Console.WriteLine();

Console.WriteLine("=== KONEC DEMONSTRACE ===");