namespace OtdelForms
{
    partial class AddOtdelForm
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(35, 15);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Название отдела";
            textBox1.Size = new Size(232, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(35, 48);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Базовый оклад";
            textBox2.Size = new Size(232, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(35, 81);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Коэффицент";
            textBox3.Size = new Size(232, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(35, 114);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Количество сотрудников";
            textBox4.Size = new Size(232, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(35, 147);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Название компании";
            textBox5.Size = new Size(232, 27);
            textBox5.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(35, 206);
            button1.Name = "button1";
            button1.Size = new Size(232, 29);
            button1.TabIndex = 5;
            button1.Text = "Добавить 1-ой перегрузкой";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AddOtdel;
            // 
            // button2
            // 
            button2.Location = new Point(35, 241);
            button2.Name = "button2";
            button2.Size = new Size(232, 29);
            button2.TabIndex = 6;
            button2.Text = "Добавить 2-ой перегрузкой";
            button2.UseVisualStyleBackColor = true;
            button2.Click += AddOtdel2;
            // 
            // button3
            // 
            button3.Location = new Point(35, 276);
            button3.Name = "button3";
            button3.Size = new Size(232, 29);
            button3.TabIndex = 7;
            button3.Text = "Добавить 3-ей перегрузкой";
            button3.UseVisualStyleBackColor = true;
            button3.Click += AddOtdel3;
            // 
            // AddOtdelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 314);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "AddOtdelForm";
            Text = "Добавление отдела";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}