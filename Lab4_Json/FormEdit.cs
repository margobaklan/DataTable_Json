using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab4_Json
{
    public partial class FormEdit : Form
    {
        Form1 f1;
        Helper h = new Helper();
        string s1, s2, s3, s4;
        int indexRow;
        public string BookOrReader;

        DataTable t = new DataTable();

        public FormEdit(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            if (f1.dataGridView1.SelectedRows.Count > 0)
            {                
                maskedTextBox1.Text = f1.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                maskedTextBox2.Text = f1.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                maskedTextBox3.Text = f1.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                maskedTextBox4.Text = f1.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                BookOrReader = "Книга";
                Book b = new Book(maskedTextBox1.Text, maskedTextBox2.Text, maskedTextBox3.Text, maskedTextBox4.Text);
                int i = 0;
                foreach(Book c in f1.books)
                {
                    if (c.Equals(b))
                    {
                        break;
                    }
                    i++;
                }
                indexRow = i;
            }
            else if (f1.dataGridView2.SelectedRows.Count > 0)
            {
                //indexRow = f1.dataGridView2.CurrentRow.Index;
                maskedTextBox1.Text = f1.dataGridView2.CurrentRow.Cells[0].Value.ToString();
                maskedTextBox2.Text = f1.dataGridView2.CurrentRow.Cells[1].Value.ToString();
                maskedTextBox3.Text = f1.dataGridView2.CurrentRow.Cells[2].Value.ToString();
                maskedTextBox4.Text = f1.dataGridView2.CurrentRow.Cells[3].Value.ToString();
                BookOrReader = "Читач";
                Reader b = new Reader(maskedTextBox1.Text, maskedTextBox2.Text, maskedTextBox3.Text, maskedTextBox4.Text);
                int i = 0;
                foreach (Reader c in f1.readers)
                {
                    if (c.Equals(b))
                    {
                        break;
                    }
                    i++;
                }
                indexRow = i;
            }           
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            h.EmptyMaskedTextBox(BookOrReader, maskedTextBox1, "П.І.П автора", "П.І.П");
        }

        private void maskedTextBox2_Leave(object sender, EventArgs e)
        {
            h.EmptyMaskedTextBox(BookOrReader, maskedTextBox2, "Назва", "Факультет");
        }

        private void maskedTextBox3_Leave(object sender, EventArgs e)
        {
            h.EmptyMaskedTextBox(BookOrReader, maskedTextBox3, "Анотація", "Кафедра");
        }

        private void maskedTextBox4_Leave(object sender, EventArgs e)
        {
            h.EmptyMaskedTextBox(BookOrReader, maskedTextBox4, "УДК", "Посада");
        }

        private void maskedTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            h.EnterMaskedTextBox(maskedTextBox1, "П.І.П автора", "П.І.П");
        }

        private void maskedTextBox2_MouseClick(object sender, MouseEventArgs e)
        {
            h.EnterMaskedTextBox(maskedTextBox2, "Назва", "Факультет");
        }

        private void maskedTextBox3_MouseClick(object sender, MouseEventArgs e)
        {
            h.EnterMaskedTextBox(maskedTextBox3, "Анотація", "Кафедра");
        }

        private void maskedTextBox4_MouseClick(object sender, MouseEventArgs e)
        {
            h.EnterMaskedTextBox(maskedTextBox4, "УДК", "Посада");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s1 = h.GetMaskedText(maskedTextBox1);
            s2 = h.GetMaskedText(maskedTextBox2);
            s3 = h.GetMaskedText(maskedTextBox3);
            s4 = h.GetMaskedText(maskedTextBox4);
            bool condition = true;
            if (s1 == null || s2 == null || s3 == null || s4 == null)
            {
                MessageBox.Show("Необхідно заповнити всі поля");
            }
            else
            {
                if (BookOrReader == "Книга")
                {
                    string authorName = s1;
                    string name = s2;
                    string annotation = s3;
                    string udk = s4;
                    Book b = new Book(authorName, name, annotation, udk);
                    foreach (Book c in f1.books)
                    {
                        if (b.Equals(c) && !b.Equals(f1.books[indexRow]))
                        {
                            MessageBox.Show("Вже існує");
                            condition = false;
                            break;
                        }
                    }
                    if (condition)
                    {
                        f1.books[indexRow] = b;
                        //f1.dataGridView1.Rows[indexRow].SetValues(b.AuthorName, b.Name, b.Annotation, b.Udk);
                        f1.table1.Rows[indexRow]["П.І.П. автора"] = b.AuthorName;
                        f1.table1.Rows[indexRow]["Назва"] = b.Name;
                        f1.table1.Rows[indexRow]["Анотація"] = b.Annotation;
                        f1.table1.Rows[indexRow]["УДК"] = b.Udk;
                        f1.dataGridView1.DataSource = f1.table1;
                        this.Close();
                    }
                }
                else if (BookOrReader == "Читач")
                {
                    string name = s1;
                    string faculty = s2;
                    string departament = s3;
                    string position = s4;
                    Reader r = new Reader(name, faculty, departament, position);
                    foreach (Reader c in f1.readers)
                    {
                        if (r.Equals(c) && !r.Equals(f1.readers[indexRow]))
                        {
                            MessageBox.Show("Вже існує");
                            condition = false;
                            break;
                        }
                    }
                    if (condition)
                    {
                        f1.readers[indexRow] = r;
                        //f1.dataGridView2.Rows[indexRow].SetValues(r.Name, r.Faculty, r.Departament, r.Position);
                        f1.table2.Rows[indexRow]["П.І.П."] = r.Name;
                        f1.table2.Rows[indexRow]["Факультет"] = r.Faculty;
                        f1.table2.Rows[indexRow]["Кафедра"] = r.Departament;
                        f1.table2.Rows[indexRow]["Посада"] = r.Position;
                        f1.dataGridView2.DataSource = f1.table2;
                        this.Close();
                    }
                }
            }
        }
    }
}
