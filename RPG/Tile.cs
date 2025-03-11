
namespace RPG
{
    internal class Tile
    {
        private char GroundIcon;
        private Item Item;


        public Tile(char ground)
        {
            GroundIcon = ground;
        }

        public void SetItem(Item i) => Item = i;

        public char GetIcon()
        {
            if (Item != null)
                return Item.GetIcon();
            else
                return GroundIcon;
        }



    }
}
