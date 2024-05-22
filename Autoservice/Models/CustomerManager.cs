using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoservice.Models
{
    public class CustomerManager
    {
        private int nextCustomerId = 0; // Ведет посчет номеров клиентов

        public Customer CreateCustomer()
        {
            nextCustomerId++;
            Customer customer = new Customer(nextCustomerId);

            return customer;
        }
    }
}
