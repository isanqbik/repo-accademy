namespace TestAppRepository
{
    internal class Program
    {
        static void Main(string[] args)
        {



            static void AddNewContact()
            {
                Console.WriteLine("Add new contact:");
                string Contacts = string.Empty;
                string newContact = Console.ReadLine();
                Contacts +=  newContact + ", ";
                Console.WriteLine($"Contacts are: {Contacts}");
            }

            AddNewContact();

        }
    }
}
