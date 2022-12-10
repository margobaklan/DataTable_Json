using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using System.Xml.Linq;

namespace Lab4_Json
{

    public partial class Form1 : Form
    {

        public List<Book> books = new List<Book>();
        public List<Reader> readers = new List<Reader>();
        Helper h = new Helper();

        public string comboBox1Text;
        public string comboBox2Text;

        public DataTable table1, table2;
        int time = 0;

        public Form1()
        {
            
            InitializeComponent();
            /*dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "П.І.П. автора";
            dataGridView1.Columns[1].Name = "Назва";
            dataGridView1.Columns[2].Name = "Анотація";
            dataGridView1.Columns[3].Name = "УДК";

            dataGridView2.ColumnCount = 4;
            dataGridView2.Columns[0].Name = "П.І.П.";
            dataGridView2.Columns[1].Name = "Факультет";
            dataGridView2.Columns[2].Name = "Кафедра";
            dataGridView2.Columns[3].Name = "Посада";*/

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // dataGridView1.RowHeadersVisible = false;
            // dataGridView2.RowHeadersVisible = false;
            //dataGridView1.TopLeftHeaderCell.Value = "№";
            //dataGridView2.TopLeftHeaderCell.Value = "№";

            //dataGridView1.Rows[0].Visible = false;
            //dataGridView2.Rows[0].Visible = false;
            // dataGridView1.Rows[0].Cells[0].Value = "22";
            //dataGridView1.Width = (this.Width / 2) - 10;
            //dataGridView2.Width = (this.Width / 2) - 10;

            timer1.Start();
            table1 = new DataTable();
            table2 = new DataTable();

            table1.Columns.Add("П.І.П. автора", typeof(string));
            table1.Columns.Add("Назва", typeof(string));
            table1.Columns.Add("Анотація", typeof(string));
            table1.Columns.Add("УДК", typeof(string));

            table2.Columns.Add("П.І.П.", typeof(string));
            table2.Columns.Add("Факультет", typeof(string));
            table2.Columns.Add("Кафедра", typeof(string));
            table2.Columns.Add("Посада", typeof(string));

            dataGridView1.DataSource = table1;
            dataGridView2.DataSource = table2;
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 myForm = new Form2();
            myForm.Show();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            if (comboBox1Text == null)
            {
                MessageBox.Show("Спочатку оберіть, за яким критерієм здійснюєте пошук");
                this.ActiveControl = null;
            }
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            if (comboBox2Text == null)
            {
                MessageBox.Show("Спочатку оберіть, за яким критерієм здійснюєте пошук");
                this.ActiveControl = null;
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = null;
            comboBox1Text = toolStripComboBox1.Text;
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripTextBox2.Text = null;
            comboBox2Text = toolStripComboBox2.Text;
        }

        private void toolStripTextBox2_TextChanged(object sender, EventArgs e)
        {
            DataView dv = table2.DefaultView;
            switch (comboBox2Text)
            {
                case "П.І.П." :
                    dv.RowFilter = "[П.І.П.] LIKE '%" + toolStripTextBox2.Text + "%'";
                    dataGridView2.DataSource = dv;                 
                    break;
                case "Факультет":
                    dv.RowFilter = "Факультет LIKE '%" + toolStripTextBox2.Text + "%'";
                    dataGridView2.DataSource = dv;
                    break;
                case "Кафедра":
                    dv.RowFilter = "Кафедра LIKE '%" + toolStripTextBox2.Text + "%'";
                    dataGridView2.DataSource = dv;
                    break;
                case "Посада":
                    dv.RowFilter = "Посада LIKE '%" + toolStripTextBox2.Text + "%'";
                    dataGridView2.DataSource = dv;
                    break;
            }
        }
        private void txtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter(@"C:\Users\Margo\source\repos\Lab4_Json\Lab4_Json\table1.txt");
            for (int i = 0; i < table1.Rows.Count; i++)
            {
                for (int j = 0; j < table1.Columns.Count; j++)
                {
                    if (j == table1.Columns.Count - 1)
                    {
                        writer.Write("\t" + table1.Rows[i].Field<string>(j));
                    }
                    else
                        writer.Write("\t" + table1.Rows[i].Field<string>(j) + "\t" + "|");
                }
                writer.WriteLine("");
            }
            writer.Close();
            MessageBox.Show("Дані збережені в table1.txt");
        }

