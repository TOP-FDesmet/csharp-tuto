int num1 = 9;
int num2 = 2;

int result = num1 + num2;
Console.WriteLine($"Addition = {result}");

result = num1 - num2;
Console.WriteLine($"Soustraction = {result}");

result = num1 * num2;
Console.WriteLine($"Multiplication = {result}");

result = num1 / num2;
Console.WriteLine($"Division = {result}");

result = num1 % num2;
Console.WriteLine($"Modulo = {result}");

string firstname;
int age;

Console.WriteLine("Veuillez saisir votre prénom");
firstname = Console.ReadLine();

Console.WriteLine("Veuillez saisir votre âge");
// age = int.Parse(Console.ReadLine());
age = Convert.ToInt32(Console.ReadLine());

// String operator
Console.WriteLine("Bonjour " + firstname + ", vous avez " + age + " ans !");
