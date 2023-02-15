using System.Globalization;

internal class Pocitani : FileSave
{
    public static void Add()
    {
        var addResult = 0f;
        var listForSave = new List<float>();
        Console.Clear();
        while (true)
        {
            Console.WriteLine("Pro vyhodnocení napište \"stop\". \nZadejte číslo: (ex: 9.98)");
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
            listForSave.Add(addNumber);
            addResult += addNumber;
        }

        Default.Odpoved(addResult);
        Save(listForSave, addResult, '+');
        Console.ReadKey();
    }

    public static void Sub()
    {

    }
}