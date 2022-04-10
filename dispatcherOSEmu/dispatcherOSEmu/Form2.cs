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
      private Dictionary<string, int> tasks = new Dictionary<string, int>();
      public Dictionary<string, int> getTasks() => tasks;
      public Form2()
      {
         InitializeComponent();
      }

      private void label3_Click(object sender, EventArgs e)
      {

      }

      private void button2_Click(object sender, EventArgs e)
      {
         
      }

      private void button1_Click(object sender, EventArgs e)
      {
         tasks.Add(textBox2.Text, int.Parse(textBox3.Text));
         textBox1.Text += textBox2.Text + " " + textBox3.Text;
      }
   }
}
