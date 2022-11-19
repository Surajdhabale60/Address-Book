namespace AddressBookSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book:- \n");

            Contact contact = new Contact();
            {
                Console.WriteLine("Enter Contact Details:- ");
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
            }
            Console.WriteLine(contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.City + "\n" + contact.State + "\n" + contact.Zip + "\n" + contact.PhoneNumber + "\n" + contact.Email);

            AddressMain addressMain = new AddressMain();
            //addressMain.CreateContact();
            //addressMain.EditContact(edit);
            addressMain.DeleteContact("FirstName");


        }
    }
}