using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRepairShop.Models
{
    class Employe
    {
        private int id;
        private string firstName;
        private string lastName;
        private string address;
        private string zip;
        private string city;
        private string phone;
        private string email;
        private string position;

        public Employe (int Id)
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
    }
}
