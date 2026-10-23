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
    int theme = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Wähle eins aus! (1-3)");
    //Damit die Auswahl der Themen nicht nur die Nummer sagt sondern der Name, erstelle ich dafür eine If-Schleife.
    if (theme == 1)
    {
        valid = true;
        Console.WriteLine($"Du hast dich für Informatik entschieden. Na dann hoffe ich das du deine Module gut bearbeitest hast. Viel Erfolg!");
    }
    else if (theme == 2)
    {
        valid = true;
        Console.WriteLine($"Du hast dich für Fusball entschieden. Na dann bist du ja Sportlich unterwegs. Viel erfolg!");
    }
    else if (theme == 3)
    {
        valid = true;
        Console.WriteLine($"Du hast dich für Geografie entschieden. Ich hoffe du weisst viel über unsere Welt. Viel erfolg!");
    }
    else
    {
        Console.WriteLine("Ungültige eingabe. Versuche es bitte neu.");
    }
}