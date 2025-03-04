using TPCalculator;
using TPCalculator.Interfaces;
using TPCalculator.Operations;

while (true)
{
  Console.WriteLine("Saisissez l'opérateur ou 'q' pour quitter");
  string operatorSign = Console.ReadLine();

  if (operatorSign == "q")
  {
    break;
  }

  Console.WriteLine("Veuillez saisir le premier nombre");
  var o1 = int.Parse(Console.ReadLine());

  Console.WriteLine("Veuillez saisir le second nombre");
  var o2 = int.Parse(Console.ReadLine());

  IOperation operation;
  if (operatorSign == "+")
  {
    operation = new Addition(o1, o2);
  }
  else if (operatorSign == "-")
  {
    operation = new Substraction(o1, o2);
  }
  else if (operatorSign == "*")
  {
    operation = new Multiplication(o1, o2);
  }
  else if (operatorSign == "/")
  {
    operation = new Division(o1, o2);
  }
  else if (operatorSign == "%")
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
}

foreach (var ope in History.Operations)
{
  Console.WriteLine(ope.ToString());
}