        private void txtToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter(@"C:\Users\Margo\source\repos\Lab4_Json\Lab4_Json\table2.txt");
            for (int i = 0; i < table2.Rows.Count; i++)
            {

                for (int j = 0; j < table2.Columns.Count; j++)
                {
                    if (j == table1.Columns.Count - 1)
                    {
                        writer.Write("\t" + table2.Rows[i].Field<string>(j));
                    }
                    else
                        writer.Write("\t" + table2.Rows[i].Field<string>(j) + "\t" + "|");
                }
                writer.WriteLine("");
            }
            writer.Close();
            MessageBox.Show("Дані збережені в table2.txt");
        }

        private void txtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] lines = File.ReadAllLines(@"C:\Users\Margo\source\repos\Lab4_Json\Lab4_Json\table1.txt", Encoding.GetEncoding(1251));
                string[] values;
                if(h.CheckEqualLinesBooks(lines)) throw new Exception("Неправильний формат, перевірте файл");
                books.Clear();
                table1.Clear();
                for (int i = 0; i < lines.Length; i++)
                {
                    values = lines[i].ToString().Split('|');
                    string[] row = new string[values.Length];

                    for (int j = 0; j < values.Length; j++)
                    {
                        row[j] = values[j].Trim();
                    }
                    table1.Rows.Add(row);
                    Book b = new Book(row[0], row[1], row[2], row[3]);
                    books.Add(b);
                }
                dataGridView1.DataSource = table1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                string[] lines = File.ReadAllLines(@"C:\Users\Margo\source\repos\Lab4_Json\Lab4_Json\table2.txt", Encoding.GetEncoding(1251));
                string[] values;
                if (h.CheckEqualLinesReaders(lines)) throw new Exception("Неправильний формат, перевірте файл");
                readers.Clear();
                table2.Clear();
                for (int i = 0; i < lines.Length; i++)
                {
                    values = lines[i].ToString().Split('|');
                    string[] row = new string[values.Length];

                    for (int j = 0; j < values.Length; j++)
                    {
                        row[j] = values[j].Trim();
                    }                    
                    Reader r = new Reader(row[0], row[1], row[2], row[3]);
                    readers.Add(r);
                    table2.Rows.Add(row);
                }
                dataGridView2.DataSource = table2;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void jsonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader(@"C:\Users\Margo\source\repos\Lab4_Json\Lab4_Json\table1.json");
                string json = sr.ReadToEnd();
                DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
                if (h.CheckTableBook(dataTable)) throw new Exception("Неправильний формат, перевірте файл");
                books.Clear();
                table1 = dataTable;
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    string s1 = dataTable.Rows[i]["П.І.П. автора"].ToString();
                    string s2 = dataTable.Rows[i]["Назва"].ToString();
                    string s3 = dataTable.Rows[i]["Анотація"].ToString();
                    string s4 = dataTable.Rows[i]["УДК"].ToString();
                    Book book = new Book(s1, s2, s3, s4);
                    books.Add(book);
                }
                dataGridView1.DataSource = dataTable;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void jsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Margo\source\repos\Lab4_Json\Lab4_Json\table1.json";
            string output = JsonConvert.SerializeObject(table1);
            File.WriteAllText(path, output);
            MessageBox.Show("Таблиця 1 збережена в table1.json" + time);
           
        }

        private void jsonToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Margo\source\repos\Lab4_Json\Lab4_Json\table2.json";
            string output = JsonConvert.SerializeObject(table2);
            File.WriteAllText(path, output);
            MessageBox.Show("Таблиця 2 збережена в table2.json");
        }

        private void jsonToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader(@"C:\Users\Margo\source\repos\Lab4_Json\Lab4_Json\table2.json");
                string json = sr.ReadToEnd();
                DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
                if (h.CheckTableReader(dataTable)) throw new Exception("Неправильний формат, перевірте файл");
                readers.Clear();
                table2 = dataTable;
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    string s1 = dataTable.Rows[i]["П.І.П."].ToString();
                    string s2 = dataTable.Rows[i]["Факультет"].ToString();
                    string s3 = dataTable.Rows[i]["Кафедра"].ToString();
                    string s4 = dataTable.Rows[i]["Посада"].ToString();
                    Reader reader = new Reader(s1, s2, s3, s4);
                    readers.Add(reader);
                }
                dataGridView2.DataSource = dataTable;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            DialogResult d = MessageBox.Show($"Ви впевнені, що хочете вийти?", "Вихід", MessageBoxButtons.YesNo);
            if (d == DialogResult.No)
            {
                timer1.Start();
                e.Cancel = true;
            }                
        }

        private void AddRowButton(object sender, EventArgs e)
        {
            FormAddRow myForm = new FormAddRow(this);
            myForm.Show();
        }

        private void DeleteRowButton(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0 || dataGridView2.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Ви впевнені що хочете видалити вибрані рядки?", "Підтвердження", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string s1, s2, s3, s4;
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        s1 = row.Cells[0].Value.ToString();
                        s2 = row.Cells[1].Value.ToString();
                        s3 = row.Cells[2].Value.ToString();
                        s4 = row.Cells[3].Value.ToString();
                        Book b = new Book(s1, s2, s3, s4);
                        int i = 0;
                        foreach (Book c in books)
                        {
                            if (c.Equals(b))
                            {
                                break;
                            }
                            i++;
                        }
                        int indexRow = i;
                        table1.Rows.Remove(table1.Rows[indexRow]);
                        books.Remove(books[indexRow]);
                    }
                    foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                    {
                        s1 = row.Cells[0].Value.ToString();
                        s2 = row.Cells[1].Value.ToString();
                        s3 = row.Cells[2].Value.ToString();
                        s4 = row.Cells[3].Value.ToString();
                        Reader b = new Reader(s1, s2, s3, s4);
                        int i = 0;
                        foreach (Reader c in readers)
                        {
                            if (c.Equals(b))
                            {
                                break;
                            }
                            i++;
                        }
                        int indexRow = i;
                        table2.Rows.Remove(table2.Rows[indexRow]);
                        readers.Remove(readers[indexRow]);
                    }
                    dataGridView1.DataSource = table1;
                    dataGridView2.DataSource = table2;
                }
            }
            else
            {
                MessageBox.Show("Виберіть рядок");
            }
        }

        private void EditRowButton(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count + dataGridView2.SelectedRows.Count > 1)
            {
                MessageBox.Show("Виберіть лише один рядок");
            }
            else if (dataGridView1.SelectedRows.Count == 1 || dataGridView2.SelectedRows.Count == 1)
            {
                FormEdit myForm = new FormEdit(this);
                myForm.Show();
            }
            else
            {
                MessageBox.Show("Виберіть рядок");
            }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dv = table1.DefaultView;   
            switch (comboBox1Text)
            {
                case "П.І.П. автора":
                    dv.RowFilter = "[П.І.П. автора] LIKE '%" + toolStripTextBox1.Text + "%'";
                    dataGridView1.DataSource = dv;                    
                    break;
                case "Назва":
                    dv.RowFilter = "Назва LIKE '%" + toolStripTextBox1.Text + "%'";
                    dataGridView1.DataSource = dv;
                    break;
                case "Анотація":
                    dv.RowFilter = "Анотація LIKE '%" + toolStripTextBox1.Text + "%'";
                    dataGridView1.DataSource = dv;
                    break;
                case "УДК":
                    dv.RowFilter = "УДК LIKE '%" + toolStripTextBox1.Text + "%'";
                     dataGridView1.DataSource = dv;
                    break;
            }            
        }
    }
}