const int misteryNumber = 4;
string firstname;
int yourNumber;

Console.WriteLine("Veuillez saisir votre prénom.");
firstname = Console.ReadLine();

Console.WriteLine($"Bienvenue {firstname} ! Veuillez saisir un nombre entre 1 et 7.");
yourNumber = int.Parse(Console.ReadLine());

if (yourNumber == misteryNumber)
{
  Console.WriteLine("Bravo vous avez gagné !");
}
else
{
  Console.WriteLine("Oups ! Vous avez perdu.");
  
  if (yourNumber > misteryNumber)
  {
    Console.WriteLine("Le nombre mystère saisi est plus petit !");
  }
  else
  {
    Console.WriteLine("Le nombre mystère saisi est plus grand !");
  }
}
