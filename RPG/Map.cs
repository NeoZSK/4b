
namespace RPG
{

    internal class Map
    {
        public const char WALL = '#';
        public const char GROUND = '.';

        private const string ROOT_DATA_PATH = @"C:\Users\User\Documents\data";
        private const string MAIN_MAP_PATH = ROOT_DATA_PATH + @"\map.txt";

        private Tile[,] _board = new Tile[0,0];

        public void Draw( Position playerPos)
        {
            for (int j = 0; j < _board.GetLength(1); j++)
            {
                for (int i = 0; i < _board.GetLength(0); i++)
                {
                    if (i == playerPos.X && j == playerPos.Y)
                    {
                        Console.Write(Player.ICON);
                    }
                    else
                    {
                        Console.Write(_board[i, j]);
                    }
                }
                Console.WriteLine();
            }
        }

        public void ImportBoard(string path = MAIN_MAP_PATH)
        {
            string[] lines = File.ReadAllLines(MAIN_MAP_PATH);
            int height = lines.Length;
            int width = lines[0].Length;
            _board = new Tile[width, height];
            for (int i = 0; i < height; i++)
            {
                char[] linia = lines[i].ToCharArray();
                for (int j = 0; j < width; j++)
                {

                    char groundIcon = linia[j];
                    Tile tile = new Tile(groundIcon);
                    _board[j, i] = tile;


                }
            }
        }

        public char GetBoardTile(Position pos)
        {
            if (pos.X < 0 || pos.X >= _board.GetLength(0)) return WALL;
            if (pos.Y < 0 || pos.Y >= _board.GetLength(1)) return WALL;
            return _board[pos.X, pos.Y];
        }

        public bool IsSteppable(char tile)
        {
            char[] steppableTiles = { GROUND };
            return steppableTiles.Contains(tile);
        }
    }
}
