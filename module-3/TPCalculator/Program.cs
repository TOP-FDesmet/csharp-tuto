using TPCalculator;

int val1;
int val2;

string choice;

List<string> operators = ["Addition", "Soustraction", "Multiplication", "Division", "Modulo"];

Calculator calcul = new Calculator();

Console.WriteLine("Veuillez saisir le premier nombre");
val1 = int.Parse(Console.ReadLine());

Console.WriteLine("Veuillez saisir le second nombre");
val2 = int.Parse(Console.ReadLine());

choice = Console.ReadLine();

if (choice == "Addition")
{
  Console.WriteLine(calcul.Add(val1, val2));
}
else if (choice == "Soustraction")
{
  Console.WriteLine(calcul.Sub(val1, val2));
}
else if (choice == "Multiplication")
{
  Console.WriteLine(calcul.Multiplication(val1, val2));
}
else if (choice == "Division")
{
  Console.WriteLine(calcul.Division(val1, val2));
}
else if (choice == "Modulo")
{
  Console.WriteLine(calcul.Modulo(val1, val2));
}
else
{
  Console.WriteLine("Veuillez choisir une opération valide");
}
