using TPCalculator;
using TPCalculator.Operations;

string operatorType;

List<string> operators = ["Addition", "Soustraction", "Multiplication", "Division", "Modulo"];

Console.WriteLine("Veuillez saisir le premier nombre");
var o1 = int.Parse(Console.ReadLine());

Console.WriteLine("Veuillez saisir le second nombre");
var o2 = int.Parse(Console.ReadLine());

Calculator calcul = new(o1, o2);

Console.WriteLine("Veuillez saisir le type d'opération à effectuer :");
foreach (string val in operators)
{
  Console.WriteLine(val);
}
operatorType = Console.ReadLine();

if (operatorType == "+")
{
  calcul.Addition();
}
else if (operatorType == "-")
{
  calcul.Substraction();
}
else if (operatorType == "*")
{
  calcul.Multiplication();
}
else if (operatorType == "/")
{
  calcul.Division();
}
else if (operatorType == "%")
{
  calcul.Modulo();
}
else
{
  Console.WriteLine("Opérateur non reconnu !");
  return;
}

Console.WriteLine("Le résultat de l'opération est " + calcul.Result);
