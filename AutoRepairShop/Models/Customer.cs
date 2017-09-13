using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRepairShop.Models
{
    public class Customer : Person
    {
        private string companyName;

        public Customer(int Id,string Phone) : base(Id, Phone)
        {

        }

        public string CompanyName
        {
            get
            {
                return companyName;
            }
            set
            {
                companyName = value;
            }
        }
    }
}
