//Ich habe mit das Gerüst des Programms angefangen.
using System.ComponentModel.Design;

Console.WriteLine("==========================");
Console.WriteLine("Wilkommen zum Mega Quiz!");
Console.WriteLine("==========================");
Console.WriteLine();
Console.WriteLine("Teste dein Wissen.");
Console.WriteLine("Beanworte Fragen und sammle viele Punkte!");
Console.WriteLine();
Console.WriteLine("Wir haben verschiedene Themen:");
Console.WriteLine("1. Informatik");
Console.WriteLine("2. Fussball");
Console.WriteLine("3. Geografie");
Console.WriteLine("4. Chemie");
Console.WriteLine("5. Mathematik");


//Variable Für die Anzahl Punkte
int points = 0;

//Auswahl der Themen
//Wir wollen die theme Variable auch ausserhalb des Codes benutzen.
string theme = "";

//Wenn eine ungültige eingabe eingegeben wird,soll die Frage erneut gefragt werden
bool valid = false;

while (valid == false)
{
    Console.WriteLine("Wähle etwas aus! (1-4)");
    theme = Console.ReadLine();
    //Damit die Auswahl der Themen nicht nur die Nummer sagt sondern der Name, erstelle ich dafür eine If-Schleife.
    if (theme == "1")
    {
        valid = true;
        Console.WriteLine($"Du hast dich für Informatik entschieden. Na dann hoffe ich das du deine Module gut bearbeitest hast. Viel Erfolg!");
    }
    else if (theme == "2")
    {
        valid = true;
        Console.WriteLine($"Du hast dich für Fusball entschieden. Na dann bist du ja Sportlich unterwegs. Viel erfolg!");
    }
    else if (theme == "3")
    {
        valid = true;
        Console.WriteLine($"Du hast dich für Geografie entschieden. Ich hoffe du weisst viel über unsere Welt. Viel erfolg!");
    }
    else if (theme == "4")
    {
        valid = true;
        Console.WriteLine($"Du hast dich für Chemie entschieden. Ich finde dieses Thema sehr kompliziert. Viel erfolg!");
    }
    else if (theme == "5")
    {
        valid = true;
        Console.WriteLine("Du hast dich für Mathematik entschieden. Viel Spass beim Rechnen!");
    }
    else
    {
        Console.WriteLine("Ungültige eingabe. Versuche es bitte neu.");
    }
}

//Erste Quizfrage Programmieren
Console.WriteLine();

// durch diese If schleife, kann man die frage am gewählten Thema anpassen.
    if (theme == "1")
    {
        Console.WriteLine("Frage 1: Was bedeutet C#?");
        Console.WriteLine("1. Eine Programmiersprache");
        Console.WriteLine("2. Ein Computerspiel");
        Console.WriteLine("3. Ein Betriebssystem");
        Console.WriteLine("4. Ein Film ");
    }
    else if (theme == "2")
    {
        Console.WriteLine("Frage 1: Wer hat im Jahr 2022 die Weltmeisterschaft in Fussball gewonnen?");
        Console.WriteLine("1. Argentinien");
        Console.WriteLine("2. Spanien");
        Console.WriteLine("3. Frankreich");
        Console.WriteLine("4. Brazilien");
    }
    else if (theme == "3")
    {
        Console.WriteLine("Frage 1: Was ist die Hauptstadt der Schweiz");
        Console.WriteLine("1. Zürich");
        Console.WriteLine("2. Bern");
        Console.WriteLine("3. Genf");
        Console.WriteLine("4. Aargau");
    }
    else if (theme == "4")
    {
        Console.WriteLine("Frage 1: Wie lautet das chemische Symbol für Wasserstoff?");
        Console.WriteLine("1. C");
        Console.WriteLine("2. H");
        Console.WriteLine("3. O");
        Console.WriteLine("4. W");
    }
else if (theme == "5")
{
    Console.WriteLine("Frage 1: Was ist: 45 + 28 * 2");
    Console.WriteLine("1. 101");
    Console.WriteLine("2. 100");
    Console.WriteLine("3. 146");
    Console.WriteLine("4. 118");
}

    //Wir brauchen eine Bool Variable zum Prüfen ob die antwort valide ist. Und auch eine Variable für alle antworten.
    string answer = "";
