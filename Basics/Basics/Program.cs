namespace Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height;
            int width;


            // Pobranie wartości (wymiarów) od użytkownika

            Console.WriteLine("Gimme height:");
            height = int.Parse(Console.ReadLine());
            Console.WriteLine("Gimme width:");
            width = int.Parse(Console.ReadLine());

            // Wyrysowanie rzędu gwiazdek
            // Powtórzenie rzędu według wartości

            for (int a = 0; a < height; a++)
            {
                for (int i = 0; i < width; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }





        }


        static int SumValues(int a, int b)
        {
            int sum = a + b;
            return sum;
        }





















    }
}
