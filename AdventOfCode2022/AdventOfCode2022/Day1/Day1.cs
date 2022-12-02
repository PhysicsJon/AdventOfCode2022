using AdventOfCode2022.Utils;

namespace AdventOfCode2022
{
    public class Day1 : IAdventOfCode
    {
        public void Problem1()
        {
            var list = Setup();

            Console.WriteLine(list.Max());
        }

        public void Problem2()
        {
            var list = Setup();

            var total = list.OrderByDescending(x => x).Take(3).Sum();

            Console.WriteLine(total);
        }

        private static IList<int> Setup()
        {
            // Get file input
            var input = ReadFile.ReadFileToString("./Day1/inputDay1.txt");

            // Separate individual elves and sum calories
            return input.Split("\r\n\r\n")
                .Select(elf => elf
                    .Split("\r\n")
                    .Select(int.Parse)
                    .Sum())
                .ToList();
        }
    }
}
