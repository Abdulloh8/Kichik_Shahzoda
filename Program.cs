
using Kichik_Shahzoda;



var  testCases = int.Parse(Console.ReadLine() ?? "0");

while (testCases-- > 0)
{
    var kesishlarSoni = 0;
    var kordinatalar = Console.ReadLine()?
        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    var shaxzoda = new Nuqta(kordinatalar![0], kordinatalar![1]);
    var malika = new Nuqta(kordinatalar![2], kordinatalar![3]);

    var planetalarSoni = int.Parse(Console.ReadLine() ?? "0");

    while (planetalarSoni-- > 0)
    {
        
        var planeteDate = Console.ReadLine()?
           .Split(' ', StringSplitOptions.RemoveEmptyEntries)
           .Select(int.Parse)
           .ToArray();

        var markaz = new Nuqta(planeteDate![0], planeteDate![1]);
        var planeta = new Aylana(markaz , planeteDate![2]);

        var shahzodaIchida = planeta.IsIn(shaxzoda);
        var malikaIchida = planeta.IsIn(malika);

        var kesibOtadimi = shahzodaIchida ^ malikaIchida;
        if (kesibOtadimi)
            kesishlarSoni++;
    }
    Console.WriteLine(kesishlarSoni);
}

