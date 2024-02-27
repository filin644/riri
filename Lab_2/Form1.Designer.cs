namespace Lab_2
{
	partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.суммаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sum1_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sum2_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.количествоКратныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiples1_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiples2_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сложениеМассивовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вычитаниеМассивовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вариант1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sort1_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sort2_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.file_radioButton = new System.Windows.Forms.RadioButton();
            this.manual_radioButton = new System.Windows.Forms.RadioButton();
            this.random_radioButton = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 111);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(281, 224);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView_EditingControlShowing);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.суммаToolStripMenuItem,
            this.количествоКратныхToolStripMenuItem,
            this.сложениеМассивовToolStripMenuItem,
            this.вычитаниеМассивовToolStripMenuItem,
            this.вариант1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(586, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // суммаToolStripMenuItem
            // 
            this.суммаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sum1_ToolStripMenuItem,
            this.sum2_ToolStripMenuItem});
            this.суммаToolStripMenuItem.Name = "суммаToolStripMenuItem";
            this.суммаToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.суммаToolStripMenuItem.Text = "Сумма элементов";
            // 
            // sum1_ToolStripMenuItem
            // 
            this.sum1_ToolStripMenuItem.Name = "sum1_ToolStripMenuItem";
            this.sum1_ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.sum1_ToolStripMenuItem.Text = "Таблица 1";
            this.sum1_ToolStripMenuItem.Click += new System.EventHandler(this.sum1_ToolStripMenuItem_Click);
            // 
            // sum2_ToolStripMenuItem
            // 
            this.sum2_ToolStripMenuItem.Name = "sum2_ToolStripMenuItem";
            this.sum2_ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.sum2_ToolStripMenuItem.Text = "Таблица 2";
            this.sum2_ToolStripMenuItem.Click += new System.EventHandler(this.sum2_ToolStripMenuItem_Click);
            // 
            // количествоКратныхToolStripMenuItem
            // 
            this.количествоКратныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.multiples1_ToolStripMenuItem,
            this.multiples2_ToolStripMenuItem});
            this.количествоКратныхToolStripMenuItem.Name = "количествоКратныхToolStripMenuItem";
            this.количествоКратныхToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.количествоКратныхToolStripMenuItem.Text = "Количество кратных";
            // 
            // multiples1_ToolStripMenuItem
            // 
            this.multiples1_ToolStripMenuItem.Name = "multiples1_ToolStripMenuItem";
            this.multiples1_ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.multiples1_ToolStripMenuItem.Text = "Таблица 1";
            this.multiples1_ToolStripMenuItem.Click += new System.EventHandler(this.multiples1_ToolStripMenuItem_Click);
            // 
            // multiples2_ToolStripMenuItem
            // 
            this.multiples2_ToolStripMenuItem.Name = "multiples2_ToolStripMenuItem";
            this.multiples2_ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.multiples2_ToolStripMenuItem.Text = "Таблица 2";
            this.multiples2_ToolStripMenuItem.Click += new System.EventHandler(this.multiples2_ToolStripMenuItem_Click);
            // 
            // сложениеМассивовToolStripMenuItem
            // 
            this.сложениеМассивовToolStripMenuItem.Name = "сложениеМассивовToolStripMenuItem";
            this.сложениеМассивовToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.сложениеМассивовToolStripMenuItem.Text = "Сложение массивов";
            this.сложениеМассивовToolStripMenuItem.Click += new System.EventHandler(this.сложениеМассивовToolStripMenuItem_Click);
            // 
            // вычитаниеМассивовToolStripMenuItem
            // 
            this.вычитаниеМассивовToolStripMenuItem.Name = "вычитаниеМассивовToolStripMenuItem";
            this.вычитаниеМассивовToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.вычитаниеМассивовToolStripMenuItem.Text = "Вычитание массивов";
            this.вычитаниеМассивовToolStripMenuItem.Click += new System.EventHandler(this.вычитаниеМассивовToolStripMenuItem_Click);
            // 
            // вариант1ToolStripMenuItem
            // 
            this.вариант1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sort1_ToolStripMenuItem,
            this.sort2_ToolStripMenuItem});
            this.вариант1ToolStripMenuItem.Name = "вариант1ToolStripMenuItem";
            this.вариант1ToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.вариант1ToolStripMenuItem.Text = "Вариант 1";
            // 
            // sort1_ToolStripMenuItem
            // 
            this.sort1_ToolStripMenuItem.Name = "sort1_ToolStripMenuItem";
            this.sort1_ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.sort1_ToolStripMenuItem.Text = "Таблица 1";
            this.sort1_ToolStripMenuItem.Click += new System.EventHandler(this.sort1_ToolStripMenuItem_Click);
            // 
            // sort2_ToolStripMenuItem
            // 
            this.sort2_ToolStripMenuItem.Name = "sort2_ToolStripMenuItem";
            this.sort2_ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.sort2_ToolStripMenuItem.Text = "Таблица 2";
            this.sort2_ToolStripMenuItem.Click += new System.EventHandler(this.sort2_ToolStripMenuItem_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(296, 111);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView2.Size = new System.Drawing.Size(281, 224);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView_EditingControlShowing);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.file_radioButton);
            this.groupBox1.Controls.Add(this.manual_radioButton);
            this.groupBox1.Controls.Add(this.random_radioButton);
            this.groupBox1.Location = new System.Drawing.Point(153, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(281, 81);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Способ заполнения";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 58);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 19);
            this.button2.TabIndex = 4;
            this.button2.Text = "Таблица 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 19);
            this.button1.TabIndex = 3;
            this.button1.Text = "Таблица 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // file_radioButton
            // 
            this.file_radioButton.AutoSize = true;
            this.file_radioButton.Location = new System.Drawing.Point(4, 59);
            this.file_radioButton.Margin = new System.Windows.Forms.Padding(2);
            this.file_radioButton.Name = "file_radioButton";
            this.file_radioButton.Size = new System.Drawing.Size(132, 17);
            this.file_radioButton.TabIndex = 2;
            this.file_radioButton.Text = "из текстового файла";
            this.file_radioButton.UseVisualStyleBackColor = true;
            // 
            // manual_radioButton
            // 
            this.manual_radioButton.AutoSize = true;
            this.manual_radioButton.Checked = true;
            this.manual_radioButton.Location = new System.Drawing.Point(4, 17);
            this.manual_radioButton.Margin = new System.Windows.Forms.Padding(2);
            this.manual_radioButton.Name = "manual_radioButton";
            this.manual_radioButton.Size = new System.Drawing.Size(66, 17);
            this.manual_radioButton.TabIndex = 1;
            this.manual_radioButton.TabStop = true;
            this.manual_radioButton.Text = "вручную";
            this.manual_radioButton.UseVisualStyleBackColor = true;
            // 
            // random_radioButton
            // 
            this.random_radioButton.AutoSize = true;
            this.random_radioButton.Location = new System.Drawing.Point(4, 38);
            this.random_radioButton.Margin = new System.Windows.Forms.Padding(2);
            this.random_radioButton.Name = "random_radioButton";
            this.random_radioButton.Size = new System.Drawing.Size(71, 17);
            this.random_radioButton.TabIndex = 0;
            this.random_radioButton.Text = "случайно";
            this.random_radioButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 340);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(344, 340);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 343);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Размер:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 343);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Размер:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Текстовые файлы(*.txt)|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 368);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Работа с массивами";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem суммаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sum1_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sum2_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem количествоКратныхToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сложениеМассивовToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem вычитаниеМассивовToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem вариант1ToolStripMenuItem;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RadioButton file_radioButton;
		private System.Windows.Forms.RadioButton manual_radioButton;
		private System.Windows.Forms.RadioButton random_radioButton;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ToolStripMenuItem multiples1_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem multiples2_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sort1_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sort2_ToolStripMenuItem;
	}
}

