const int MisteryNumber = 4;
const int NumMin = 1;
const int NumMax = 10;

string firstname;
string indication = "";

int yourNumber;
List<int> numbersPlayed = [];

bool win = false;

Console.WriteLine("Veuillez saisir votre prénom.");
firstname = Console.ReadLine();

while (!win)
{
    Console.Clear();

    if (numbersPlayed is not [])
    {
        Console.Write("Nombres joués : ");

        foreach (int num in numbersPlayed)
        {
            Console.Write($" {num} ");
        }

        Console.WriteLine();
    }

    if (indication != "")
    {
        Console.WriteLine(indication);
    }

    Console.WriteLine($"Bienvenue {firstname} ! Veuillez saisir un nombre entre {NumMin} et {NumMax}.");

    yourNumber = 0;
    while (yourNumber < NumMin || yourNumber > NumMax)
    {
        try
        {
            yourNumber = int.Parse(Console.ReadLine());
        }
        catch
        {
            yourNumber = 0;
        }
    }

    numbersPlayed.Add(yourNumber);

    if (yourNumber == MisteryNumber)
    {
        Console.WriteLine("Bravo vous avez gagné !");
        win = true;
    }
    else
    {
        Console.WriteLine("Oups ! Vous avez perdu.");

        if (yourNumber > MisteryNumber)
        {
            indication = "Le nombre mystère saisi est plus petit !";
        }
        else
        {
            indication = "Le nombre mystère saisi est plus grand !";
        }
    }
}
