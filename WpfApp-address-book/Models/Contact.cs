namespace WpfApp_address_book.Models;

public interface IContact
{
    string FirstName { get; set; }
    string LastName { get; set; }
    string Email { get; set; }

    string DisplayName => $"{FirstName} {LastName}";
}

public class Contact : IContact
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;

    public string DisplayName => $"{FirstName} {LastName}";
}
