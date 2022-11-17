using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressMain
    {
        Contact contact = new Contact();
        public void AddContact()
        {
            Console.WriteLine("Add New Contact Details:- ");
            Console.Write("Enter  First Name: ");
            contact.FirstName = Console.ReadLine();
            Console.Write("Enter  Last Name: ");
            contact.LastName = Console.ReadLine();
            Console.Write("Enter  Address: ");
            contact.Address = Console.ReadLine();
            Console.Write("Enter  City: ");
            contact.City = Console.ReadLine();
            Console.Write("Enter  State: ");
            contact.State = Console.ReadLine();
            Console.Write("Enter  Zip: ");
            contact.Zip = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter  Phone Number: ");
            contact.PhoneNumber = Console.ReadLine();
            Console.Write("Enter  Email: ");
            contact.Email = Console.ReadLine();
        }
        public void Display()
        {
            Console.WriteLine(contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.City + "\n" + contact.State + "\n" + contact.Zip + "\n" + contact.PhoneNumber + "\n" + contact.Email);
        }
    }
}
