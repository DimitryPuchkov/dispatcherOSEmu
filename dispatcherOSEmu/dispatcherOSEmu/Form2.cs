using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dispatcherOSEmu
{
   //TODO Egor: all you work should be in another branch
   // improve button1_Click:
   /*
    * add examination on correct input
    * if input is not correct show message: enter all fields, data is not valid, this task name exist ( for other cases)
    * 
    */
   //
   //implement format output tasks dictionary into textBox1:
   /*
    * example output:
    * Name      Time left
    * -------------------
    * Task1        10
    * Task2       100
    * Taskkdafa    5
    * 
    * 
    */
   public partial class Form2 : Form
   {
      private const int MAX_TASK_NAME_LENGTH = 10;
      private const int MAX_TASK_TIME_LIMIT = 60;

      private Dictionary<string, int> tasks = new Dictionary<string, int>();
      public Dictionary<string, int> getTasks() => tasks;
      public Form2()
      {
         InitializeComponent();
         printFirstLine();
         textBox1.AppendText(Environment.NewLine);
      }

      private void label3_Click(object sender, EventArgs e)
      {

      }

      private void button2_Click(object sender, EventArgs e)
      {
         
      }

      /**
       * Validate input data 
       */
      private bool validateInput()
      {
         int i = 0;


         /**
         * Validate empty input data
         */
         if (String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text))
         {
            MessageBox.Show("enter all fields, data is not valid", "Error", MessageBoxButtons.OK);
            return false;
         }

         /**
         * Validate incorrect textBox3 integer type
         */
         if (!int.TryParse(textBox3.Text, out i))
         {
            MessageBox.Show("Incorrect integer value!", "Error", MessageBoxButtons.OK);
            return false;
         }


         /**
          *  Validate, if task with the same name already exist
          */
         if (getTasks().ContainsKey(textBox2.Text))
         {
            MessageBox.Show("Task with the same name already exists", "Error", MessageBoxButtons.OK);
            return false;
         }

         /**
          *  Validate, if textBox1 text length is allowed
          */
         if (textBox2.TextLength > MAX_TASK_NAME_LENGTH)
         {
            MessageBox.Show("Task name length is too long", "Error", MessageBoxButtons.OK);
            return false;
         }

         /**
          *  Validate, if textBox3 time is greater than maximum allowed 
          */
         if (int.Parse(textBox3.Text) > MAX_TASK_TIME_LIMIT)
         {
            MessageBox.Show("Task time is too long", "Error", MessageBoxButtons.OK);
            return false;
         }

         return true;

      }


      private void printFirstLine()
      {
         textBox1.AppendText(String.Format("{0,0} {1, 15}", "Name", "Time Left"));
         textBox1.AppendText(Environment.NewLine);
         textBox1.AppendText("----------------------");
      }

      private void addTaskText()
      { 
         textBox1.AppendText(String.Format("{0,-20}{1,-20}", textBox2.Text, textBox3.Text));
      }


      private void button1_Click(object sender, EventArgs e)
      {
        
         if(!validateInput())
         {
            return;
         }


         tasks.Add(textBox2.Text, int.Parse(textBox3.Text));
         addTaskText();
         textBox1.AppendText(Environment.NewLine);

      }
   }
}
