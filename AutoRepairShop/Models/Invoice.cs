using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRepairShop.Models
{
    public class Invoice
    {
        private int id;
        private int invoiceId;
        private string description;
        private Customer customer;

        public Invoice(int Id, Customer Customer)
        {
            id = Id;
            customer = Customer;
        }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public int NewInvoice
        {
            get
            {
                return invoiceId;
            }
            set
            {
                invoiceId = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
    }
}
