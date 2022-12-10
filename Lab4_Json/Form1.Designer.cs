namespace Lab4_Json
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відкритиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблиця1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jsonToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.таблиця2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.jsonToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблиця1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблиця2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.jsonToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.readerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(560, 447);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(577, 63);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(540, 447);
            this.dataGridView2.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(10);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddButton,
            this.EditButton,
            this.DeleteButton,
            this.toolStripComboBox1,
            this.toolStripTextBox1,
            this.toolStripComboBox2,
            this.toolStripTextBox2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 29);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1129, 34);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = false;
            this.AddButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AddButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddButton.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(30, 30);
            this.AddButton.Text = "Додати";
            this.AddButton.Click += new System.EventHandler(this.AddRowButton);
            // 
            // EditButton
            // 
            this.EditButton.AutoSize = false;
            this.EditButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EditButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.EditButton.Image = ((System.Drawing.Image)(resources.GetObject("EditButton.Image")));
            this.EditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditButton.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(30, 30);
            this.EditButton.Text = "Редагувати";
            this.EditButton.Click += new System.EventHandler(this.EditRowButton);
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSize = false;
            this.DeleteButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(0, 20, 20, 20);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(30, 30);
            this.DeleteButton.Text = "Видалити";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteRowButton);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "П.І.П. автора",
            "Назва",
            "Анотація",
            "УДК"});
            this.toolStripComboBox1.Margin = new System.Windows.Forms.Padding(65, 0, 1, 0);
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 34);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Margin = new System.Windows.Forms.Padding(10, 3, 1, 0);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(150, 30);
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBox2.Items.AddRange(new object[] {
            "П.І.П.",
            "Факультет",
            "Кафедра",
            "Посада"});
            this.toolStripComboBox2.Margin = new System.Windows.Forms.Padding(170, 0, 1, 0);
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 34);
            this.toolStripComboBox2.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox2_SelectedIndexChanged);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Margin = new System.Windows.Forms.Padding(10, 3, 1, 0);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(150, 30);
            this.toolStripTextBox2.Click += new System.EventHandler(this.toolStripTextBox2_Click);
            this.toolStripTextBox2.TextChanged += new System.EventHandler(this.toolStripTextBox2_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(67, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проПрограмуToolStripMenuItem,
            this.відкритиToolStripMenuItem,
            this.зберегтиToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            this.проПрограмуToolStripMenuItem.Click += new System.EventHandler(this.проПрограмуToolStripMenuItem_Click);
            // 
            // відкритиToolStripMenuItem
            // 
            this.відкритиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблиця1ToolStripMenuItem,
            this.таблиця2ToolStripMenuItem});
            this.відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            this.відкритиToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.відкритиToolStripMenuItem.Text = "Відкрити";
            // 
            // таблиця1ToolStripMenuItem
            // 
            this.таблиця1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtToolStripMenuItem1,
            this.jsonToolStripMenuItem1});
            this.таблиця1ToolStripMenuItem.Name = "таблиця1ToolStripMenuItem";
            this.таблиця1ToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.таблиця1ToolStripMenuItem.Text = "Таблиця 1";
            // 
            // txtToolStripMenuItem1
            // 
            this.txtToolStripMenuItem1.Name = "txtToolStripMenuItem1";
            this.txtToolStripMenuItem1.Size = new System.Drawing.Size(122, 26);
            this.txtToolStripMenuItem1.Text = ".txt";
            this.txtToolStripMenuItem1.Click += new System.EventHandler(this.txtToolStripMenuItem1_Click);
            // 
            // jsonToolStripMenuItem1
            // 
            this.jsonToolStripMenuItem1.Name = "jsonToolStripMenuItem1";
            this.jsonToolStripMenuItem1.Size = new System.Drawing.Size(122, 26);
            this.jsonToolStripMenuItem1.Text = ".json";
            this.jsonToolStripMenuItem1.Click += new System.EventHandler(this.jsonToolStripMenuItem1_Click);
            // 
            // таблиця2ToolStripMenuItem
            // 
            this.таблиця2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtToolStripMenuItem2,
            this.jsonToolStripMenuItem2});
            this.таблиця2ToolStripMenuItem.Name = "таблиця2ToolStripMenuItem";
            this.таблиця2ToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.таблиця2ToolStripMenuItem.Text = "Таблиця 2";
            // 
            // txtToolStripMenuItem2
            // 
            this.txtToolStripMenuItem2.Name = "txtToolStripMenuItem2";
            this.txtToolStripMenuItem2.Size = new System.Drawing.Size(122, 26);
            this.txtToolStripMenuItem2.Text = ".txt";
            this.txtToolStripMenuItem2.Click += new System.EventHandler(this.txtToolStripMenuItem2_Click);
            // 
            // jsonToolStripMenuItem2
            // 
            this.jsonToolStripMenuItem2.Name = "jsonToolStripMenuItem2";
            this.jsonToolStripMenuItem2.Size = new System.Drawing.Size(122, 26);
            this.jsonToolStripMenuItem2.Text = ".json";
            this.jsonToolStripMenuItem2.Click += new System.EventHandler(this.jsonToolStripMenuItem2_Click);
            // 
            // зберегтиToolStripMenuItem
            // 
            this.зберегтиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблиця1ToolStripMenuItem1,
            this.таблиця2ToolStripMenuItem1});
            this.зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            this.зберегтиToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.зберегтиToolStripMenuItem.Text = "Зберегти";
            // 
            // таблиця1ToolStripMenuItem1
            // 
            this.таблиця1ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtToolStripMenuItem,
            this.jsonToolStripMenuItem});
            this.таблиця1ToolStripMenuItem1.Name = "таблиця1ToolStripMenuItem1";
            this.таблиця1ToolStripMenuItem1.Size = new System.Drawing.Size(163, 26);
            this.таблиця1ToolStripMenuItem1.Text = "Таблиця 1";
            // 
            // txtToolStripMenuItem
            // 
            this.txtToolStripMenuItem.Name = "txtToolStripMenuItem";
            this.txtToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.txtToolStripMenuItem.Text = ".txt";
            this.txtToolStripMenuItem.Click += new System.EventHandler(this.txtToolStripMenuItem_Click_1);
            // 
            // jsonToolStripMenuItem
            // 
            this.jsonToolStripMenuItem.Name = "jsonToolStripMenuItem";
            this.jsonToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.jsonToolStripMenuItem.Text = ".json";
            this.jsonToolStripMenuItem.Click += new System.EventHandler(this.jsonToolStripMenuItem_Click);
            // 
            // таблиця2ToolStripMenuItem1
            // 
            this.таблиця2ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtToolStripMenuItem3,
            this.jsonToolStripMenuItem3});
            this.таблиця2ToolStripMenuItem1.Name = "таблиця2ToolStripMenuItem1";
            this.таблиця2ToolStripMenuItem1.Size = new System.Drawing.Size(163, 26);
            this.таблиця2ToolStripMenuItem1.Text = "Таблиця 2";
            // 
            // txtToolStripMenuItem3
            // 
            this.txtToolStripMenuItem3.Name = "txtToolStripMenuItem3";
            this.txtToolStripMenuItem3.Size = new System.Drawing.Size(122, 26);
            this.txtToolStripMenuItem3.Text = ".txt";
            this.txtToolStripMenuItem3.Click += new System.EventHandler(this.txtToolStripMenuItem3_Click);
            // 
            // jsonToolStripMenuItem3
            // 
            this.jsonToolStripMenuItem3.Name = "jsonToolStripMenuItem3";
            this.jsonToolStripMenuItem3.Size = new System.Drawing.Size(122, 26);
            this.jsonToolStripMenuItem3.Text = ".json";
            this.jsonToolStripMenuItem3.Click += new System.EventHandler(this.jsonToolStripMenuItem3_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 63);
            this.panel1.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(Lab4_Json.Book);
            // 
            // readerBindingSource
            // 
            this.readerBindingSource.DataSource = typeof(Lab4_Json.Reader);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1118, 517);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кафедральна бібліотека";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.BindingSource readerBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відкритиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripMenuItem таблиця1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem txtToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem jsonToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem таблиця2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem txtToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem jsonToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem таблиця1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem txtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jsonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблиця2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem txtToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem jsonToolStripMenuItem3;
        private System.Windows.Forms.Timer timer1;
    }
}

