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
        List<Contact> address = new List<Contact>();
        Dictionary<string, List<Contact>> dictionary = new Dictionary<string, List<Contact>>();

        public void Display()
        {
            Console.WriteLine(contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.City + "\n" + contact.State + "\n" + contact.Zip + "\n" + contact.PhoneNumber + "\n" + contact.Email);
        }
        public void CreateContact()
        {
            Console.WriteLine("Add Contact Details:- ");
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
            Console.Write("Enter  Email:\n ");
            contact.Email = Console.ReadLine();
            Display();
        }
        public void EditContact(string name)
        {
            CreateContact();
            foreach (var contact in address)
            {
                if ((contact.FirstName.Equals(name)) || (contact.LastName.Equals(name)))
                {

                    Console.WriteLine("1.FirstName 2.LastName 3.Address 4.City 5.State 6.Zip 7.PhoneNumber 8.Email");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            contact.FirstName = Console.ReadLine();
                            break;
                        case 2:
                            contact.LastName = Console.ReadLine();
                            break;
                        case 3:
                            contact.Address = Console.ReadLine();
                            break;
                        case 4:
                            contact.City = Console.ReadLine();
                            break;
                        case 5:
                            contact.State = Console.ReadLine();
                            break;
                        case 6:
                            contact.Zip = Convert.ToInt64(Console.ReadLine());
                            break;
                        case 7:
                            contact.PhoneNumber = Console.ReadLine();
                            break;
                        case 8:
                            contact.Email = Console.ReadLine();
                            break;
                    }
                    Display();
                }
            }
        }
        public void DeleteContact(string name)
        {
            Contact deleteContact = new Contact();
            foreach (var contact in address)
            {

                if (contact.FirstName.Equals(name) || contact.LastName.Equals(name))
                {
                    deleteContact = contact;
                }
                address.Remove(deleteContact);
            }
        }
        public void DictionaryContact()
        {
            Console.WriteLine("Enter Name To add Addressbook");
            string name = Console.ReadLine();
            AddressMain.Add(name, address);
            address = new List<Contact>();
        }
        public void DisplayDict()
        {
            foreach (var data in dictionary)
            {
                Console.WriteLine(data.Key);
                foreach (var contact in data.Value)
                {
                    Console.WriteLine(contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.City + "\n" + contact.State + "\n" + contact.Zip + "\n" + contact.PhoneNumber + "\n" + contact.Email);
                }
            }
        }

    }
}
