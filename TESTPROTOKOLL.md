# 🧪 Testprotokoll – BMI-Rechner

**Name:** [DEIN NAME]  
**Datum:** [DATUM]  

---

## Testfälle

Führe alle Testfälle aus und notiere die tatsächliche Ausgabe deines Programms.

### TC-01 – Normalgewicht

| | |
|---|---|
| **Eingabe Name** | Max Mustermann |
| **Eingabe Gewicht** | 70 |
| **Eingabe Größe** | 1.75 |
| **Erwartete Kategorie** | Normalgewicht |
| **Tatsächliche Ausgabe** | *(Ergebnis für Max Mustermann BMI: 22,86 Kategorie: Normalgewicht.)* |
| **✅ Bestanden?** | Ja / Nein | Ja

---

### TC-02 – Untergewicht

| | |
|---|---|
| **Eingabe Name** | Lisa Beispiel |
| **Eingabe Gewicht** | 50 |
| **Eingabe Größe** | 1.70 |
| **Erwartete Kategorie** | Untergewicht |
| **Tatsächliche Ausgabe** | *(Ergebnis für Lisa Beispiel BMI: 17,30 Kategorie: Untergewicht.)* |
| **✅ Bestanden?** | Ja / Nein | Ja

---

### TC-03 – Übergewicht

| | |
|---|---|
| **Eingabe Name** | Tom Tester |
| **Eingabe Gewicht** | 95 |
| **Eingabe Größe** | 1.75 |
| **Erwartete Kategorie** | Übergewicht |
| **Tatsächliche Ausgabe** | *(Ergebnis für Tom Tester BMI: 31,02 Kategorie: Starkes Übergewicht.)* |
| **✅ Bestanden?** | Ja / Nein | Nein

---

### TC-04 – Starkes Übergewicht

| | |
|---|---|
| **Eingabe Name** | Anna Admin |
| **Eingabe Gewicht** | 120 |
| **Eingabe Größe** | 1.75 |
| **Erwartete Kategorie** | Starkes Übergewicht |
| **Tatsächliche Ausgabe** | *(Ergebnis für Anna Admin BMI: 39,18 Kategorie: Starkes Übergewicht.)* |
| **✅ Bestanden?** | Ja / Nein | Ja

---

### TC-05 – Fehlerfall: Ungültiges Gewicht

| | |
|---|---|
| **Eingabe Name** | Fehler-Test |
| **Eingabe Gewicht** | `abc` |
| **Eingabe Größe** | (entfällt) |
| **Erwartet** | Fehlermeldung, Programm endet |
| **Tatsächliche Ausgabe** | *(Fehler - Ungültige Eingabe!)* |
| **✅ Bestanden?** | Ja / Nein | Ja

---

### TC-06 – Fehlerfall: Negative Größe

| | |
|---|---|
| **Eingabe Name** | Fehler-Test |
| **Eingabe Gewicht** | 70 |
| **Eingabe Größe** | -1 |
| **Erwartet** | Fehlermeldung (Größe ungültig), Programm endet |
| **Tatsächliche Ausgabe** | *(Fehler - Ungültige Eingabe!)* |
| **✅ Bestanden?** | Ja / Nein | Ja

---

## 💭 Reflexionsfragen (Aufgabe 4)

### Frage 1
> Was passiert, wenn jemand `1,75` statt `1.75` als Größe eingibt? Teste es! Wie könnte man das Problem lösen?

**Beobachtung beim Test:**  
*(Ergebnis für sjs BMI: 0,00 Kategorie: Untergewicht.)*

**Mögliche Lösung:**  
*(hier einfügen)*

---

### Frage 2
> Warum ist die Reihenfolge der `if-else-if`-Bedingungen wichtig? Was würde passieren, wenn du mit `BMI < 30` anfängst?

**Antwort:**  
*(hier einfügen)*

---

### Frage 3
> Der PAP zeigt, dass `groesse > 0` **nach** TryParse geprüft wird. Warum macht diese Reihenfolge Sinn?

**Antwort:**  
*(hier einfügen)*

---

## Zusammenfassung

| Testfall | Bestanden? |
|----------|-----------|
| TC-01 | ⬜ |
| TC-02 | ⬜ |
| TC-03 | ⬜ |
| TC-04 | ⬜ |
| TC-05 | ⬜ |
| TC-06 | ⬜ |

**Bestandene Tests:** ___ / 6
