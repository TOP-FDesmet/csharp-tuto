using TPCalculator;

int val1;
int val2;
int result;
string operatorType;

List<string> operators = ["Addition", "Soustraction", "Multiplication", "Division", "Modulo"];

Calculator calcul = new();

Console.WriteLine("Veuillez saisir le premier nombre");
val1 = int.Parse(Console.ReadLine());

Console.WriteLine("Veuillez saisir le second nombre");
val2 = int.Parse(Console.ReadLine());

Console.WriteLine("Veuillez saisir le type d'opération à effectuer :");
foreach (string val in operators)
{
  Console.WriteLine(val);
}
operatorType = Console.ReadLine();

if (operatorType == "+")
{
  result = calcul.Add(val1, val2);
}
else if (operatorType == "-")
{
  result = calcul.Sub(val1, val2);
}
else if (operatorType == "*")
{
  result = calcul.Multiplication(val1, val2);
}
else if (operatorType == "/")
{
  result = calcul.Division(val1, val2);
}
else if (operatorType == "%")
{
  result = calcul.Modulo(val1, val2);
}
else
{
  Console.WriteLine("Opérateur non reconnu !");
  return;
}

Console.WriteLine("Le résultat de l'opération est " + result);
