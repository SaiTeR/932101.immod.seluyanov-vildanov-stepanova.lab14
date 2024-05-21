using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoservice.Models
{
    public class CustomerGenerator
    {
        private double arrivalRate;

        public CustomerGenerator() { }

        public CustomerGenerator(double arrivalRate)
        {
            this.arrivalRate = arrivalRate;
        }

        public double GenerateTime(double l)
        {
            Random rnd = new Random();
            return -Math.Log(rnd.NextDouble()) / l;
        }
    }
}