bool validAnswer1 = false;
while (validAnswer1 == false)
{
    //If - else schleife zum prüfen ob es korrekt ist. Zusammen mit eine While schleife damit es bei ungültige eingaben nochmals kommt.
    Console.WriteLine("Antworte von 1-4!");
    answer = Console.ReadLine();
    if (answer == "1" && theme == "1")
    {
        Console.WriteLine("Korrekt! Yuhuu!");
        points++;
        validAnswer1 = true;
    }
    else if (answer == "1" && theme == "2")
    {
        Console.WriteLine("Korrekt! Yuhuu!");
        points++;
        validAnswer1 = true;
    }
    else if (answer == "2" && theme == "3")
    {
        Console.WriteLine("Korrekt! Yuhuu!");
        points++;
        validAnswer1 = true;
    }
    else if (answer == "4" && theme == "4")
    {
        Console.WriteLine("Korrekt! Yuhuu!");
        points++;
        validAnswer1 = true;
    }
    else if (answer == "1" && theme == "5")
    {
        Console.WriteLine("Korrekt! Yuhuu!");
        points++;
        validAnswer1 = true;
    }
    else if (answer == "1" || answer == "2" || answer == "3" || answer == "4")
    {
        Console.WriteLine("Leider falsch! Versuche es beim nächsten Mal.");
        validAnswer1 = true;
    }
    else
    {
        Console.WriteLine("Ungültige Antwort, versuche es nochmals.");
    }
}

//Frage Nummer 2
Console.WriteLine();
 if (theme == "1")
{
    Console.WriteLine("Frage Nummer 2: Was bedeutet die Abkürzung CPU?");
    Console.WriteLine("1. Central Processing Unit.");
    Console.WriteLine("2. Computer personal Unit");
    Console.WriteLine("3. Centrall Program User");
    Console.WriteLine("4. Central Processing User");
}
else if (theme == "2")
{
    Console.WriteLine("Frage Nummer 2: Wie viele Spieler hat eine Fussballmannschaft normalerweise auf dem Platz?");
    Console.WriteLine("1. 9");
    Console.WriteLine("2. 10");
    Console.WriteLine("3. 12");
    Console.WriteLine("4. 11");
}
else if (theme == "3")
{
    Console.WriteLine("Frage Nummer 2: Welcher ist der grösste Kontinent?");
    Console.WriteLine("1. Afrika");
    Console.WriteLine("2. Europa");
    Console.WriteLine("3. Asien");
    Console.WriteLine("4. Amerika");
}
 else if (theme == "4")
{
    Console.WriteLine("Frage Nummer 2: Wie lautet die chemische Formel für Wasser?");
    Console.WriteLine("1. C₂O");
    Console.WriteLine("2. CO₂");
    Console.WriteLine("3. O₂");
    Console.WriteLine("4. H₂O");
}
else if (theme == "5")
{
    Console.WriteLine("Frage Nummer 2: Wie viel sind 20% von 150CHF?");
    Console.WriteLine("1. 3 CHF");
    Console.WriteLine("2. 30 CHF");
    Console.WriteLine("3. 15 CHF");
    Console.WriteLine("4. 50 CHF");
}

    //Antwort von Frage Nummer 2 prüfen
    bool validAnswer2 = false;
while (validAnswer2 == false)
{
    //If - else schleife zum prüfen ob es korrekt ist. Zusammen mit eine While schleife damit es bei ungültige eingaben nochmals kommt.
    Console.WriteLine("Antworte von 1-4!");
    answer = Console.ReadLine();
    if (answer == "1" && theme == "1")
    {
        Console.WriteLine("Korrekt! Yuhuu!");
        points++;
        validAnswer2 = true;
    }
    else if (answer == "4" && theme == "2")
    {
        Console.WriteLine("Korrekt! Yuhuu!");
        points++;
        validAnswer2 = true;
    }
    else if (answer == "3" && theme == "3")
    {
        Console.WriteLine("Korrekt! Yuhuu!");
        points++;
        validAnswer2 = true;
    }
    else if (answer == "4" && theme == "4")
    {
        Console.WriteLine("Korrekt! Yuhuu!");
        points++;
        validAnswer2 = true;
    }
    else if (answer == "2" && theme == "5")
    {
        Console.WriteLine("Korrekt! Yuhuu!");
        points++;
        validAnswer2 = true;
    }
    else if (answer == "1" || answer == "2" || answer == "3" || answer == "4")
    {
        Console.WriteLine("Leider falsch! Versuche es beim nächsten Mal.");
        validAnswer2 = true;
    }
    else
    {
        Console.WriteLine("Ungültige Antwort, versuche es nochmals.");
    }
}

