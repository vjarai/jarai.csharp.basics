# Klassen und Beziehungen, Teil 2: Vererbung

- Erstellen Sie ein Klassendiagramm (Hinzufügen => Neues Element => Klassendiagramm)
- Erstellen Sie die abstracte Klasse Möbel mit den abstrakten Methoden void Montieren() und void Benutzen().
- Erstellen Sie die Klassen Stuhl und Tisch. Ein Stuhl und ein Tisch "IST EIN" Möbel (Vererbung).
- Überschreiben Sie in den abgeleiteten Klassen die Methoden Montieren() und Benutzen().

- Erstellen Sie in der Klasse Ikea die Methode Verkaufen(), die als Ergebnis ein neues Möbel liefert.
- Erstellen Sie ein kleines Rahmenprogramm zum Testen der Anwendung, z.B.:

```
    var ikeaFrankfurt = new Ikea("Frankfurt");           
    var meinMöbel = ikeaFrankfurt.Verkaufen();
    meinMöbel.Montieren();
    meinMöbel.Benutzen();
```
- Wie können Sie zur Laufzeit sicherstellen, dass jedes Möbel vor dem Benutzen() montiert wird ("Fail early an loud!")?

### Fazit:
- Wann verwenden Sie Vererbung? 
- Woran erkennt man die Vererbung?
- Welche Methode ist die Fabrikmethode?


