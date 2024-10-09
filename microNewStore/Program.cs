
int Namn = 1;
bool ohemgee = false;

while (ohemgee == false )
{
    string Ladd = Console.ReadLine();

    ohemgee = int.TryParse(Ladd, out Namn);

    if (ohemgee == false)
    {
        Console.WriteLine("Skriv en siffra, dumhuvve");
    }
}



for (int i = 0; i < Namn; i++)
{
    if (i >= 5)
    {
        Console.WriteLine("frog" + i);
    }
    else
    {
        Console.WriteLine("dog" + i);

    }
}



Namn = 1;
ohemgee = false;

while (ohemgee == false )
{
    string Ladd = Console.ReadLine();

    ohemgee = int.TryParse(Ladd, out Namn);

    if (ohemgee == false)
    {
        Console.WriteLine("Skriv en siffra, dumhuvve");
    }
}

Console.WriteLine(Namn * 2 + Namn/2 + Namn + 2 + Namn - 2);


Console.ReadLine();