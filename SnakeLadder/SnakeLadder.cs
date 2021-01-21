using System;
class SnakeLadder
{
    public static int INTIAL_POSITION = 0;
    public static int FINAL_POSITION = 100;
    public static int NUMBER_OF_PLAYER = 2;
    public static int LADDER = 1;
    public static int SNAKE = 2;
    public static int NO_PLAY = 3;
    public static int Option_Check(int position, int dice_value)
    {
        Random random = new Random();
        int option = random.Next(1, 4);
        switch (option)
        {
            case 1:
                Console.WriteLine("Player getting Ladder");
                if (position + dice_value > 100)
                    position = position;
                else
                    position += dice_value;
                break;
            case 2:
                Console.WriteLine("Player getting Snake");
                if (position > 0)
                    position -= dice_value;
                else
                    position = position;
                break;
            case 3:
                Console.WriteLine("Now Player is not Playing");
                position = position;
                break;
            default:
                break;
        }
        if (position < 0)
            position = INTIAL_POSITION;
        return position;
    }
    public static void Two_Player_Game()
    {
        int position = 0;
        int first_player_position = 0;
        int position_count = 0;
        int second_player_position = 0;
        while (position < FINAL_POSITION)
        {
            Random random = new Random();
            int dice_value_first = random.Next(1, 7);
            int dice_value_second = random.Next(1, 7);
            first_player_position = Option_Check(first_player_position, dice_value_first);
            second_player_position = Option_Check(second_player_position, dice_value_second);
            if (first_player_position > second_player_position)
                position = first_player_position;
            else
                position = second_player_position;
            position_count++;
        }
        if (first_player_position > second_player_position)
            Console.WriteLine("First Player is Winner");
        else
            Console.WriteLine("Second Player is Winner");
        Console.WriteLine("Position of First Player" + " " + first_player_position);
        Console.WriteLine("Position of Second Player" + " " + second_player_position);
        Console.WriteLine("No.Of Times Dice Roll" + " " + position_count);
    }
    static void Main(string[] args)
    {
        Two_Player_Game();
    }

}

