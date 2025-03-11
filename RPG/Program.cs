using RPG;


Map map = new Map();
map.ImportBoard();

Player p = new Player("Johny", map);
Console.WriteLine(p.Name);

while (true)
{
    Console.Clear();
    map.Draw(p.position);
    p.Move();
}








