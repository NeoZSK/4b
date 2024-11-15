Console.WriteLine("somethign");


const int WIDTH = 10;
const int HEIGHT = 5;

int x = 3, y = 3;

while (true)
{

    Console.Clear();
    // Draw map
    for (int i = 0; i < HEIGHT; i++)
    {
        {
            for (int j = 0; j < WIDTH; j++)
            {

                if (j == x && i == y)
                {
                    Console.Write("*");
                }

                else
                {
                    Console.Write(".");
                }
            }

            Console.WriteLine();
        }
    }

    ConsoleKeyInfo k = Console.ReadKey();

    // move
    switch (k.Key)
    {
        case ConsoleKey.DownArrow:
                y = ++y % WIDTH; 

            break;

        case ConsoleKey.UpArrow:
            y--; break;
    }
}