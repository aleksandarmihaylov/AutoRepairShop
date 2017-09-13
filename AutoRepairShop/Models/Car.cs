using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRepairShop.Models
{
    public class Car
    {
        public string Licenseplate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string MyProperty { get; set; }
        public string Color { get; set; }
        private Customer customer;
        private List<Repair> repairs;

        public Car(Customer Customer)
        {
            customer = Customer;
            repairs = new List<Repair>();
        }

        public void AddRepair(Repair repair)
        {
            if(repair.car!= null)
            {
                repairs.Add(repair);
            }
        }

        public Repair FindRepair(int Id)
        {
            foreach (Repair myFoundRrepair in repairs)
            {
                if(myFoundRrepair.id == Id)
                {
                    return myFoundRrepair;

                }
            }
            return null;
        }

        /// <summary>
        /// Finding the customer owning that car
        /// </summary>
        /// <param name="Customer"></param>
        /// <returns></returns>
        public Customer FindCustomer(Customer Customer)
        {
            return Customer;
        }
    }
}
