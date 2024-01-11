namespace DemoYield;

public static class Yield 
{
    public static IEnumerable<int> NotUseYield() 
    {
        Console.WriteLine($"\nNot use Yield");
        var list = new List<int>();
        for (int i = 0; i < 100000000; i++)
            list.Add(i);

        return list;
    }

    public static IEnumerable<int> UseYield() 
    {
        Console.WriteLine($"\nUse Yield");
        for (int i = 0; i < 100000000; i++)
            yield return i;
    }
}
