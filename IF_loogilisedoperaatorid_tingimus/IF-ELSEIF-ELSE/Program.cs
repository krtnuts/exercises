using System;

class Program
{
    static void Main()
    {
        string kasutajaNimi;

        // Запрос имени пользователя
        do
        {
            Console.WriteLine("Palun sisesta oma kasutajanimi:");
            kasutajaNimi = Console.ReadLine();
        }
        while (kasutajaNimi != "user1");

        int ruuduSuurus;

        // Запрос размера квадрата (1–20)
        do
        {
            Console.WriteLine("Kui suur ruut tahad? (1–20)");
        }
        while (!int.TryParse(Console.ReadLine(), out ruuduSuurus) || ruuduSuurus < 1 || ruuduSuurus > 20);

        char reakuju = '*';
        string yksRida = "";

        // Формирование одной строки квадрата
        for (int i = 0; i < ruuduSuurus; i++)
        {
            yksRida += reakuju;
        }

        // Вывод квадрата
        for (int i = 0; i < ruuduSuurus; i++)
        {
            Console.WriteLine(yksRida);
        }

        Console.WriteLine($"Palun, siin on sinu ruut, suurusega {ruuduSuurus}x{ruuduSuurus}");
    }
}
