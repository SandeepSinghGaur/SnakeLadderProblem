using System;
    class SnakeLadder
    {
        static void Main(string[] args)
        {
        int INTIAL_POSITION =0;
        int NUMBER_OF_PLAYER = 1;
        Random random = new Random();
        int dice_value = random.Next(1, 7);
        Console.WriteLine("Welcome to Snake and Ladder Game!");
        Console.WriteLine("Game Start With the Intial Position:" + " " + INTIAL_POSITION);
        Console.WriteLine("Start With the Player:" + " " + NUMBER_OF_PLAYER);
        Console.WriteLine("Number got by rolling a Dice :" + " " + dice_value);
    }
    }

