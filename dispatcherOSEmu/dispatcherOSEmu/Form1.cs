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
      Queue<string> currentTasks = new Queue<string>();
      bool go = false;
        int maxQuantTime = 100;
        int minQuantTime = 1;

      float T;

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
           int quantTime = Int32.Parse(textBox3.Text);

            if(quantTime < minQuantTime)
            {
                MessageBox.Show("Quant time is less than minumum allowed");
                return;
            }

            if (quantTime > minQuantTime)
            {
                MessageBox.Show("Quant time is more than maximum allowed");
                return;
            }


            T = currentTasks.Count * quantTime;

         go = true;
         if (!checkBox1.Checked)
         {
            while (currentTasks.Count != 0)
            {
               int kwant = (int)(T / currentTasks.Count);
               textBox3.Text = kwant.ToString();
               progressBar1.Value = 0;
               var key = currentTasks.Dequeue();
               if (tasks[key] <= kwant) kwant = tasks[key];

               for (int i = 0; i < 10; i++)
               {
                  await Task.Delay(kwant * 100);
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
            go = false;
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
      private void button1_Click(object sender, EventArgs e)
      {
         f2.ShowDialog();
         this.tasks = f2.getTasks();
         currentTasks = new Queue<string>(tasks.Keys);
         addTasksText(this.tasks);

      }

      private void progressBar1_Click(object sender, EventArgs e)
      {

      }

      private void Form1_KeyDown(object sender, KeyEventArgs e)
      {

         
         
      }

      private void button4_Click(object sender, EventArgs e)
      {
         if (go)
            step();
      }
      async private void step()
      {
         if(currentTasks.Count != 0)
         {
            int kwant = (int)(T / currentTasks.Count);
            textBox3.Text = kwant.ToString();
            progressBar1.Value = 0;
            var key = currentTasks.Dequeue();
            if (tasks[key] <= kwant) kwant = tasks[key];

            for (int i = 0; i < 10; i++)
            {
               await Task.Delay(kwant * 10);
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

            if (currentTasks.Count == 0) go = false;

         }
      }
   }
}
