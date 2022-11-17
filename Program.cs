using System.Security.Cryptography;

Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine("Dados disponíveis");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("\nDado de 4 lados");
Console.WriteLine("Dado de 6 lados");
Console.WriteLine("Dados de 8 lados");
Console.WriteLine("Dado de 10 lados");
Console.WriteLine("Dado de 12 lados");
Console.WriteLine("Dado de 20 lados");
Console.WriteLine("Dado de 100 lados");
Console.ResetColor();
Console.ReadKey();

Console.Clear();


Console.Write("Qual dado você escolhe? ");
int dado = Convert.ToInt32(Console.ReadLine());

int rolada = RandomNumberGenerator.GetInt32(1, dado + 1);
if (rolada == 1)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"\nVocê tirou {rolada}... DESASTRE!");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine($"\nRolagem: {rolada}");
    Console.ResetColor();
}

