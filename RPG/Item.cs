namespace RPG
{
    internal class Item
    {
        public string Type;
        private char Icon;
        private Position Position;

        public Item(string type, char icon, Position position)
        {
            Type = type;
            Icon = icon;
            Position = position;
        }

        public char GetIcon()
        {
            return Icon;
        }

        public void RunEvent(Player p)
        {
            switch (Type) {

                case "item": EventPickup(p); break;
                case "lever": EventOpenDoor(); break;
            }
        }
        private void EventPickup(Player p)
        {
            throw new NotImplementedException();
        }

        private void EventOpenDoor()
        {
            throw new NotImplementedException();
        }
    }
}
