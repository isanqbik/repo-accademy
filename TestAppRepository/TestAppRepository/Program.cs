namespace TestAppRepository
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int option;
            int selectedOption = 0;
            //string[] contacts = ["James Dohar", "Mathew Willy"];
            List<string> contacts = new List<string>() { "James Dohar", "Mathew Willy" };

            bool programOn = true;

            while (programOn)
            {
                Console.WriteLine("Select an option, enter a option number:");
                Console.WriteLine("1 - Add new contact:");
                Console.WriteLine("2 - View all contacts:");
                Console.WriteLine("3 - Search contact:");
                Console.WriteLine("4 - Delete contact:");
                Console.WriteLine("5 - Exit program:");

                string answer = Console.ReadLine();

                if (int.TryParse(answer, out int value))
                {
                    if (selectedOption <= 5)
                    {
                        Console.WriteLine("The number is not from 1 to 5");
                    }
                    selectedOption = Convert.ToInt32(answer);
                    Console.WriteLine($"Option selected:{selectedOption}");
                }
                else 
                {
                    Console.WriteLine("You must write a number from 1 to 5");
                }


                switch (selectedOption)
                {
                    case 1:
                        Console.WriteLine("Add new contact name:");
                        Contact contact = new Contact();
                        contact.Name = Console.ReadLine();
                        //contacts = contacts.Append(contact.Name).ToArray();
                        contacts.Add(contact.Name);
                        Console.WriteLine($"new contact added {contact.Name}");
                        break;
                    case 2:
                        Console.WriteLine("All contact list:");
                        if (contacts.Count > 0)
                        {
                            foreach (string c in contacts)
                            {
                                Console.WriteLine("- "+ c);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Contact list is empty");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Search contact name:");
                        Contact searchingContact = new Contact();
                        searchingContact.Name = Console.ReadLine();
                        Console.WriteLine($"searching {searchingContact.Name}...");

                        string stringToFind = searchingContact.Name;
                        var result = contacts.FirstOrDefault(stringToCheck => stringToCheck.Contains(stringToFind));
                        //string result = Array.Find(contacts, element => element == stringToFind);

                        if (result == stringToFind)
                        {
                            Console.WriteLine($"{result} is in the contact list");
                        }
                        else
                        {
                            Console.WriteLine($"{stringToFind} not found in the contact list :(");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Write contact name to delete:");
                        Contact contactToDelete = new Contact();
                        contactToDelete.Name = Console.ReadLine();
                        contacts.Remove(contactToDelete.Name);
                        Console.WriteLine($"{contactToDelete.Name} has been removed from contact list");
                        break;
                    case 5:
                        Console.WriteLine("Good bye");
                        programOn = false;
                        break;
                }
            }
        }
    }
}
