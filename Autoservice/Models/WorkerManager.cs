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

        private double serviceRate;

        private List<Worker> workers = new List<Worker>();
        private CustomerManager customerManger = new CustomerManager();
        private CustomerQueue customerQueue = new CustomerQueue();

        public WorkerManager(int workerCount, double serviceRate)
        {
            this.workerCount = workerCount;
            this.serviceRate = serviceRate;

            for (int i = 0; i < workerCount; i++)
            {
                workers.Add(new Worker(i));
            }
        }

        public void ServeCustomer(double customerServeTime)
        {
            Random random = new Random();

            int busyWorkers = workers.Count(w => w.CurrentCustomer != null);

            // Определение времени до следующего завершения обслуживания
            double nextServiceEndTime = busyWorkers > 0 ? ExpRandomValue.Get(this.serviceRate * busyWorkers) : double.MaxValue;

            if (customerServeTime < nextServiceEndTime)
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
            }
            else
            {
                Worker worker = workers.Where(w => w.CurrentCustomer != null) // Нахоидм работника с наименьш. временем выполнения обслуживания
                                       .OrderBy(w => w.CalculateServiceCompletionTime(random, this.serviceRate))
                                       .First();

                worker.CurrentCustomer = customerQueue.RemoveCustomerFromQueue();

                servedCustomers++;
                busyWorkers--;
            }
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
