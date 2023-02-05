using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Documents;
using WpfApp_address_book.Models;
using WpfApp_address_book.Services;

namespace WpfApp_address_book
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Contact> contacts= new ObservableCollection<Contact>();
        private readonly FileService file = new();



        public MainWindow()
        {
            InitializeComponent();
            file.FilePath = @$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\content.json";
           
            PopulateContactsList();
        }

        private void PopulateContactsList()
        {
            try
            {
                var items = JsonConvert.DeserializeObject<ObservableCollection<Contact>>(file.Read());
                if (items != null)
                    contacts = items;
            }
            catch { }

            lv_Contacts.ItemsSource= contacts;
        }

        private void Btn_Add_Click(object sender, RoutedEventArgs e)
        {
            contacts.Add(new Contact
            {
                FirstName = TB_FirstName.Text,
                LastName = TB_LastName.Text,
                Email = TB_Email.Text 
            });

            file.Save(JsonConvert.SerializeObject(contacts));
            ClearForm();
        }

        private void ClearForm()
        {
            TB_FirstName.Text = "";
            TB_LastName.Text = "";
            TB_Email.Text = "";
        }
    }
}
