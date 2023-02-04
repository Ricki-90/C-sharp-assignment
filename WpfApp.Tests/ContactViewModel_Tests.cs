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
            viewModel.Contacts.Add(new Contact { FirstName= "Rickard", LastName = "Johansson" });


            //assert
        }
    }
}