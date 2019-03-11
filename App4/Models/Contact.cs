namespace App4.Models
{
    public class Contact
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Contact(string name, string email, string pohoneNumber)
        {
            Name = name;
            Email = email;
            PhoneNumber = pohoneNumber;
        }
    }
}