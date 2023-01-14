using ConsoleApp_address_book.Models;
using Newtonsoft.Json;

namespace ConsoleApp_address_book.Services
{
    internal class Menu
    {
        private List<IContact> newcontacts = new List<IContact>();
        private FileService file = new FileService();

        public string FilePath { get; set; } = null!;


        public void WelcomeMenu()
        {
            Console.WriteLine("Välkommen till Adressboken");
            Console.WriteLine("1. Skapa en ny kontakt");
            Console.WriteLine("2. Visa alla kontakter");
            Console.WriteLine("3. Visa en specifik kontakt");
            Console.WriteLine("4. Ta bort en specifik kontakt");
            Console.Write("Välj ett av alternativen ovan: ");
            var option = Console.ReadLine();

            switch (option)
            {
                case "1": OptionOne(); break;
                case "2": OptionTwo(); break;
                case "3": OptionThree(); break;
                case "4": OptionFour(); break;
            }

            file.Save(FilePath, JsonConvert.SerializeObject(new { newcontacts }));
        }

        private void OptionOne() 
        { 
            Console.Clear();
            Console.WriteLine("Skapa en ny kontakt");

            CreateNewContact newcontact = new CreateNewContact();
            Console.Write("Ange förnamn: ");
            newcontact.FirstName = Console.ReadLine() ?? "";
            Console.Write("Ange Efternamn: ");
            newcontact.LastName = Console.ReadLine() ?? "";
            Console.Write("Ange E-post: ");
            newcontact.Email = Console.ReadLine() ?? "";
            Console.Write("Ange Telefonnummer: ");
            newcontact.Phone = Console.ReadLine() ?? "";
            Console.Write("Ange Adress: ");
            newcontact.Address = Console.ReadLine() ?? "";
            Console.Write("Ange Stad: ");
            newcontact.City = Console.ReadLine() ?? "";

            newcontacts.Add(newcontact);
        }

        private void OptionTwo()
        {
            Console.Clear();
            Console.WriteLine("Här är en lista på alla kontakter i adressboken:");
            foreach (var contact in newcontacts) 
            {
                Console.Write(contact.DisplayNameEmail);
            }
            Console.ReadKey();
            
        }

        private void OptionThree()
        {
            Console.Clear();
            Console.WriteLine("olle");
            Console.ReadKey();

        }

        private void OptionFour()
        {
            Console.Clear();
            Console.WriteLine();

        }

    }
}
