using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoservice.Models
{
    public  class Worker
    {
        public int Id { get; set; }
        public Customer CurrentCustomer { get; set; }

        public Worker(int id)
        {
            Id = id;
            CurrentCustomer = null;
        }

        public double CalculateServiceCompletionTime(Random random, double serviceRate)
        {
            return -Math.Log(random.NextDouble()) / serviceRate;
        }
    }
}
