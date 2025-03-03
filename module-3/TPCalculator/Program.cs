using TPCalculator;
using TPCalculator.Operations;

string operatorType;

List<string> operators = ["Addition", "Soustraction", "Multiplication", "Division", "Modulo"];

Console.WriteLine("Veuillez saisir le premier nombre");
var o1 = int.Parse(Console.ReadLine());

Console.WriteLine("Veuillez saisir le second nombre");
var o2 = int.Parse(Console.ReadLine());

Console.WriteLine("Veuillez saisir le type d'opération à effectuer :");
foreach (string val in operators)
{
  Console.WriteLine(val);
}
operatorType = Console.ReadLine();
Operation operation;

if (operatorType == "+")
{
  operation = new Addition(o1, o2);
}
else if (operatorType == "-")
{
  operation = new Substraction(o1, o2);
}
else if (operatorType == "*")
{
  operation = new Multiplication(o1, o2);
}
else if (operatorType == "/")
{
  operation = new Division(o1, o2);
}
else if (operatorType == "%")
{
  operation = new Modulo(o1, o2);
}
else
{
  Console.WriteLine("Opérateur non reconnu !");
  return;
}

Calculator calcul = new(operation);
calcul.Execute();

Console.WriteLine("Le résultat de l'opération est " + calcul.Result);
