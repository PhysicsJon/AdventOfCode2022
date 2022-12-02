using AdventOfCode2022.Utils;

Console.Write("Day to run: ");
var dayString = Console.ReadLine();

if (string.IsNullOrEmpty(dayString))
{
    Console.Error.WriteLine("Day cannot be null");
}
else
{

    Type? day = Type.GetType("AdventOfCode2022.Day" + dayString);

    if (day is not null && Activator.CreateInstance(day) is IAdventOfCode dayInstance)
    {
        Console.WriteLine("Part 1");
        dayInstance.Problem1();

        Console.WriteLine("--------------------------");
        Console.WriteLine("Part 2");
        dayInstance.Problem2();
    }
}