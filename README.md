# HERHALINGSOEFENING COLLECTIONS
## LOTTO : het CIJFERSPEL
Start Visual Studio en importeer deze repository (maak dus geen nieuw project aan maar kies voor GitHub import)
De bedoeling is dat je het Lotto Cijferspel aanmaakt (een spel dat door Lotto ondertussen NIET meer aangeboden wordt).
Je kan de regels van het Cijferspel onderaan deze pagina nog terugvinden : https://nl.wikipedia.org/wiki/Lotto 

Je laat je programma eerst jouw 6 cijfers genereren.
Vervolgens laat je het programma de winnende cijfers generen en je gaat gaan kijken hoeveel je er zelf juist hebt.

Je maakt 3 globale variabelen aan die je over je volledige programma kunt gebruiken : 
* Een random generator met de naam rnd
* Een List<int> met de naam MijnNummers
* een List<int> met de naam WinnendeNummers
  
Bij het start van je programma doe je het volgende : 
* Je roept de (nog te maken) methode Initialiseer op 
* je roept de (nog te maken) methode MaakAllesLeeg op
* je roept de (nog te maken) methode MaakAllesWit op

De methode Initialiseer : 
* instantieer de randomgenerator en de 2 Lists (= new ...)
* je vult cmbBallen op met getallen van 40 tot en met 50 en je zorgt dat de waarde 45 geselecteerd staat (het spel werd standaard gespeeld met 45 mogelijke waarden)

De methode MaakAllesLeeg
* je maakt de 12 tekstvakken en de 2 labels leeg

De methode MaakAllesWit
* je stelt de achtergrondkleur van de 12 tekstvakken wit

Wanneer in cmbBallen een andere waarde wordt geselecteerd of er wordt op één van de radiobuttons geklikt dan dienen de methoden MaakAllesLeeg en MaakAllesWit uitgevoerd te worden.

Wanneer op BtnEigenNummers wordt geklikt dan doe je volgende : 
* MaakAllesLeeg en MaakAllesWit oproepen
* maak de 2 Lists leeg
* lees met hoeveel ballen er gewerkt wordt
* genereer 6 getallen en plaats ze één voor één in txtGetal1, txtGetal2 ...   Opgepast : dubbele waarden zijn NIET toegestaan.

Wanneer op BtnWinnendeNummers wordt geklikt dan doe je volgende : 
* maak de List WinnendeNummers leeg
* lees met hoeveel ballen er gewerkt wordt
* genereer 6 winnende getallen en plaats ze één voor één in txtWinGetal1, txtGWinetal2 ...   Opgepast : dubbele waarden zijn NIET toegestaan.
* roep de (nog te maken) methode WinstBerekening op

De methode WinstBereking moet gaan nakijken hoeveel van je eigen nummers overeenkomen met de winnende nummers.
* 6 zelfde cijfers : € 200.000 
* 5 zelfde cijfers : € 5.000 
* 4 zelfde cijfers : € 450 
* 3 zelfde cijfers : € 50 
* 2 zelfde cijfers : € 5 
* 1 zelfde cijfer : € 1 

Opgepast : we hebben nog rdbJa en rdbNeen.  Indien rdbJa geselecteerd werd, dan moeten de cijfers niet alleen overeenkomen, dan moeten ze ook op dezelfde plaats (rangorde) staan.  Indien rdbNeen geselecteerd staat, dan maakt het niet uit in welke rangorde de cijfers staan (= uiteraard veel grotere kans op winst).

Toon het winstresultaat in de labels onderaan het venster.  Kleur ook de overeenkomende cijfers (bv achtergrond van betrokken tekstvakken leeg)

