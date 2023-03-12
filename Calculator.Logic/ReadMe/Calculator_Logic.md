# CalculationService mit Unit Tests

- Erstellen Sie eine Klasse CalculationService mit folgenden Methoden <br>
```
double Add(double x, double y)
double Subtract(double x, double y)
double Multiply(double x, double y)
double Divide(double x, double y)
```
- Implementieren Sie die Methoden.
- Bei Division durch 0 wird eine InvalidOperationException mit der Meldung "Division durch 0 ist nicht möglich." ausgelöst.

- Lassen Sie sich über das Contextmenü im Visual Studio Code Editor je einen Componenten Tests für jede Methoden erstellen.
- Implementieren Sie die Tests nach dem AAA Prinzip (Arrange, Act, Assert).
- Prüfen Sie in dem Tests das jeweilige Ergebnis mit Assert.Equal(expected, actual)
