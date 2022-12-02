using AdventOfCode2022.Utils;

namespace AdventOfCode2022
{
    internal class Day2 : IAdventOfCode
    {
        private static readonly Dictionary<string, int> scoreForHand = new()
        {
            { "X", 1 },
            { "Y", 2 },
            { "Z", 3 }
        };

        private static readonly Dictionary<string, string> winningHands = new()
        {
            { "A", "Y" },
            { "B", "Z" },
            { "C", "X" }
        };

        private static readonly Dictionary<string, string> drawnHands = new()
        {
            { "A", "X" },
            { "B", "Y" },
            { "C", "Z" }
        };

        private static readonly Dictionary<string, string> losingHands = new()
        {
            { "A", "Z" },
            { "B", "X" },
            { "C", "Y" }
        };

        public void Problem1()
        {
            var input = Setup();
            var total = 0;

            foreach (var i in input)
            {
                total += scoreForHand[i[1]];

                if (drawnHands[i[0]] == i[1])
                {
                    total += 3;
                    continue;
                }

                if (winningHands[i[0]] == i[1])
                {
                    total += 6;
                }
            }
            Console.WriteLine(total);
        }

        public void Problem2()
        {
            var input = Setup();
            var total = 0;
            foreach (var i in input)
            {
                switch (i[1])
                {
                    case "X":
                        total += scoreForHand[losingHands[i[0]]];
                        break;
                    case "Y":
                        total += 3 + scoreForHand[drawnHands[i[0]]];
                        break;
                    case "Z":
                        total += 6 + scoreForHand[winningHands[i[0]]];
                        break;
                }
            }

            Console.WriteLine(total);
        }

        private static List<string[]> Setup()
        {
            var input = ReadFile.ReadFileToString("./Day2/inputDay2.txt");
            return input.Split("\r\n")
                        .Select(s => s.Split(' '))
                        .ToList();
        }
    }
}
