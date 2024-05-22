using Autoservice.Models;

namespace Autoservice
{
    public partial class Form1 : Form
    {
        private double arrivalRate; // Скорость прибытия новых клиентов
        private double serviceRate; // Скорость обслуживания
        private int workerCount;    // Количество механиков

        private WorkerManager workerManager;

        public Form1()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            arrivalRate = (double)flowNumeric.Value;
            workerCount = (int)mechNumeric.Value;
            serviceRate = (double)speedNumeric.Value;

            workerManager = new WorkerManager(workerCount, serviceRate);

            timer1.Start();

            endBtn.Enabled = true;
            startBtn.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            workerManager.ServeCustomer(ExpRandomValue.Get(arrivalRate));


            CustomerQueue queue = workerManager.GetQueueInfo();

            foreach (Worker worker in workerManager.GetWorkers())
            {
                string status;
                if (worker.CurrentCustomer != null)
                    status = "Клиент " + worker.CurrentCustomer.Id;
                else
                    status = "Свободен";

                dataGridView1.Rows.Add((worker.Id + 1), status);
            }


            servedLabel.Text = workerManager.GetServedCustomersCount().ToString();
            queueLabel.Text = queue.Count.ToString();
        }

        private void endBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            endBtn.Enabled = false;
            startBtn.Enabled = true;
        }
    }
}
