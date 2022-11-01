Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("--- Maior De Três ---\n");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Write("Digite o primeiro número: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Write("Digite o segundo número: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Write("Digite o terceiro número: ");
int n3 = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();

int maiorNumero;

if (n1 > n2)
{
    if (n1 > n3)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        maiorNumero = n1;
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        maiorNumero = n3;
        Console.ResetColor();
    }
}
else
{
    if (n2 > n3)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        maiorNumero = n2;
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        maiorNumero = n3;
        Console.ResetColor();
    }
}
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"\nMaior número: {maiorNumero}");
Console.ResetColor();