using TPCalculator;

string operatorType;

List<string> operators = ["Addition", "Soustraction", "Multiplication", "Division", "Modulo"];

Calculator calcul = new();

Console.WriteLine("Veuillez saisir le premier nombre");
calcul.OperandLeft = int.Parse(Console.ReadLine());

Console.WriteLine("Veuillez saisir le second nombre");
calcul.OperandRight = int.Parse(Console.ReadLine());

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
