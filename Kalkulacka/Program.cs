using System.Globalization;
internal class Program : Pocitani
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine(@"Hello, World!
Menu:
0 for End
1 for Add
");
            var userImput = Console.ReadKey().KeyChar;
            switch (userImput)
            {
                case '0':
                    Environment.Exit(0);
                    break;
                case '1':
                    Add();
                    break;
            }
            Console.Clear();
        }
    }
}