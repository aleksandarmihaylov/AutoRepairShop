using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRepairShop.Models
{
    public class Employee
    {
        private int id;
        private string ssn;
        private string firstName;
        private string lastName;
        private string address;
        private string zip;
        private string city;
        private string phone;
        private string email;
        private string position;

        public Employee (int Id)
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

        public string Ssn
        {
            get
            {
                return ssn;
            }
            set
            {
                ssn = value;
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

        public string FullName
        {
            get
            {
                return firstName + " " + lastName;
            }
        }

        public string Address
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

        public  string Phone
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
        public string Position
        {
            get
            {
                return position;
            }
            set
            {
                position = value;
            }
        }
    }
}
