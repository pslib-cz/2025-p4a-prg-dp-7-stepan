**Observer**

- Použili jsme observer, protože jednosmìrná komunikace mezi draženým pøedmìtem a dražiteli je témìø definicí tohoto vzoru.

- Snadné pøidání nových typù pozorovatelù - implementace `IPriceObserver`, pøes které probíhá komunikace
- Jeden item mùže notifikovat libovolný poèet pozorovatelù
- Pøi zmìnì ceny se automaticky spustí notifikace všech pozorovatelù (je to v setteru)
- Pozorovatele lze pøidávat/odebírat za bìhu pomocí `Attach()` a `Detach()`