// Frage Nummer 3
Console.WriteLine();
if (theme == "1")
{
    Console.WriteLine("Frage Nummer 3: Was ist eine Variable?");
    Console.WriteLine("1. Ein Speicherplatz für Daten");
    Console.WriteLine("2. Ein Computerbildschirm");
    Console.WriteLine("3. Ein Internetbrowser");
    Console.WriteLine("4. Eine Schleife");
}
else if (theme == "2")
{
    Console.WriteLine("Frage Nummer 3: Wie lange dauert ein normales Fussballspiel ohne Nachspielzeit?");
    Console.WriteLine("1. 80 Minuten");
    Console.WriteLine("2. 90 Minuten");
    Console.WriteLine("3. 100 Minuten");
    Console.WriteLine("4. 45 Minuten");
}
else if (theme == "3")
{
    Console.WriteLine("Frage Nummer 3: Welcher ist der längste Fluss der Welt?");
    Console.WriteLine("1. Nil");
    Console.WriteLine("2. Rhein");
    Console.WriteLine("3. Themse");
    Console.WriteLine("4. Reus");
}
else if (theme == "4")
{
    Console.WriteLine("Frage Nummer 3: Wie viele Protonen hat ein Wasserstoffatom?");
    Console.WriteLine("1. 1");
    Console.WriteLine("2. 2");
    Console.WriteLine("3. 3");
    Console.WriteLine("4. keine");
}
else if (theme == "5")
{
    Console.WriteLine("Frage Nummer 3: Rechne: 1/3 + 1/4");
    Console.WriteLine("1. 0.7");
    Console.WriteLine("2. 3/4");
    Console.WriteLine("3. 2/7");
    Console.WriteLine("4. 2/3");
}


    //Antwort von Frage Nummer 3 prüfen
    bool validAnswer3 = false;
while (validAnswer3 == false)
{
    //If - else schleife zum prüfen ob es korrekt ist. Zusammen mit eine While schleife damit es bei ungültige eingaben nochmals kommt.
    Console.WriteLine("Antworte von 1-4!");
    answer = Console.ReadLine();
    if (answer == "1" && theme == "1")
    {
        Console.WriteLine("Korrekt! Yuhuu!");
        points++;
        validAnswer3 = true;
    }
    else if (answer == "2" && theme == "2")
    {
        Console.WriteLine("Korrekt! Yuhuu!");
        points++;
        validAnswer3 = true;
    }
    else if (answer == "1" && theme == "3")
    {
        Console.WriteLine("Korrekt! Yuhuu!");
        points++;
        validAnswer3 = true;
    }
    else if (answer == "1" && theme == "4")
    {
        Console.WriteLine("Korrekt! Yuhuu!");
        points++;
        validAnswer3 = true;
    }
    else if (answer == "2" && theme == "5")
    {
        Console.WriteLine("Korrekt! Yuhuu!");
        points++;
        validAnswer3 = true;
    }
    else if (answer == "1" || answer == "2" || answer == "3" || answer == "4")
    {
        Console.WriteLine("Leider falsch! Versuche es beim nächsten Mal.");
        validAnswer3 = true;
    }
    else
    {
        Console.WriteLine("Ungültige Antwort, versuche es nochmals.");
    }
}

// Frage Nummer 4
Console.WriteLine();
if (theme == "1")
{
    Console.WriteLine("Frage Nummer 4: Was bedeutet HTML?");
    Console.WriteLine("1. Hyper Tool Metal Language");
    Console.WriteLine("2. High Technology Machine Language");
    Console.WriteLine("3. Home Tool Management Language");
    Console.WriteLine("4. HyperText Markup Language");
}
else if (theme == "2")
{
    Console.WriteLine("Frage Nummer 4: Wie nennt man drei Tore eines Spielers in einem Spiel?");
    Console.WriteLine("1.  Hattrick");
    Console.WriteLine("2. Triple Pass");
    Console.WriteLine("3. Supergoal");
    Console.WriteLine("4. Foottrick");
}
else if (theme == "3")
{
    Console.WriteLine("Frage Nummer 4: Wie viele Kontinente gibt es im üblichen Kontinente-Modell?");
    Console.WriteLine("1. fünf");
    Console.WriteLine("2. sechs");
    Console.WriteLine("3. sieben");
    Console.WriteLine("4. acht");
}
else if (theme == "4")
{
    Console.WriteLine("Frage Nummer 4: Welches Gas brauchen Menschen zum Atmen?");
    Console.WriteLine("1. Stickstoff");
    Console.WriteLine("2. Sauerstoff");
    Console.WriteLine("3. Helium");
    Console.WriteLine("4. Wasserdampf");
}
else if (theme == "5")
{
    Console.WriteLine("Frage Nummer 4: Löse nach x auf: 3x + 5 = 20");
    Console.WriteLine("1. 20");
    Console.WriteLine("2. 3");
    Console.WriteLine("3. 15");
    Console.WriteLine("4. 5");
}

    //Antwort von Frage Nummer 4 prüfen
    bool validAnswer4 = false;
