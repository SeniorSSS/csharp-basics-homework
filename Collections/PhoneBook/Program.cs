using System;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new PhoneDirectoryList();
            phoneBook.PutNumber("Janis","29374039");
            phoneBook.PutNumber("Laura", "26123378");
            phoneBook.PrintPhoneBook();
            phoneBook.PutNumber("Janis","nav tel");
            phoneBook.PrintPhoneBook();



            Console.ReadKey();
        }
    }
}
