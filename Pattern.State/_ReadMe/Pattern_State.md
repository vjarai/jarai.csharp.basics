# State Pattern

### Ein "altmodisches" Telefon soll drei verschiedene Zustände einnehmen können:
- Hörer aufgelegt (getrennt)
- Hörer abgehoben (bereit zum wählen)
- Verbunden (bereit zum sprechen oder auflegen)

### Das Telefon stellt generell folgende Funktionen zur Verfügung:
- AnnehmenAnruf (nur im Zustand aufgelegt)
- Abheben (nur im Zustand aufgelegt)
- Wählen (nur im Zustand abgehoben)
- Sprechen (nur im Zustand verbunden)
- Auflegen (im Zustand verbunden oder abgehoben)

Bei allen Fehlbedienungen soll eine Exception geworfen werden. <br>

Erstellen Sie die Klasse Telefon mit allen fünf Funktionen.<br>
Erstellen Sie ein Klassendiagramm.


Implementieren Sie das zustandsabhängige Verhalten des Telfons ***ohne eine einzige Kontrollstruktur (if, switch, etc.)*** zu verwenden!




