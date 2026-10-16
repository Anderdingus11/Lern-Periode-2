//Random Zahl erstellen
Random number = new Random();
int randomNumber = number.Next(1, 100);
Console.WriteLine("Ich habe eine Nummer im Kopf. Kannst du sie erraten?");
//Variable für unser Guess, die Anzahl Versuche und Bool
int Guess;
int Tries = 0;
bool Answer = false;
//Eine If Schleife erstellen
do
{
    //Das Programm liest unser Versuch
    Guess = Convert.ToInt32(Console.ReadLine());
    if (Guess > randomNumber)
    {
        Console.WriteLine("Tiefer!");
        Tries++;
    }
    else if (Guess < randomNumber)
    {
        Console.WriteLine("Höher!");
        Tries++;
    }
    else
    {
        Answer = true;
        Tries++;
        Console.WriteLine($"Korrekt! Du hast {Tries} Versuche gebraucht!");
    }
}
while (Answer == false);
