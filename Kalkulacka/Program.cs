using System.Globalization;
internal class Program : Pocitani
{
    private static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.White;
        while (true)
        {
            Console.WriteLine(@"Výtejte v kalkulačce! Autor: Filip Jaruška
Menu:
0 pro ukončení aplikace
1 pro sčítání čísel
2 pro odčítání čísel
3 pro násobení čísel
4 pro dělení čísel
5 pro druhou odmocninu
..
8 pro historii
9 pro odstranění části/celé historie
");
            Console.WriteLine("\n Zadejte možnost: ");
            var userImput = Console.ReadKey().KeyChar;
            switch (userImput)
            {
                case '0':
                    Environment.Exit(0);
                    break;
                case '1':
                    Add();
                    break;
                case '2':
                    break;
                case '3':
                    break;
            }
            Console.Clear();
        }
    }
}