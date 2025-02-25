string firstname;
int age;

Console.WriteLine("Veuillez saisir votre prénom");
firstname = Console.ReadLine();

Console.WriteLine("Veuillez saisir votre âge");
age = Int32.Parse(Console.ReadLine());

Console.WriteLine($"Bonjour {firstname}, vous avez {age} ans");
