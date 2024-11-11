using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OtdelForms
{
    partial class AddHR_OtdelForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Отдел";
            textBox1.Size = new Size(192, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 45);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Базовый оклад";
            textBox2.Size = new Size(192, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 78);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Коэффицент";
            textBox3.Size = new Size(192, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 111);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Количество сотрудников";
            textBox4.Size = new Size(192, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(124, 144);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Компания";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(210, 12);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Вредность";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 5;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(210, 45);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "Специальность";
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 6;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(210, 78);
            textBox8.Name = "textBox8";
            textBox8.PlaceholderText = "Ген. директор";
            textBox8.Size = new Size(125, 27);
            textBox8.TabIndex = 7;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(210, 111);
            textBox9.Name = "textBox9";
            textBox9.PlaceholderText = "Тех. директор";
            textBox9.Size = new Size(125, 27);
            textBox9.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(124, 177);
            button1.Name = "button1";
            button1.Size = new Size(125, 29);
            button1.TabIndex = 9;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Add;
            // 
            // Add_HR_Otdel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 217);
            Controls.Add(button1);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Add_HR_Otdel";
            Text = "Добавление HR_Отдела";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private Button button1;
    }
}