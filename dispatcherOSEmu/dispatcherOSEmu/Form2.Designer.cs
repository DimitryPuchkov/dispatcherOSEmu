﻿
namespace dispatcherOSEmu
{
   partial class Form2
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
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
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.textBox2 = new System.Windows.Forms.TextBox();
         this.textBox3 = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.button1 = new System.Windows.Forms.Button();
         this.label2 = new System.Windows.Forms.Label();
         this.button2 = new System.Windows.Forms.Button();
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.button3 = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(12, 12);
         this.textBox1.Multiline = true;
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(308, 394);
         this.textBox1.TabIndex = 0;
         // 
         // textBox2
         // 
         this.textBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
         this.textBox2.Location = new System.Drawing.Point(382, 32);
         this.textBox2.Name = "textBox2";
         this.textBox2.Size = new System.Drawing.Size(218, 25);
         this.textBox2.TabIndex = 1;
         // 
         // textBox3
         // 
         this.textBox3.Location = new System.Drawing.Point(383, 103);
         this.textBox3.Name = "textBox3";
         this.textBox3.Size = new System.Drawing.Size(218, 25);
         this.textBox3.TabIndex = 2;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
         this.label1.Location = new System.Drawing.Point(382, 12);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(91, 17);
         this.label1.TabIndex = 3;
         this.label1.Text = " Имя задачи:";
         // 
         // button1
         // 
         this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.button1.Location = new System.Drawing.Point(382, 159);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(219, 42);
         this.button1.TabIndex = 5;
         this.button1.Text = "Добавить задачу в список";
         this.button1.UseVisualStyleBackColor = true;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
         this.label2.Location = new System.Drawing.Point(383, 83);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(149, 17);
         this.label2.TabIndex = 7;
         this.label2.Text = "Длительность задачи:";
         // 
         // button2
         // 
         this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.button2.Location = new System.Drawing.Point(383, 364);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(219, 42);
         this.button2.TabIndex = 8;
         this.button2.Text = "Сгенерировать список";
         this.button2.UseVisualStyleBackColor = true;
         // 
         // label4
         // 
         this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
         this.label4.Location = new System.Drawing.Point(241, 409);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(49, 17);
         this.label4.TabIndex = 9;
         this.label4.Text = "Всего:";
         // 
         // label3
         // 
         this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
         this.label3.Location = new System.Drawing.Point(282, 409);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(38, 17);
         this.label3.TabIndex = 10;
         this.label3.Text = "000";
         this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.label3.Click += new System.EventHandler(this.label3_Click);
         // 
         // button3
         // 
         this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.button3.Location = new System.Drawing.Point(382, 274);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(219, 42);
         this.button3.TabIndex = 11;
         this.button3.Text = "Случайный список";
         this.button3.UseVisualStyleBackColor = true;
         // 
         // Form2
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.SystemColors.AppWorkspace;
         this.ClientSize = new System.Drawing.Size(745, 450);
         this.Controls.Add(this.button3);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.textBox3);
         this.Controls.Add(this.textBox2);
         this.Controls.Add(this.textBox1);
         this.Name = "Form2";
         this.Text = "Добавление задач";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.TextBox textBox2;
      private System.Windows.Forms.TextBox textBox3;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Button button3;
   }
}