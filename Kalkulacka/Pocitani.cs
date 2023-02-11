using System.Globalization;

internal class Pocitani
{
    public static void Add()
    {
        var addResult = 0f;
        Console.Clear();
        while (true)
        {
            Console.WriteLine("Zadejte číslo: (ex: 9.98) Pro vyhodnocení napište \"stop\".");
            var userAdd = Console.ReadLine();
            if (userAdd.ToLower() == "stop")
                break;
            var addNumber = 0f;
            try
            {
                addNumber = float.Parse(s: userAdd, provider: CultureInfo.InvariantCulture.NumberFormat);
            }
            catch
            {
                Console.WriteLine("Špatné zadání, ujistětese že číslo zadáváte ve správném formátu.");
            }
            addResult += addNumber;
        }
        Console.WriteLine("Součet vašich čísel je: " + addResult + " Zmáčkněte jakoukoli klávesu pro vrácení se do menu.");
        Console.ReadKey();
    }
}