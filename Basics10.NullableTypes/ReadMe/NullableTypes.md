# Optional: Nullable Types

Nullable Types werden verwendet, wenn eine Variable zusätzlich zu ihren normalen Werten einen undefinierten/unbekannten Wert annehmen kann (null).

- Eine "normale" bool Variable kann nur die Werte true oder false annehmen.
- Eine Variable, die speichert ob es regnen wird, muss aber drei verschiedene Werte annehmen können: true, false und unbekannt (null):<br><br>
```Nullable<bool> wirdEsRegenen = null;```<br>
oder kürzer: <br>```bool? wirdEsRegnen = null;```


