using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT_1_Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAdress { get; set; }

        public User(string firstName, string lastName, string emailAdress)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            EmailAdress = emailAdress;
        }
        public override string ToString()
        {
            return $"First name: {FirstName}\nLast name: {LastName} \nEmail: {EmailAdress}\nID: {Id}";
        }
    }
}
