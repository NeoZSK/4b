
const char PLAYER = '*';
Position playerPos = new Position()
{
    X = 0,
    Y = 0
};


char[,] map = new char[5, 10];

while (true)
{
    Console.Clear();
    FillBoard(map);
    Draw(map, playerPos);
    Move(ref playerPos);
}


void Move(ref Position playerPos)
{
    var key = Console.ReadKey();

    switch (key.Key)
    {
        case ConsoleKey.UpArrow:
            playerPos.Y -= 1;
            break;
        case ConsoleKey.DownArrow:
            playerPos.Y += 1;
            break;
        case ConsoleKey.LeftArrow:
            playerPos.X -= 1;
            break;
        case ConsoleKey.RightArrow:
            playerPos.X += 1;
            break;
    }

}

void FillBoard(char[,] board)
{
    for (int i = 0; i < board.GetLength(0); i++)
    {
        for (int j = 0; j < board.GetLength(1); j++)
        {
            board[i, j] = '.';
        }
    }
}

void Draw(char[,] map, Position playerPos)
{
    for (int i = 0; i < map.GetLength(0); i++)
    {
        for (int j = 0; j < map.GetLength(1); j++)
        {
            if (i == playerPos.X && j == playerPos.Y)
            {
                Console.Write(PLAYER);
            }
            else
            {
                Console.Write(map[i, j]);
            }
        }
        Console.WriteLine();
    }
}


struct Position
{
    public int X;
    public int Y;
};
