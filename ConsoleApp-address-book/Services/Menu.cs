using ConsoleApp_address_book.Models;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp_address_book.Services
{
    internal class Menu
    {
        private List<IContact> newcontacts = new List<IContact>();
        private readonly FileService file = new FileService();

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

        }

        private void OptionOne() 
        { 
            Console.Clear();
            Console.WriteLine("Skapa en ny kontakt:");

            CreateNewContact newcontact = new CreateNewContact();
            Console.Write("Ange förnamn: ");
            newcontact.FirstName = Console.ReadLine().ToLower() ?? "";
            Console.Write("Ange Efternamn: ");
            newcontact.LastName = Console.ReadLine().ToLower() ?? "";
            Console.Write("Ange E-post: ");
            newcontact.Email = Console.ReadLine().ToLower() ?? "";
            Console.Write("Ange Telefonnummer: ");
            newcontact.Phone = Console.ReadLine().ToLower() ?? "";
            Console.Write("Ange Adress: ");
            newcontact.Address = Console.ReadLine().ToLower() ?? "";
            Console.Write("Ange Stad: ");
            newcontact.City = Console.ReadLine().ToLower() ?? "";

            newcontacts.Add(newcontact);
            file.Save(FilePath, JsonConvert.SerializeObject(new { newcontacts }));
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
            Console.WriteLine("Skriv in förnamn på personen du söker: ");

            string userResponse = Console.ReadLine().ToLower();

            var contact = new Contact();

            if (userResponse == contact.FirstName)
            {
                Console.Write(contact.LastName);
            }

            Console.ReadKey();

        }



        private void OptionFour()
        {
            Console.Clear();       

            foreach (var contact in newcontacts)
            {
                Console.WriteLine("Skriv in förnamn på kontaktpersonen du vill ta bort från adressboken: ");
                string userInputFirstName = Console.ReadLine();

                Console.WriteLine("Är du säker på att du vill ta bort kontaktpersonen: Svara med Y om du är säker. Annars svara med N.");
                string userInputY = Console.ReadLine();

                if (userInputY == "Y")
                {
                    if (contact.FirstName.Equals(userInputFirstName))
                    {
                        newcontacts.Remove(contact);
                        Console.WriteLine("Kontaktpersonen är raderad");
                    }
                    else
                    {
                        Console.WriteLine("Något gick fel. Försök igen");
                    }
                }

                break;
            }

            Console.ReadKey();
        }

    }

}

