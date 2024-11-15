
namespace Cursor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pos = 0;
            while (true)
            {
                for (int i = 0; i < Console.WindowWidth; i++) 
                    Console.Write("_");

                Console.SetCursorPosition(pos, 0);
                Console.Write("*");
                
                pos = (++pos % Console.WindowWidth);
                Thread.Sleep(1000);
                Console.Clear();

            }




        }
    }
}
