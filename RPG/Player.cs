namespace RPG
{
    internal class Player
    { 
        public const char ICON = '*';

        public string Name { get; private set; }
        public int Hp { get; private set; }
        public List<string> Eq { get; private set; }
        public Position position { get; private set; }

        private Map _map;

        public Player(string name, Map map)
        {

            Name = name;
            Hp = 100;
            Eq = new List<string>();
            _map = map;
        }


        public void AddToEq ()
        {
            throw new NotImplementedException ();
        }

        public void ListEq()
        {
            throw new NotImplementedException ();
        }



        public void Move()
        {
            var key = Console.ReadKey();
            Position nextPos = position;

            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    nextPos.Y -= 1;
                    break;
                case ConsoleKey.DownArrow:
                    nextPos.Y += 1;
                    break;
                case ConsoleKey.LeftArrow:
                    nextPos.X -= 1;
                    break;
                case ConsoleKey.RightArrow:
                    nextPos.X += 1;
                    break;
            }

            UpdatePosition(nextPos);
        }


        private void UpdatePosition(Position nextPos)
        {
            char tile = _map.GetBoardTile(nextPos);
            if (_map.IsSteppable(tile))
            {
                position = nextPos;
            }
        }

        

    }
}
