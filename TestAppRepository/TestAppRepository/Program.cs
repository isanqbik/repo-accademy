namespace TestAppRepository
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int option;
            int selectedOption;

            Console.WriteLine("Select an option, enter a option number:");
            Console.WriteLine("1 - Add new contact:");
            Console.WriteLine("2 - View all contacts:");
            Console.WriteLine("3 - Search contact:");
            Console.WriteLine("4 - Delete contact:");
            Console.WriteLine("5 - Exit program:");

            string answer = Console.ReadLine();
            selectedOption = Convert.ToInt32(answer);

            Console.WriteLine($"Option selected:{selectedOption}");

        }
    }
}
