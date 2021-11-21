using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_normal_Click(object sender, EventArgs e)
        {
            var timer = new System.Diagnostics.Stopwatch();
            timer.Start();

            dgv_data.DataSource = null;
            for (int i = 0; i < 1000000; i++)
            {
                dgv_data.Rows[i].Cells[0].Value = i.ToString();
                dgv_data.Rows[i].Cells[1].Value = "OK";
            }

            timer.Stop();

            TimeSpan timeTaken = timer.Elapsed;
            lbl_Counter.Text = "Time taken: " + timeTaken.ToString(@"m\:ss\.fff");


        }

        private void work1(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 500000; i++)
            {
                dgv_data.Rows[i].Cells[0].Value = i.ToString();
                dgv_data.Rows[i].Cells[1].Value = "OK";
            }
        }
        private void work2(object sender, DoWorkEventArgs e)
        {
            for (int i = 500000; i < 1000000; i++)
            {
                dgv_data.Rows[i].Cells[0].Value = i.ToString();
                dgv_data.Rows[i].Cells[1].Value = "OK";
            }
        }

        private async Task TaskOne()
        {
            for (int i = 0; i < 500000; i++)
            {
                dgv_data.Rows[i].Cells[0].Value = i.ToString();
                dgv_data.Rows[i].Cells[1].Value = "OK";
            }
        }

        private async Task TaskTwo()
        {
            for (int i = 500000; i < 1000000; i++)
            {
                dgv_data.Rows[i].Cells[0].Value = i.ToString();
                dgv_data.Rows[i].Cells[1].Value = "OK";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            dgv_data.RowCount = 1000000;
            dgv_data.ColumnCount = 3;
           
        }

        private void btn_Optimize_Click(object sender, EventArgs e)
        {

            var timer = new System.Diagnostics.Stopwatch();
            timer.Start();

            dgv_data.DataSource = null;
            //Parallel.Invoke
            //(
            //    () => work1(),
            //    () => work2()
            //);
            //Task t1 = Task.Run(() => work1());
            //Task t2 = Task.Run(() => work2());

            //Task.WaitAll(t1, t2);
            //Thread ta = new Thread(new ThreadStart(work1)); // create thread 2 for LoopA
            //Thread tb = new Thread(new ThreadStart(work2)); // create thread 3 for LoopB

            //ta.Start(); // Run LoopA on thread 2
            //tb.Start(); // Run LoopB on thread 3

            //// Join makes this thread wait until the thread being joined to has finished

            //ta.Join(); // wait for thread 2 to finish
            //tb.Join(); // now wait for thread 3 to finish

            var task_one = TaskOne();
            var task_two = TaskTwo();

            Task.WaitAll(task_one, task_one);

            timer.Stop();
            TimeSpan timeTaken = timer.Elapsed;
            lbl_Counter.Text = "Time taken: " + timeTaken.ToString(@"m\:ss\.fff");
        }
        private BackgroundWorker myWorker = new BackgroundWorker();
        BackgroundWorker bw = new BackgroundWorker();
        BackgroundWorker bw1 = new BackgroundWorker();
        private void btn_Other_Click(object sender, EventArgs e)
        {
            bw.WorkerSupportsCancellation = true;
            bw.WorkerReportsProgress = true;

            bw.DoWork += new DoWorkEventHandler(work1);

            bw1.WorkerSupportsCancellation = true;
            bw1.WorkerReportsProgress = true;

            bw1.DoWork += new DoWorkEventHandler(work2);
        }
    }
}
