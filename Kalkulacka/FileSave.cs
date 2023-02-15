internal class FileSave
{
    public static void Save(List<float> listSave, float numberResult, char type)
    {
        var combinedString = "";
        if (type == '+')
        {
            combinedString = string.Join(" + ", listSave.ToArray());
            combinedString = combinedString + " = " + numberResult;
        }
        Console.WriteLine("Takhle bude uloženo: \n" + combinedString);

        //ukládání logika
    }
}