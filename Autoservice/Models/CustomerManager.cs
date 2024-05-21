using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoservice.Models
{
    public class CustomerManager
    {
        private List<Customer> customers = new List<Customer>();
        private int nextCustomerId = 0;

        public Customer CreateCustomer()
        {
            nextCustomerId++;

            Customer customer = new Customer(nextCustomerId);
            customers.Add(customer);

            return customer;
        }

        public int Count => customers.Count;
    }
}
