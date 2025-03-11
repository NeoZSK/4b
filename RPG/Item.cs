namespace RPG
{
    internal class Item
    {
        public string Type;
        private char Icon;

        public Item(string type, char icon)
        {
            Type = type;
            Icon = icon;

        }

        public char GetIcon()
        {
            return Icon;
        }

        public void RunEvent(Player p)
        {
            switch (Type) {

                case "item": EventPickup(p); break;
                case "lever": EventOpenDoor(p); break;
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
