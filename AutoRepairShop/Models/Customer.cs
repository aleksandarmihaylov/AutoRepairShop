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
        private List<Invoice> invoices;
        private List<Car> cars;

        public Customer(int Id,string Phone) : base(Id, Phone)
        {
            invoices = new List<Invoice>();
            cars = new List<Car>();
        }

        /// <summary>
        /// Adding an Invoice to the list/customer 
        /// </summary>
        /// <param name="invoice"></param>
        public void AddInvoice(Invoice invoice)
        {
            invoices.Add(invoice);
        }

        public Invoice FindInvoice(int id)
        {
            foreach (Invoice myFoundInvoice in invoices)
            {
                if(myFoundInvoice.Id == id)
                {
                    return myFoundInvoice;
                }
            }
            return null;
        }

        /// <summary>
        /// Adding and finding a Car to the customer
        /// </summary>
        /// <param name="car"></param>
        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        public Car FindCar(string licensplate)
        {
            foreach(Car myFoundCar in cars)
            {
                if(myFoundCar.Licenseplate == licensplate)
                {
                    return myFoundCar;
                }
            }
            return null;
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
