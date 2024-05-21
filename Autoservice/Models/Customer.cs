using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoservice.Models
{
    public class Customer
    {
        public int Id {  get; private set; }

        public Customer(int num) 
        {
            this.Id = num;
        }
    }
}
