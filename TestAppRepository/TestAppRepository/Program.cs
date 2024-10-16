namespace TestAppRepository
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string Contacts = string.Empty;

            static void AddNewContact()
            {
                Console.WriteLine("Add new contact:");
                
                string newContact = Console.ReadLine();
                Console.WriteLine("new contact added:" + newContact);
            }

            static void ViewAllContacts()
            {
                Console.WriteLine($"All Contacts are: ");
            }

            static void SearchContact()
            {
                Console.WriteLine("Search:");

                string contactSearched = Console.ReadLine();
                Console.WriteLine("Contact searched:" + contactSearched);
            }
            
            AddNewContact();
            ViewAllContacts();
            SearchContact();
            
        }
    }
}
