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

//Auswahl der Themen
//Wir wollen die theme Variable auch ausserhalb des Codes benutzen.
string theme = "";
//Wenn eine ungültige eingabe eingegeben wird,soll die Frage erneut gefragt werden
bool valid = false;
while (valid == false)
{
    Console.WriteLine("Wähle etwas aus! (1-3)");
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
    }
    else if (theme == "2")
    {
        Console.WriteLine("Frage 1: Wer hat im Jahr 2022 die Weltmeisterschaft in Fussball gewonnen?");
        Console.WriteLine("1. Argentinien");
        Console.WriteLine("2. Spanien");
        Console.WriteLine("3. Frankreich");
    }
    else if (theme == "3")
    {
        Console.WriteLine("Frage 1: Was ist die Hauptstadt der Schweiz?");
        Console.WriteLine("1. Zürich");
        Console.WriteLine("2. Bern");
        Console.WriteLine("3. Genf");
    }    

//Wir brauchen eine Bool Variable zum Prüfen ob die antwort valide ist. Und auch eine Variable für alle antworten.
string answer = "";
bool validAnswer1 = false;
while (validAnswer1 == false)
{
    //If - else schleife zum prüfen ob es korrekt ist. Zusammen mit eine While schleife damit es bei ungültige eingaben nochmals kommt.
    Console.WriteLine("Antworte von 1-3!");
    answer = Console.ReadLine();
    if (answer == "1" && theme == "1")
    {
        Console.WriteLine("Korrekt! Yuhuu!");
        validAnswer1 = true;
    }
    else if (answer == "1" && theme == "2")
    {
        Console.WriteLine("Korrekt! Yuhuu!");
        validAnswer1 = true;
    }
    else if (answer == "2" && theme == "3")
    {
        Console.WriteLine("Korrekt! Yuhuu!");
        validAnswer1 = true;
    }
    else if (answer == "1" || answer == "2" || answer == "3")
    {
        Console.WriteLine("Leider falsch! Versuche es beim nächsten Mal.");
        validAnswer1 = true;
    }
    else
    {
        Console.WriteLine("Ungültige Antwort, versuche es nochmals.");
    }
}