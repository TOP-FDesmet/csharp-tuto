int[] values = new int[3];

for (int i = 0; i < values.Length; i++)
{
    Console.WriteLine($"Veuillez saisir la valeur {i + 1}!");
    values[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < values.Length; i++)
{
    Console.WriteLine($"La valeur {i + 1} est {values[i]}");
}
