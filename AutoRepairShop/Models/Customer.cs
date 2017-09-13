using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRepairShop.Models
{
    public class Customer
    {
        private int id;
        private string firstName;
        private string lastName;
        public string fullName;
        private string address;
        private string city;
        private string zip;
        private string phone;
        private string email;

        public Customer(int Id)
        {
            id = Id;
        }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
        }

        public string FullName
        {
            get
            {
                return firstName + " " + lastName;
            }
        }

        public string Adress
        {
            get
            {
                return address;
            }
        }

        public string Zip
        {
            get
            {
                return zip;
            }
        }

        public string City
        {
            get
            {
                return city;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
        }


    }
}
