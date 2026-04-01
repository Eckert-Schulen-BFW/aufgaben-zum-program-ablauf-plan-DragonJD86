// ============================================================
//  Aufgabe: Programmablaufplan – BMI-Rechner
//  Fach:    C# Grundlagen
//  Name:    [DEIN NAME HIER]
//  Datum:   [DATUM HIER]
// ============================================================
//
// AUFGABE 1 – Beantworte folgende Fragen hier als Kommentar:
//
// Frage 1: Wie viele Entscheidungsknoten (Rauten) hat der PAP?
// Antwort: 6
//
// Frage 2: Unter welchen Bedingungen endet das Programm frühzeitig?
// Antwort: Wenn der erste "TryParse" nicht erfolgreich war.
//
// Frage 3: Warum wird TryParse statt Convert.ToDouble() verwendet?
// Antwort: Weil wir einen "bool" brauchen, damit wir die Werte vergleichen können.
//          Und weil nach falscher Eingabe das Programm nicht abstürzt, mit "TryParse".
//
// Frage 4: Welchen Datentyp sollen gewicht und groesse haben, und warum?
// Antwort: Sie sollten ein "double" sein, da, eventuell, Gleitkommazahlen eingegeben werden.
//
// ============================================================

// TODO: Schreibe dein Programm unterhalb dieser Zeile.
//       Orientiere dich dabei am PAP in der README.md.
//       Jeder Schritt im PAP sollte einer Zeile / einem Block in deinem Code entsprechen.

// ── Schritt 1: Programmtitel ausgeben ───────────────────────
// Tipp: Nutze Console.WriteLine() für die Titelbox.
// TODO: Ausgabe der Titelzeile (wie im Beispiel in der README)

Console.WriteLine("╔══════════════════════════════════╗");
Console.WriteLine("║        BMI-Rechner v1.0          ║");
Console.WriteLine("╚══════════════════════════════════╝");

// ── Schritt 2: Eingabe – Name ────────────────────────────────
// TODO: Benutzernamen einlesen (string, kein TryParse nötig)

Console.Write("Bitte geben Sie Ihren Namen ein: ");
string name = Console.ReadLine().Trim(); //.Trim wegen Leerzeichen entfernen.

// ── Schritt 3: Eingabe – Gewicht mit Validierung ─────────────
// TODO: Gewicht als Text einlesen
// TODO: Mit double.TryParse() in eine Zahl umwandeln
// TODO: Falls ungültig → Fehlermeldung ausgeben und Programm beenden (return)

Console.Write("Bitte geben Sie Ihr Gewicht in kg an: ");
double gewicht = -1;//-1, damit die Eingabe in einen Bool umgewandelt werden kann.
bool gewicht1 = double.TryParse(Console.ReadLine().Trim(), out gewicht);// Versuchen die Eingabe in einen Bool umzuwandeln.
if (gewicht1 == true && gewicht >= 0) // "true && >=0" damit die Eingabe nicht 0 oder kleiner als 0 sein kann.
{
    Console.WriteLine("Ihr Gewicht beträgt: " + gewicht);
}
else 
{
    Console.WriteLine("Fehler - Ungültige Eingabe!"); //wenn Eingabe kleiner gleich 0, dann Fehlerausgabe.
    return;
}

// ── Schritt 4: Eingabe – Größe mit Validierung ───────────────
// TODO: Körpergröße als Text einlesen
// TODO: Mit double.TryParse() in eine Zahl umwandeln
// TODO: Falls ungültig → Fehlermeldung ausgeben und Programm beenden (return)
// TODO: Zusätzlich prüfen: Ist die Größe größer als 0?
//       Falls nicht → eigene Fehlermeldung und Programm beenden (return)

Console.Write("Bitte geben Sie Ihre Körpergröße in Meter an: ");
double größe = -1;
bool größe1 = double.TryParse(Console.ReadLine().Trim(), out größe);
if (größe1 == true && größe >= 0)
{
    Console.WriteLine("Ihre Größe beträgt: " + größe);
}
else
{
    Console.WriteLine("Fehler - Ungültige Eingabe!");
    return;
}

// ── Schritt 5: BMI berechnen ─────────────────────────────────
// Formel: BMI = Gewicht / (Größe * Größe)
// TODO: BMI berechnen und in einer Variablen speichern

double bmi = gewicht / (größe * größe);//double, weil wir auch Größe und Gewicht als double haben und BMI als Gleitkommazahl ausgegeben wird.

// ── Schritt 6: Kategorie bestimmen ───────────────────────────
// TODO: Erstelle eine string-Variable "kategorie"
// TODO: Bestimme die Kategorie über eine if-else-if-Kette:
//       BMI < 18.5        → "Untergewicht"
//       BMI < 25.0        → "Normalgewicht"
//       BMI < 30.0        → "Übergewicht"
//       sonst (else)      → "Starkes Übergewicht"
//
// 💭 Denkfrage: Warum reicht bei "Normalgewicht" die Bedingung BMI < 25.0 aus,
//               obwohl laut WHO-Tabelle auch BMI >= 18.5 gelten muss?
string kategorie; //Keinen Wert deklariert, weil durch if-else-if abfrage Kategorie bestimmt wird.

if (bmi < 18.5) 
{
    kategorie = "Untergewicht.";
}
else if (bmi < 25.0)
{
    kategorie = "Normalgewicht.";
}
else if (bmi < 30.0)
{
    kategorie = "Übergewicht.";
}
else
{
    kategorie = "Starkes Übergewicht.";
}

// ── Schritt 7: Ergebnis ausgeben ─────────────────────────────
// TODO: Gib Name, BMI (auf 2 Dezimalstellen) und Kategorie formatiert aus
// Tipp: Nutze z.B. $"{bmi:F2}" für 2 Nachkommastellen
Console.WriteLine("──────────────────────────────────\r\n Ergebnis für " + name);
Console.WriteLine("──────────────────────────────────\r\nBMI: " + $"{bmi:F2}" + "\r\nKategorie: " + kategorie + "\r\n──────────────────────────────────");
