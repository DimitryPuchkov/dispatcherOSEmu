using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace dispatcherOSEmu
{
    public partial class Form2 : Form
    {
        private const int MAX_TASK_NAME_LENGTH = 10;
        private const int MAX_TASK_TIME_LIMIT = 60;
        private const int MIN_TASK_TIME_LIMIT = 1;
        private const int MIN_RANDOM_TASKS_COUNT = 2;
        private const int MAX_TASKS_COUNT = 20;

        private Dictionary<string, int> tasks = new Dictionary<string, int>();
        public Dictionary<string, int> getTasks() => tasks;
        public Form2()
        {
            InitializeComponent();
            printFirstLine();
            textBox1.AppendText(Environment.NewLine);
        }

        private void label3_Click(object sender, EventArgs e) { }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            this.Close();
        }


        /**
         * Display generated random tasks
         */
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            printFirstLine();
            textBox1.AppendText(Environment.NewLine);

            generateRandomTasks();

            addTasksText();
        }

        /**
         * Generate random tasks. All previous tasks will be deleted
         */
        public void generateRandomTasks()
        {
            tasks.Clear();

            Random rnd = new Random();

            int tasksCount = rnd.Next(MIN_RANDOM_TASKS_COUNT, MAX_TASKS_COUNT);
            string taskName = "";
            int taskTime = 0;

            for (int i = 0; i < tasksCount; i++)
            {
                taskName = String.Format("Task {0}", i);
                taskTime = rnd.Next(MIN_TASK_TIME_LIMIT, MAX_TASK_TIME_LIMIT);

                tasks.Add(taskName, taskTime);
            }

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


            /**
            *  Validate, if textBox3 time is lower than minimum allowed 
            */
            if (int.Parse(textBox3.Text) < MIN_TASK_TIME_LIMIT)
            {
                MessageBox.Show("Task time is too small", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (tasks.Count > MAX_TASKS_COUNT)
            {
                MessageBox.Show("There are too much tasks", "Error", MessageBoxButtons.OK);
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

        private void addTasksText()
        {
            foreach (var task in tasks)
            {
                textBox1.AppendText(String.Format("{0,-20}{1,-20}", task.Key, task.Value));
                textBox1.AppendText(Environment.NewLine);

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (!validateInput())
            {
                return;
            }

            tasks.Add(textBox2.Text, int.Parse(textBox3.Text));
            addTaskText();
            textBox1.AppendText(Environment.NewLine);

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
