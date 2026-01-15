**Observer**

- Použili jsme observer, protože jednosměrná komunikace mezi draženým předmětem a dražiteli je téměř definicí tohoto vzoru.

- Snadné přidání nových typů pozorovatelů - implementace `IPriceObserver`, přes které probíhá komunikace
- Jeden item může notifikovat libovolný počet pozorovatelů
- Při změně ceny se automaticky spustí notifikace všech pozorovatelů (je to v setteru)
- Pozorovatele lze přidávat/odebírat za běhu pomocí `Attach()` a `Detach()`
