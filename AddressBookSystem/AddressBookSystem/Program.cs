using AddressBookSystem;

namespace AddressBookSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book:- ");

           
            Contact contact = new Contact();
            {
                Console.WriteLine("Enter contact Details:- ");
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
                Console.Write("Enter  Email: ");
                contact.Email = Console.ReadLine();
            }
            Console.WriteLine(contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.City + "\n" + contact.State + "\n" + contact.Zip + "\n" + contact.PhoneNumber + "\n" + contact.Email);
        }
    }
}
