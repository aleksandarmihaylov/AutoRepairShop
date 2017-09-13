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
        private string address;
        private string city;
        private string zip;
        private string phone;
        private string email;

        public Customer(int Id,string Phone)
        {
            id = Id;
            phone = Phone;
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
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string fullName
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
            set
            {
                address = value;
            }
        }

        public string Zip
        {
            get
            {
                return zip;
            }
            set
            {
                zip = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }


    }
}
