using FluentAssertions;
using System.Collections.ObjectModel;
using WpfApp_address_book.Models;
using WpfApp_address_book.ViewModels;

namespace WpfApp.Tests
{
    public class ContactViewModel_Tests
    {
        private ContactsViewModel viewModel;

        public ContactViewModel_Tests()
        {
            viewModel = new ContactsViewModel();
        }


        [Fact]
        public void Should_Add_Contact_To_Contacts()
        {
            //act
            Contact contact = new Contact { FirstName= "Rickard", LastName = "Johansson" };
            viewModel.Contacts.Add(contact);

            //assert
            viewModel.Contacts.Should().BeOfType<ObservableCollection<Contact>>();
            viewModel.Contacts.Should().Contain(contact);
        }
    }
}