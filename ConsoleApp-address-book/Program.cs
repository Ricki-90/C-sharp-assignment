using ConsoleApp_address_book.Models;
using ConsoleApp_address_book.Services;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;

var menu = new Menu();
menu.FilePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\content.json";

while (true)
{
    Console.Clear();
    menu.WelcomeMenu();
}

