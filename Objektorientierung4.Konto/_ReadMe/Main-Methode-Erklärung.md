# Die `Main`-Methode im Bankkonto-Programm

## Schritt-für-Schritt Erklärung

### 1. **Objekterstellung**



- Es werden **zwei Konto-Objekte** erstellt
- `meinKonto` gehört "Fritz"
- `deinKonto` gehört "Susi"
- Beide Konten starten mit einem Kontostand von 0€

---

### 2. **Einzahlung auf meinKonto**


- Auf das Konto von Fritz werden **100€ eingezahlt**
- Kontostand Fritz: **100€**

---

### 3. **Abhebung von meinKonto**


- Von Fritz' Konto werden **20€ abgehoben**
- Die Zahl `4711` ist die **PIN** oder ein **Sicherheitscode**
- Kontostand Fritz: **80€**

---

### 4. **Anzeige des Kontostands**

- Der aktuelle Kontostand von Fritz wird **auf der Konsole ausgegeben**
- Erwartete Ausgabe: Name "Fritz" und Kontostand 80€

---

### 5. **Überweisung zwischen Konten**

- Von Fritz' Konto werden **10€ an Susi überwiesen**
- Wieder wird die PIN `4711` zur Autorisierung verwendet
- `deinKonto` (Susi) ist der **Empfänger**
- Kontostand Fritz: **70€**
- Kontostand Susi: **10€**

---

### 6. **Anzeige des Empfänger-Kontos**

- Der Kontostand von Susi wird **ausgegeben**
- Erwartete Ausgabe: Name "Susi" und Kontostand 10€

---

## Zusammenfassung der Kontostände

| Zeitpunkt | Fritz (meinKonto) | Susi (deinKonto) |
|-----------|-------------------|------------------|
| Nach Erstellung | 0€ | 0€ |
| Nach Einzahlung | 100€ | 0€ |
| Nach Abhebung | 80€ | 0€ |
| Nach Überweisung | 70€ | 10€ |

---

## Wichtige Konzepte

### **Objektorientierung**
- Die `Main`-Methode **verwendet Objekte** (`meinKonto`, `deinKonto`)
- Objekte haben **Eigenschaften** (Kontostand, Name) und **Methoden** (Einzahlen, Abheben, etc.)

### **Methodenaufrufe**
- Methoden werden mit dem **Punkt-Operator** aufgerufen: `objekt.Methode()`
- Beispiel: `meinKonto.Einzahlen(100)`

### **Parameter**
- Methoden können **Werte entgegennehmen**: 
  - `Einzahlen(100)` → Betrag
  - `Abheben(20, 4711)` → Betrag + PIN
  - `Überweisen(deinKonto, 4711, 10)` → Zielkonto + PIN + Betrag

### **Referenzen zwischen Objekten**
- Bei der Überweisung wird `deinKonto` als **Referenz** übergeben
- So können Objekte **miteinander interagieren**

---

## Zweck des Programms

Das Programm demonstriert:
- ✅ Erstellung und Verwendung von Objekten
- ✅ Methodenaufrufe mit Parametern
- ✅ Interaktion zwischen verschiedenen Objekten
- ✅ Kapselung von Geschäftslogik in einer Klasse (`Konto`)
- ✅ Sicherheitsmechanismen (PIN-Überprüfung)
