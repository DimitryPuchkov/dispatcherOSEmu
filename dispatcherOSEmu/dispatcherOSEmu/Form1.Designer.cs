
namespace dispatcherOSEmu
{
   partial class Form1
   {
      /// <summary>
      ///  Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      ///  Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.textBox2 = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.progressBar6 = new System.Windows.Forms.ProgressBar();
         this.progressBar5 = new System.Windows.Forms.ProgressBar();
         this.progressBar4 = new System.Windows.Forms.ProgressBar();
         this.progressBar3 = new System.Windows.Forms.ProgressBar();
         this.progressBar2 = new System.Windows.Forms.ProgressBar();
         this.progressBar1 = new System.Windows.Forms.ProgressBar();
         this.button1 = new System.Windows.Forms.Button();
         this.button2 = new System.Windows.Forms.Button();
         this.button3 = new System.Windows.Forms.Button();
         this.textBox3 = new System.Windows.Forms.TextBox();
         this.label7 = new System.Windows.Forms.Label();
         this.checkBox1 = new System.Windows.Forms.CheckBox();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(12, 53);
         this.textBox1.Multiline = true;
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(242, 336);
         this.textBox1.TabIndex = 1;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
         this.label1.Location = new System.Drawing.Point(12, 33);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(128, 17);
         this.label1.TabIndex = 4;
         this.label1.Text = " Активные задачи:";
         // 
         // textBox2
         // 
         this.textBox2.Location = new System.Drawing.Point(765, 53);
         this.textBox2.Multiline = true;
         this.textBox2.Name = "textBox2";
         this.textBox2.Size = new System.Drawing.Size(242, 336);
         this.textBox2.TabIndex = 5;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
         this.label2.Location = new System.Drawing.Point(765, 33);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(156, 17);
         this.label2.TabIndex = 6;
         this.label2.Text = " Выполненные задачи:";
         // 
         // label3
         // 
         this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
         this.label3.Location = new System.Drawing.Point(216, 392);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(38, 17);
         this.label3.TabIndex = 12;
         this.label3.Text = "000";
         this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // label4
         // 
         this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
         this.label4.Location = new System.Drawing.Point(161, 392);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(49, 17);
         this.label4.TabIndex = 11;
         this.label4.Text = "Всего:";
         // 
         // label5
         // 
         this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
         this.label5.Location = new System.Drawing.Point(969, 392);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(38, 17);
         this.label5.TabIndex = 14;
         this.label5.Text = "000";
         this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.label5.Click += new System.EventHandler(this.label5_Click);
         // 
         // label6
         // 
         this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
         this.label6.Location = new System.Drawing.Point(914, 392);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(49, 17);
         this.label6.TabIndex = 13;
         this.label6.Text = "Всего:";
         this.label6.Click += new System.EventHandler(this.label6_Click);
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.progressBar6);
         this.groupBox1.Controls.Add(this.progressBar5);
         this.groupBox1.Controls.Add(this.progressBar4);
         this.groupBox1.Controls.Add(this.progressBar3);
         this.groupBox1.Controls.Add(this.progressBar2);
         this.groupBox1.Controls.Add(this.progressBar1);
         this.groupBox1.Location = new System.Drawing.Point(394, 53);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(254, 336);
         this.groupBox1.TabIndex = 16;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Процессор";
         // 
         // progressBar6
         // 
         this.progressBar6.Location = new System.Drawing.Point(6, 229);
         this.progressBar6.Name = "progressBar6";
         this.progressBar6.Size = new System.Drawing.Size(242, 35);
         this.progressBar6.TabIndex = 5;
         // 
         // progressBar5
         // 
         this.progressBar5.Location = new System.Drawing.Point(6, 188);
         this.progressBar5.Name = "progressBar5";
         this.progressBar5.Size = new System.Drawing.Size(242, 35);
         this.progressBar5.TabIndex = 4;
         // 
         // progressBar4
         // 
         this.progressBar4.Location = new System.Drawing.Point(6, 147);
         this.progressBar4.Name = "progressBar4";
         this.progressBar4.Size = new System.Drawing.Size(242, 35);
         this.progressBar4.TabIndex = 3;
         // 
         // progressBar3
         // 
         this.progressBar3.Location = new System.Drawing.Point(6, 106);
         this.progressBar3.Name = "progressBar3";
         this.progressBar3.Size = new System.Drawing.Size(242, 35);
         this.progressBar3.TabIndex = 2;
         // 
         // progressBar2
         // 
         this.progressBar2.Location = new System.Drawing.Point(6, 65);
         this.progressBar2.Name = "progressBar2";
         this.progressBar2.Size = new System.Drawing.Size(242, 35);
         this.progressBar2.TabIndex = 1;
         // 
         // progressBar1
         // 
         this.progressBar1.Location = new System.Drawing.Point(6, 24);
         this.progressBar1.Name = "progressBar1";
         this.progressBar1.Size = new System.Drawing.Size(242, 35);
         this.progressBar1.TabIndex = 0;
         // 
         // button1
         // 
         this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.button1.Location = new System.Drawing.Point(12, 469);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(242, 42);
         this.button1.TabIndex = 17;
         this.button1.Text = "Сгенерировать задачи";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // button2
         // 
         this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.button2.Location = new System.Drawing.Point(394, 469);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(254, 42);
         this.button2.TabIndex = 18;
         this.button2.Text = "Начать выполнение";
         this.button2.UseVisualStyleBackColor = true;
         // 
         // button3
         // 
         this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.button3.Location = new System.Drawing.Point(765, 469);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(242, 42);
         this.button3.TabIndex = 19;
         this.button3.Text = "Очистить все";
         this.button3.UseVisualStyleBackColor = true;
         // 
         // textBox3
         // 
         this.textBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
         this.textBox3.Location = new System.Drawing.Point(575, 423);
         this.textBox3.Name = "textBox3";
         this.textBox3.Size = new System.Drawing.Size(73, 25);
         this.textBox3.TabIndex = 20;
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
         this.label7.Location = new System.Drawing.Point(444, 426);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(109, 17);
         this.label7.TabIndex = 21;
         this.label7.Text = "Квант времени:";
         // 
         // checkBox1
         // 
         this.checkBox1.AutoSize = true;
         this.checkBox1.Location = new System.Drawing.Point(446, 517);
         this.checkBox1.Name = "checkBox1";
         this.checkBox1.Size = new System.Drawing.Size(202, 21);
         this.checkBox1.TabIndex = 22;
         this.checkBox1.Text = "Выполнять в ручном режиме";
         this.checkBox1.UseVisualStyleBackColor = true;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.SystemColors.AppWorkspace;
         this.ClientSize = new System.Drawing.Size(1019, 563);
         this.Controls.Add(this.checkBox1);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.textBox3);
         this.Controls.Add(this.button3);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.textBox2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.textBox1);
         this.Name = "Form1";
         this.Text = "Эмулятор диспетчера ОС";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.groupBox1.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox textBox2;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.Button button3;
      private System.Windows.Forms.TextBox textBox3;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.CheckBox checkBox1;
      private System.Windows.Forms.ProgressBar progressBar6;
      private System.Windows.Forms.ProgressBar progressBar5;
      private System.Windows.Forms.ProgressBar progressBar4;
      private System.Windows.Forms.ProgressBar progressBar3;
      private System.Windows.Forms.ProgressBar progressBar2;
      private System.Windows.Forms.ProgressBar progressBar1;
   }
}

