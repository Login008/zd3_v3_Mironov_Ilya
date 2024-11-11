namespace OtdelForms
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
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            button3 = new Button();
            button2 = new Button();
            dataGridView2 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            удалить1ойПерегрузкойToolStripMenuItem = new ToolStripMenuItem();
            аяПерегрузкаToolStripMenuItem = new ToolStripMenuItem();
            аяПерегрузкаToolStripMenuItem1 = new ToolStripMenuItem();
            яПерегрузкаToolStripMenuItem = new ToolStripMenuItem();
            качествоОтделаToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip2 = new ContextMenuStrip(components);
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            качествоToolStripMenuItem = new ToolStripMenuItem();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            contextMenuStrip1.SuspendLayout();
            contextMenuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 393);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Отдел";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(299, 358);
            button1.Name = "button1";
            button1.Size = new Size(157, 29);
            button1.TabIndex = 1;
            button1.Text = "Добавить отдел";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AddOtdel;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(765, 352);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 393);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "HR-Отдел";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button3);
            groupBox1.Location = new Point(512, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 120);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Поиск отделов с определённой вредностью";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 48);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Вредность";
            textBox1.Size = new Size(238, 27);
            textBox1.TabIndex = 2;
            // 
            // button3
            // 
            button3.Location = new Point(76, 81);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 3;
            button3.Text = "Поиск";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Search;
            // 
            // button2
            // 
            button2.Location = new Point(560, 358);
            button2.Name = "button2";
            button2.Size = new Size(154, 29);
            button2.TabIndex = 1;
            button2.Text = "Добавить отдел";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Addition;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(3, 6);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(503, 381);
            dataGridView2.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { удалить1ойПерегрузкойToolStripMenuItem, качествоОтделаToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(193, 52);
            // 
            // удалить1ойПерегрузкойToolStripMenuItem
            // 
            удалить1ойПерегрузкойToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { аяПерегрузкаToolStripMenuItem, аяПерегрузкаToolStripMenuItem1, яПерегрузкаToolStripMenuItem });
            удалить1ойПерегрузкойToolStripMenuItem.Name = "удалить1ойПерегрузкойToolStripMenuItem";
            удалить1ойПерегрузкойToolStripMenuItem.Size = new Size(192, 24);
            удалить1ойПерегрузкойToolStripMenuItem.Text = "Удалить";
            // 
            // аяПерегрузкаToolStripMenuItem
            // 
            аяПерегрузкаToolStripMenuItem.Name = "аяПерегрузкаToolStripMenuItem";
            аяПерегрузкаToolStripMenuItem.Size = new Size(204, 26);
            аяПерегрузкаToolStripMenuItem.Text = "1-ая перегрузка";
            аяПерегрузкаToolStripMenuItem.Click += RemoveOtdel;
            // 
            // аяПерегрузкаToolStripMenuItem1
            // 
            аяПерегрузкаToolStripMenuItem1.Name = "аяПерегрузкаToolStripMenuItem1";
            аяПерегрузкаToolStripMenuItem1.Size = new Size(204, 26);
            аяПерегрузкаToolStripMenuItem1.Text = "2-ая перегрузка";
            аяПерегрузкаToolStripMenuItem1.Click += RemoveOtdel2;
            // 
            // яПерегрузкаToolStripMenuItem
            // 
            яПерегрузкаToolStripMenuItem.Name = "яПерегрузкаToolStripMenuItem";
            яПерегрузкаToolStripMenuItem.Size = new Size(204, 26);
            яПерегрузкаToolStripMenuItem.Text = "3-я перегрузка";
            яПерегрузкаToolStripMenuItem.Click += RemoveOtdel3;
            // 
            // качествоОтделаToolStripMenuItem
            // 
            качествоОтделаToolStripMenuItem.Name = "качествоОтделаToolStripMenuItem";
            качествоОтделаToolStripMenuItem.Size = new Size(192, 24);
            качествоОтделаToolStripMenuItem.Text = "Качество отдела";
            качествоОтделаToolStripMenuItem.Click += GetQ;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { удалитьToolStripMenuItem, качествоToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(142, 52);
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(141, 24);
            удалитьToolStripMenuItem.Text = "Удалить";
            удалитьToolStripMenuItem.Click += RemoveHR;
            // 
            // качествоToolStripMenuItem
            // 
            качествоToolStripMenuItem.Name = "качествоToolStripMenuItem";
            качествоToolStripMenuItem.Size = new Size(141, 24);
            качествоToolStripMenuItem.Text = "Качество";
            качествоToolStripMenuItem.Click += GetQHR;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Задание 3 вариант 3";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private TabPage tabPage2;
        private DataGridView dataGridView2;
        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem удалить1ойПерегрузкойToolStripMenuItem;
        private ToolStripMenuItem аяПерегрузкаToolStripMenuItem;
        private ToolStripMenuItem аяПерегрузкаToolStripMenuItem1;
        private ToolStripMenuItem яПерегрузкаToolStripMenuItem;
        private ToolStripMenuItem качествоОтделаToolStripMenuItem;
        private Button button3;
        private TextBox textBox1;
        private Button button2;
        private GroupBox groupBox1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem качествоToolStripMenuItem;
    }
}
