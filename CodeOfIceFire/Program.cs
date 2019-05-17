using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Player
{
    static void Main(string[] args)
    {
        string[] inputs;
        int numberMineSpots = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberMineSpots; i++)
        {
            inputs = Console.ReadLine().Split(' ');
            int x = int.Parse(inputs[0]);
            int y = int.Parse(inputs[1]);
        }

        // game loop
        while (true)
        {
            int gold = int.Parse(Console.ReadLine());
            int income = int.Parse(Console.ReadLine());
            int opponentGold = int.Parse(Console.ReadLine());
            int opponentIncome = int.Parse(Console.ReadLine());
            for (int i = 0; i < 12; i++)
            {
                string line = Console.ReadLine();
            }
            int buildingCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < buildingCount; i++)
            {
                inputs = Console.ReadLine().Split(' ');
                int owner = int.Parse(inputs[0]);
                int buildingType = int.Parse(inputs[1]);
                int x = int.Parse(inputs[2]);
                int y = int.Parse(inputs[3]);
            }
            int unitCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < unitCount; i++)
            {
                inputs = Console.ReadLine().Split(' ');
                int owner = int.Parse(inputs[0]);
                int unitId = int.Parse(inputs[1]);
                int level = int.Parse(inputs[2]);
                int x = int.Parse(inputs[3]);
                int y = int.Parse(inputs[4]);
            }

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine("WAIT");
        }
    }
}