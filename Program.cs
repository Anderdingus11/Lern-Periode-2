//Ich habe mit das Gerüst des Programms angefangen.
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

bool valid = false;

//Wenn eine ungültige eingabe eingegeben wird,soll die Frage erneut gefragt werden
while (valid == false)
{
    Console.WriteLine("Wähle etwas aus! (1-3)");
    string theme = Console.ReadLine();
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
    else
    {
        Console.WriteLine("Ungültige eingabe. Versuche es bitte neu.");
    }
}

//Erste Quizfrage Programmieren
Console.WriteLine();
Console.WriteLine("Lass uns mit der erste Frage beginnen!");
Console.WriteLine("Frage 1: Wer hat im Jahr 2022 die Weltmeisterschaft in Fussball gewonnen");
Console.WriteLine("1. Argentinien");
Console.WriteLine("2. Frankreich");
Console.WriteLine("3. Spanien");
bool validAnswer1 = false;

//Variable für die Antwort
//If - else schleife zum prüfen ob es korrekt ist. Zusammen mit eine While schleife damit es bei ungültige eingaben nochmals kommt.

while (validAnswer1 == false)
{
    Console.WriteLine("Antworte von 1-3!");
    string answer = Console.ReadLine();
    if (answer == "1")
    {
        Console.WriteLine("Korrekt! Yuhuu!");
        validAnswer1 = true;
    }
    else if (answer == "2")
    {
        Console.WriteLine("Das ist leider falsch. Richtig war die Nummer 1.");
        validAnswer1 = true;
    }
    else if (answer == "3")
    {
        Console.WriteLine("Das ist leider falsch. Richtig war die Nummer 1.");
        validAnswer1 = true;
    }
    else
    {
        Console.WriteLine("Ungültige Antwort, versuche es nochmals.");
    }
}