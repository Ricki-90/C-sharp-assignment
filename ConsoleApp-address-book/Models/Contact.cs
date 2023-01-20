namespace ConsoleApp_address_book.Models;

internal interface IContact
{
    string Address { get; set; }
    string City { get; set; }
    string Email { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
    string Phone { get; set; }
    string DisplayNameEmail => $"\n{"Förnamn: " + FirstName} \n{"Efternamn: " + LastName} \n{"E-post: " + Email}\n";

    string DisplayAllInfo => $"\n{"Förnamn: " + FirstName} \n{"Efternamn: " + LastName} \n{"E-post: " + Email}\n{"Telefonnummer: " + Phone} \n{"Adress: " + Address}{","} {City}\n";
}

internal class Contact : IContact
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public string Address { get; set; } = null!;
    public string City { get; set; } = null!;
}
