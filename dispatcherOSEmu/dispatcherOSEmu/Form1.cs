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

namespace dispatcherOSEmu
{

    public partial class Form1 : Form
   {
      Form2 f2 = new Form2();
      //Timer t1 = new Timer();
        private Dictionary<string, int> tasks = new Dictionary<string, int>();

        int progressBarMaxValue = 100;
        int additionalDelay = 2000;

        public Form1()
        {
         InitializeComponent();


        }

        /**
         *  Начать обработку рчереди
         *  button2 = "Начать выполнение"
         */
        private async void button2Click(object sender, EventArgs e)
        {
            Queue<string> currentTasks = new Queue<string>(tasks.Keys);
            float T = currentTasks.Count * Int32.Parse(textBox3.Text);
            while(currentTasks.Count != 0)
            {
                int kwant =  (int) (T / currentTasks.Count);
                textBox3.Text = kwant.ToString();
                progressBar1.Value = 0;
                var key = currentTasks.Dequeue();
                if (tasks[key] <= kwant) kwant = tasks[key];

                for (int i = 0; i < 10; i++)
                {
                    await Task.Delay(kwant*100);
                    progressBar1.PerformStep();
                }



                tasks[key] -= kwant;

                if (tasks[key] > 0) currentTasks.Enqueue(key);
                else
                {
                    tasks.Remove(key);
                    textBox2.AppendText(key);
                }

                addTasksText(this.tasks);
                
             
            }

            //foreach (var task in f2.getTasks())
            //{
            //    MessageBox.Show("Начало выполнения " + task.Key);
            //    progressBar1.Value = 0;
            //    t1.Enabled = true;
            //    t1.Start();
            //    t1.Interval = task.Value * 10;
            //    progressBar1.Maximum = progressBarMaxValue;
            //    t1.Tick += new EventHandler(timer1_Tick);

            //    await Task.Delay(task.Value * 1000 + additionalDelay);
            //}
        }

        /*
         * Таймер для progressBar
         */
        private void timer1_Tick(object sender, EventArgs e)
        {
                if (progressBar1.Value != progressBarMaxValue)
                {
                progressBar1.Value += 1;
                }
                else
                {
                    //t1.Stop();
                }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      private void label5_Click(object sender, EventArgs e)
      {

      }

      private void label6_Click(object sender, EventArgs e)
      {

      }

      private void panel1_Paint(object sender, PaintEventArgs e)
      {

      }

        /*private void addTaskText()
        {
            textBox1.AppendText(String.Format("{0,-20}{1,-20}", textBox2.Text, textBox3.Text));
        }*/

        private void addTasksText(Dictionary<string, int> tasks)
        {
            textBox1.Text = "";

            foreach (var task in tasks)
            {
                textBox1.AppendText(String.Format("{0,-20}{1,-20}", task.Key, task.Value));
                textBox1.AppendText(Environment.NewLine);

            }
        }

        /**
         * Генерацмя списка 
         * button1 = сгенерировать список
         */
        private async void button1_Click(object sender, EventArgs e)
      {
           f2.ShowDialog();
           this.tasks = f2.getTasks();
            addTasksText(this.tasks);
          
        }



      


    }
}
