

---

Blackjack Game in C#

 Overzicht

Dit is een eenvoudige implementatie van het klassieke kaartspel **Blackjack** in C#. Het spel wordt gespeeld tussen de speler en de dealer, waarbij het doel is om een hand te krijgen die dichter bij 21 punten komt dan de dealer, zonder over 21 heen te gaan. Het spel maakt gebruik van een standaard deck van 52 kaarten.

 Functies

- Speler speelt tegen de dealer.
- Het spel toont de hand van de speler en de dealer.
- De speler kan kiezen om een extra kaart te trekken ("Hit") of te stoppen ("Stand").
- De dealer volgt een automatische strategie om kaarten te trekken (altijd trekken tot 17).
- Het spel houdt de score bij en toont of de speler of de dealer heeft gewonnen.

 Installatie

Om het Blackjack spel te kunnen spelen, heb je het volgende nodig:

- .NET 6.0 of hoger
- Een C# IDE (zoals Visual Studio of Visual Studio Code)

 Stappen om het spel te installeren:

1. Clone dit project naar je lokale machine:
   ```bash
   git clone https://github.com/jouw-gebruikersnaam/blackjack-game-csharp.git
   ```

2. Navigeer naar de map waar het project zich bevindt:
   ```bash
   cd blackjack-game-csharp
   ```

3. Open het project in Visual Studio of gebruik de terminal om het project te bouwen:
   ```bash
   dotnet build
   ```

4. Start het spel:
   ```bash
   dotnet run
   ```

 Spelregels

1. De speler begint met twee kaarten, en de dealer krijgt ook twee kaarten. De speler ziet één van de kaarten van de dealer (de andere blijft verborgen).
2. De speler heeft de keuze om:
   - **Hit**: Een extra kaart trekken.
   - **Stand**: Stoppen met het trekken van kaarten en wachten op de dealer.
3. De dealer moet kaarten blijven trekken totdat deze minimaal 17 punten heeft.
4. Het doel is om een hand te hebben met een totaal van 21 punten of zo dicht mogelijk daarbij, zonder er overheen te gaan.
5. De puntentelling van de kaarten is als volgt:
   - Kaarten 2 t/m 10 hebben de waarde die op de kaart staat.
   - Boeren, vrouwen en koningen (J, Q, K) zijn elk 10 punten waard.
   - Azen kunnen 1 of 11 punten waard zijn, afhankelijk van wat gunstiger is voor de speler.
6. Als de speler boven de 21 punten komt, verliest hij onmiddellijk.
7. Als de dealer boven de 21 punten komt, wint de speler automatisch.
8. Als de speler en de dealer gelijk eindigen, is er sprake van een gelijkspel (Push).

 Code Uitleg

- **Deck.cs**: Bevat de logica voor het deck van kaarten. Hierin wordt het deck gemaakt, geschud en worden de kaarten gedeeld.
- **Card.cs**: Bevat de definitie van een kaart, inclusief de waarde en het type (Harten, Schoppen, Ruiten, Klaveren).
- **Game.cs**: Bevat de spelregels en logica van het spel zelf, zoals het afhandelen van de keuzes van de speler (Hit of Stand) en het berekenen van de winnaar.
- **Program.cs**: Het startpunt van het spel. Dit bestand bevat de code die het spel aanstuurt en zorgt voor de interactie met de gebruiker via de console.

 Gebruik

Na het starten van het spel via de console ziet de speler de kaarten van zowel zichzelf als de dealer. Het spel vraagt om keuzes via de console.

Beschikbare commando's:
- Typ **h** voor "Hit" (een extra kaart trekken).
- Typ **s** voor "Stand" (stoppen met kaarten trekken).
- Het spel toont de uitkomst zodra de ronde is afgelopen, inclusief de score van de speler en de dealer.

 Voorbeeld van het Spelverloop

```
Welkom bij Blackjack!

Je hebt de kaarten: [7 van Harten, 10 van Klaveren] (Totaal: 17)
De dealer heeft de kaarten: [8 van Ruiten, ?]

Wil je 'h' voor Hit of 's' voor Stand? s

De dealer heeft de kaarten: [8 van Ruiten, 9 van Schoppen] (Totaal: 17)
De dealer stopt.

Jij hebt 17 punten en de dealer heeft 17 punten. Het is gelijkspel (Push).
```

 Contributie

Voel je vrij om bij te dragen aan dit project! Als je een bug ontdekt of een nieuwe functie wilt toevoegen, stuur dan een pull request. Zorg ervoor dat je je code goed test voordat je deze toevoegt.

### Openstaande issues

- Toevoegen van meerdere spelers.
- Toevoegen van een grafische gebruikersinterface (GUI).
- Verbeteren van de dealerlogica voor geavanceerdere strategieën.

Licentie

Dit project is gelicenseerd onder de MIT-licentie - zie het [LICENSE](LICENSE) bestand voor details.

---

Dit is een eenvoudig voorbeeld van hoe je een README-pagina voor een Blackjack-spel kunt structureren in C#. Pas het gerust aan afhankelijk van je specifieke implementatie en behoeften!
