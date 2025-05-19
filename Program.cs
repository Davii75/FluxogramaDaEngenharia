Console.WriteLine("--- Fluxograma da Engenharia ---");
Console.WriteLine("\nAviso: Responda apenas com as letras S e N");
Console.WriteLine("\nO objeto está se movendo? (S/N) ");
bool movendo = Console.ReadLine()!.ToUpper().Trim().Substring(0, 1) == "S";
Console.WriteLine("\nDeveria? (S/N) ");
bool deveria = Console.ReadLine()!.ToUpper().Trim().Substring(0, 1) == "S";
Console.WriteLine();

if (movendo)
{
    if (deveria)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Ótimo!");
    }

    else
    {
        Console.WriteLine("Use Silver Tape.");
    }
}

else
{
    if (!deveria)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Ótimo!");
    }

    else
    {
        Console.WriteLine("Use WD-40.");
    }
}

Console.ResetColor();