const int legalAge = 18;
string firstname;
int age;

Console.WriteLine("Veuillez saisir votre prénom");
firstname = Console.ReadLine();

Console.WriteLine("Veuillez saisir votre âge");
age = int.Parse(Console.ReadLine());

Console.WriteLine($"Bonjour {firstname}, vous avez {age} ans");

bool isLegalAge = age >= legalAge;

if (isLegalAge)
{
  Console.WriteLine("Vous êtes majeur !");
} 
else
{
  Console.WriteLine("Vous êtes mineur !");
}
