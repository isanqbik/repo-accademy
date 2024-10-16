namespace TestAppRepository
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int option;
            int selectedOption = 0;
            string[] contacts = [];

            Console.WriteLine("Select an option, enter a option number:");
            Console.WriteLine("1 - Add new contact:");
            Console.WriteLine("2 - View all contacts:");
            Console.WriteLine("3 - Search contact:");
            Console.WriteLine("4 - Delete contact:");
            Console.WriteLine("5 - Exit program:");

            string answer = Console.ReadLine();
            selectedOption = Convert.ToInt32(answer);

            Console.WriteLine($"Option selected:{selectedOption}");

            switch (selectedOption) { 
                case 1:
                    Console.WriteLine("Add new contact name:");
                    Contact contact = new Contact();
                    contact.Name = Console.ReadLine();
                    Console.WriteLine($"new contact added {contact.Name}");
                    contacts = contacts.Append(contact.Name).ToArray();
                    Console.WriteLine("added contact");
                    break;
                case 2:
                    Console.WriteLine("All contact list:");
                    if (contacts.Length > 0)
                    {
                        foreach (string c in contacts)
                        {
                            Console.WriteLine(c);
                        }
                    }
                    else {
                        Console.WriteLine("Contact list is empty");
                    }
                    break;
            }

        }
    }
}
