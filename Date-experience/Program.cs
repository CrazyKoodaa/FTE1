// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

DateTime time = DateTime.Today.AddDays(-10);
DateTime end = DateTime.Today.AddDays(20);

Console.WriteLine($"Starttime: {time}; Endtime: {end}");

for (DateTime tm = time; tm <= end; tm = tm.AddDays(1))
{
    myStuff.test(tm);
    Console.WriteLine(" -> " + myStuff.isInSaison(tm));
}



class myStuff
{
    public static bool isInSaison(DateTime tm)
    {
        DateTime startSaison = DateTime.Parse("26.07.2022");
        DateTime endSaison = DateTime.Parse("28.07.2022");
        if (tm >= startSaison && tm <= endSaison)
            return true;
        return false;
    }

    public static void test(DateTime tm)
    {
        Console.Write($"Time Between: {tm}");
    }

}