using System;

namespace Diamond.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var diamond = new DiamondFactory();
            Console.WriteLine(diamond.PrintDiamond(args[0].ToCharArray()[0]));
        }
    }
}
