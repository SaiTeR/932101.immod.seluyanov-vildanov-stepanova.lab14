using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoservice.Models
{
    public class CustomerQueue
    {
        private List<Customer> queue = new List<Customer>();
        public int Count => queue.Count;


        public void AddCustomerToQueue(Customer customer)
        {
            queue.Add(customer);
        }

        public Customer RemoveCustomerFromQueue()
        {
            if (queue.Count > 0)
            {
                Customer firstCustomer = queue[0];
                queue.RemoveAt(0);
                return firstCustomer;
            }
            return null;
        }
    }
}
