internal static class Default
{
    public static void Odpoved(float Result)
    {
        Console.WriteLine("Odpověd je: " + Result);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Zmáčkněte jakoukoli klávesu pro vrácení se do menu.");
        Console.ForegroundColor = ConsoleColor.White;
    }
}