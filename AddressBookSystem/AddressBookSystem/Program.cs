using AddressBookSystem;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book:- \n");

            Console.WriteLine("Create Contact Details:- ");
            Contact contact = new Contact();
            Console.Write("Enter  FirstName: ");
            contact.FirstName = Console.ReadLine();
            Console.Write("Enter  LastName: ");
            contact.LastName = Console.ReadLine();
            Console.Write("Enter  Address: ");
            contact.Address = Console.ReadLine();
            Console.Write("Enter  City: ");
            contact.City = Console.ReadLine();
            Console.Write("Enter  State: ");
            contact.State = Console.ReadLine();
            Console.Write("Enter  Zip: ");
            contact.Zip = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter  PhoneNumber: ");
            contact.PhoneNumber = Console.ReadLine();
            Console.Write("Enter  Email:\n ");
            contact.Email = Console.ReadLine();

            AddressMain addressMain = new AddressMain();
            addressMain.AddContact();
        }
    }
}