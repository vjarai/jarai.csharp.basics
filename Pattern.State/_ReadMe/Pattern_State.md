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
- Auflegen (nur im Zustand verbunden)

Bei allen Fehlbedienungen soll eine Fehlermeldung erscheinen, <br>
z.B. "Wählen nur im abgehobenen Zustand möglich".

Erstellen Sie die Klasse Telefon mit allen fünf Funktionen.<br>
Erstellen Sie ein Klassendiagramm.
Schreiben Sie eine 

Implementieren Sie das zustandsabhängige Verhalten des Telfons ***ohne eine einzige Kontrollstruktur (if, switch, etc.)*** zu verwenden!




