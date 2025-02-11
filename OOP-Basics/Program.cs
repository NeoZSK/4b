namespace OOP_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog("Micheal", 15);

            d.SetAge(-100);
            Console.WriteLine(d.Age);

        }
    }

    class Dog
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        private bool isPolish = true;

        public Dog(string name, int age)
        {
            Age = ValidateAge(age);
            Name = name;
        }

        public void SetAge(int age)
        {
            Age = ValidateAge(age);
        }
        public void MakeNoise()
        {
            if (isPolish)
            {
                Console.WriteLine("Szczek");
            }
            else
            {
                Console.WriteLine("Woof");
            }
        }

        private int ValidateAge(int age)
        {
            if (age > 0 && age < 50)
            {
                return age;
            }
            else
            {
                throw new Exception("Age should be in range [0;50]");
            }
        }

    }
}
