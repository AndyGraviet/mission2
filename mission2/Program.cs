// ANDREW GRAVIET, SECTION 004
// DICE ROLL GAME MISSION #2
using System;
using System.Reflection;
using static mission2.DiceFunctionality;

namespace mission2
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the dice roller game. \n Please enter how many times the pair of dice will be rolled:");
            int maxRolls = Int32.Parse(Console.ReadLine()!);
            DiceFunctionality df = new DiceFunctionality();
            df.Roll(maxRolls);
        }
    }
}

