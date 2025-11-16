namespace Index
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Enter the name:");
                String name = Console.ReadLine();

                Console.WriteLine("enter your age:");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Hello" + name);
                Console.WriteLine("Your are "+ age + " years old");

                Console.ReadKey();
        }
    }
}
