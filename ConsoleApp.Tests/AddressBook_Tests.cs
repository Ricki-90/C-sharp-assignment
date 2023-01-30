using ConsoleApp_address_book.Models;
using ConsoleApp_address_book.Services;

namespace ConsoleApp.Tests
{
    public class AddressBook_Tests
    {
        Menu addressBook;
        Contact contact;
        

        public AddressBook_Tests()
        {
            //arrange
            addressBook = new Menu();
            contact = new Contact();
            
        }

        [Fact]
        public void Should_Add_Contact_To_List()
        {
            addressBook.newcontacts.Add(contact);
            addressBook.newcontacts.Add(contact);

            // assert
            Assert.Equal(2, addressBook.newcontacts.Count);
        }

        [Fact]
        public void Should_Remove_Contact_From_List()
        {
            // arrange
            addressBook.newcontacts.Add(contact);
            addressBook.newcontacts.Add(contact);

            // act
            addressBook.newcontacts.Remove(contact);

            // assert
            Assert.Single(addressBook.newcontacts);
        }

    }
}