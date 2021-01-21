using System;
class SnakeLadder
{
    public static int INTIAL_POSITION = 0;
    public static int FINAL_POSITION = 100;
    public static int NUMBER_OF_PLAYER = 1;
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

    static void Main(string[] args)
    {
        int position = 0;
        while (position < FINAL_POSITION)
        {
            Random random = new Random();
            int dice_value = random.Next(1, 7);
            position = Option_Check(position, dice_value);

        }
        Console.WriteLine("Player's Final Position :" + " " + position);
    }
}

