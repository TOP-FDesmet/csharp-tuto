const int MISTERY_NUMBER = 4;
string firstname;
int yourNumber;
List<int> numbersPlayed = [];

Console.WriteLine("Veuillez saisir votre prénom.");
firstname = Console.ReadLine();

string indication = "";
bool win = false;

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

    Console.WriteLine($"Bienvenue {firstname} ! Veuillez saisir un nombre entre 1 et 10.");
    yourNumber = int.Parse(Console.ReadLine());

    numbersPlayed.Add(yourNumber);

    if (yourNumber == MISTERY_NUMBER)
    {
        Console.WriteLine("Bravo vous avez gagné !");
        win = true;
    }
    else
    {
        Console.WriteLine("Oups ! Vous avez perdu.");

        if (yourNumber > MISTERY_NUMBER)
        {
            indication = "Le nombre mystère saisi est plus petit !";
        }
        else
        {
            indication = "Le nombre mystère saisi est plus grand !";
        }
    }
}