while (validAnswer4 == false)
{
    //If - else schleife zum prüfen ob es korrekt ist. Zusammen mit eine While schleife damit es bei ungültige eingaben nochmals kommt.
    Console.WriteLine("Antworte von 1-4!");
    answer = Console.ReadLine();
    if (answer == "4" && theme == "1")
    {
        Console.WriteLine("Korrekt! Yuhuu!");
        points++;
        validAnswer4 = true;
    }
    else if (answer == "1" && theme == "2")
    {
        Console.WriteLine("Korrekt! Yuhuu!");
        points++;
        validAnswer4 = true;
    }
    else if (answer == "3" && theme == "3")
    {
        Console.WriteLine("Korrekt! Yuhuu!");
        points++;
        validAnswer4 = true;
    }
    else if (answer == "2" && theme == "4")
    {
        Console.WriteLine("Korrekt! Yuhuu!");
        points++;
        validAnswer4 = true;
    }
    else if (answer == "4" && theme == "5")
    {
        Console.WriteLine("Korrekt! Yuhuu!");
        points++;
        validAnswer4 = true;
    }
    else if (answer == "1" || answer == "2" || answer == "3" || answer == "4")
    {
        Console.WriteLine("Leider falsch! Versuche es beim nächsten Mal.");
        validAnswer4 = true;
    }
    else
    {
        Console.WriteLine("Ungültige Antwort, versuche es nochmals.");
    }
}

// Frage Nummer 5
Console.WriteLine();
if (theme == "1")
{
    Console.WriteLine("Frage Nummer 5: Was macht eine Schleife in der Programmierung?");
    Console.WriteLine("1. Sie löscht das Programm");
    Console.WriteLine("2. Sie wiederholt Anweisungen");
    Console.WriteLine("3. Sie startet den Computer neu");
    Console.WriteLine("4. Sie geben dir einen Virus");
}
else if (theme == "2")
{
    Console.WriteLine("Frage Nummer 5: Welche Karte bedeutet, dass ein Spieler vom Platz muss?");
    Console.WriteLine("1.  Gelbe Karte");
    Console.WriteLine("2. Grüne Karte");
    Console.WriteLine("3. Rote Karte");
    Console.WriteLine("4. Weisse Karte");
}
else if (theme == "3")
{
    Console.WriteLine("Frage Nummer 5: Welches Land hat die Form eines Stiefels?");
    Console.WriteLine("1. Spanien");
    Console.WriteLine("2. Frankreich");
    Console.WriteLine("3. Portugal");
    Console.WriteLine("4. Italien");
}
else if (theme == "4")
{
    Console.WriteLine("Frage Nummer 5: Wie lautet das chemische Symbol für Gold?");
    Console.WriteLine("1. Go");
    Console.WriteLine("2. Gd");
    Console.WriteLine("3. Au");
    Console.WriteLine("4. Ac");
}
else if (theme == "5")
{
    Console.WriteLine("Frage Nummer 5: Ein Rechteck ist 8cm lang und 5cm breit. Wie gross ist die Fläche?");
    Console.WriteLine("1. 40cm²");
    Console.WriteLine("2. 40cm");
    Console.WriteLine("3. 40cm³");
    Console.WriteLine("4. 40m");
}

    //Antwort von Frage Nummer 4 prüfen
    bool validAnswer5 = false;
while (validAnswer5 == false)
{
    //If - else schleife zum prüfen ob es korrekt ist. Zusammen mit eine While schleife damit es bei ungültige eingaben nochmals kommt.
    Console.WriteLine("Antworte von 1-4!");
    answer = Console.ReadLine();
    if (answer == "2" && theme == "1")
    {
        Console.WriteLine("Korrekt! Yuhuu!");
        points++;
        validAnswer5 = true;
    }
    else if (answer == "3" && theme == "2")
    {
        Console.WriteLine("Korrekt! Yuhuu!");
        points++;
        validAnswer5 = true;
    }
    else if (answer == "4" && theme == "3")
    {
        Console.WriteLine("Korrekt! Yuhuu!");
        points++;
        validAnswer5 = true;
    }
    else if (answer == "3" && theme == "4")
    {
        Console.WriteLine("Korrekt! Yuhuu!");
        points++;
        validAnswer5 = true;
    }
    else if (answer == "1" && theme == "5")
    {
        Console.WriteLine("Korrekt! Yuhuu!");
        points++;
        validAnswer5 = true;
    }
    else if (answer == "1" || answer == "2" || answer == "3" || answer == "4")
    {
        Console.WriteLine("Leider falsch! Versuche es beim nächsten Mal.");
        validAnswer5 = true;
    }
    else
    {
        Console.WriteLine("Ungültige Antwort, versuche es nochmals.");
    }
}


//erzielte Punkte ausgeben.
Console.WriteLine();
Console.WriteLine("=====================");
Console.WriteLine($"Dein Punktestand:");
Console.WriteLine($"Punkte: {points}");
Console.WriteLine("=====================");
//Nachricht nach der Analyse der Punkte
Console.WriteLine();
if (points < 2)
{
    Console.WriteLine("Kopf hoch, das nächstes Mal klappt das Schon.");
}
else if (points > 2)
{
    Console.WriteLine("Gut gemacht!");
}