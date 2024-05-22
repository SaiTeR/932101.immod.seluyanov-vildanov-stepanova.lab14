using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Autoservice.Models
{
    public class WorkerManager
    {
        private int servedCustomers;
        private int workerCount;
        private List<Worker> workers;
        private CustomerGenerator customerGenerator;
        private CustomerManager customerManger = new CustomerManager();
        private double arrivalRate;
        private CustomerQueue customerQueue = new CustomerQueue();

        public WorkerManager(int workerCount, double arrivalRate)
        {
            this.arrivalRate = arrivalRate;
            this.workerCount = workerCount;

            workers = new List<Worker>();
            customerGenerator = new CustomerGenerator(arrivalRate);
            customerQueue = new CustomerQueue();

            for (int i = 0; i < workerCount; i++)
            {
                workers.Add(new Worker(i));
            }
        }

        public double CalculateNextEventTime(double curServiceTime, double serviceRate)
        {
            Random random = new Random();
            double T;

            int busyWorkers = workers.Count(w => w.CurrentCustomer != null);
            double nextServiceTime = busyWorkers > 0 ? customerGenerator.GenerateTime(serviceRate * busyWorkers) : double.MaxValue;

            if (curServiceTime < nextServiceTime)
            {
                Customer newCustomer = customerManger.CreateCustomer();
                if (busyWorkers < workerCount)
                {
                    busyWorkers++;
                    workers[FindFreeWorkerIndex()].CurrentCustomer = newCustomer;
                }
                else
                {
                    customerQueue.AddCustomerToQueue(newCustomer);
                }

                T = curServiceTime;
            }
            else
            {
                //////
                Worker worker = workers.Where(w => w.CurrentCustomer != null)
                                       .OrderBy(w => w.CalculateServiceCompletionTime(random, curServiceTime))
                                       .First();
                worker.CurrentCustomer = customerQueue.RemoveCustomerFromQueue();
                servedCustomers++;
                busyWorkers--;
                T = nextServiceTime;
            }

            return T;
        }

        private int FindFreeWorkerIndex()
        {
            return workers.FindIndex(w => w.CurrentCustomer == null);
        }

        public CustomerQueue GetQueueInfo()
        {
            return customerQueue;
        }

        public List<Worker> GetWorkers()
        {
            return new List<Worker>(workers);
        }

        public int GetServedCustomersCount()
        {
            return servedCustomers;
        }
    }
}
