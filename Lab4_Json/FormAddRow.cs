using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab4_Json
{
    public partial class FormAddRow : Form
    {
        string s1, s2, s3, s4;

        Helper h = new Helper();
        Form1 f1;

        public string BookOrReader;
        public FormAddRow(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            maskedTextBox3.Text = "";
            maskedTextBox4.Text = "";

            BookOrReader = comboBox1.Text;
            h.EmptyMaskedTextBox(BookOrReader, maskedTextBox1, "П.І.П автора", "П.І.П");
            h.EmptyMaskedTextBox(BookOrReader, maskedTextBox2, "Назва", "Факультет");
            h.EmptyMaskedTextBox(BookOrReader, maskedTextBox3, "Анотація", "Кафедра");
            h.EmptyMaskedTextBox(BookOrReader, maskedTextBox4, "УДК", "Посада");
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void FormAddRow_Load(object sender, EventArgs e)
        {
            maskedTextBox1.ForeColor = Color.Gray;
            maskedTextBox2.ForeColor = Color.Gray;
            maskedTextBox3.ForeColor = Color.Gray;
            maskedTextBox4.ForeColor = Color.Gray;
        }

        private void maskedTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (BookOrReader == null)
            {
                MessageBox.Show("Спочатку оберіть, який об'єкт ви бажаєте додати");
                this.ActiveControl = null;
            }
            h.EnterMaskedTextBox(maskedTextBox1, "П.І.П автора", "П.І.П");
        }

        private void maskedTextBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (BookOrReader == null)
            {
                MessageBox.Show("Спочатку оберіть, який об'єкт ви бажаєте додати");
                this.ActiveControl = null;
            }
            h.EnterMaskedTextBox(maskedTextBox2, "Назва", "Факультет");
        }

        private void maskedTextBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (BookOrReader == null)
            {
                MessageBox.Show("Спочатку оберіть, який об'єкт ви бажаєте додати");
                this.ActiveControl = null;
            }
            h.EnterMaskedTextBox(maskedTextBox3, "Анотація", "Кафедра");
        }

        private void maskedTextBox4_MouseClick(object sender, MouseEventArgs e)
        {
            if (BookOrReader == null)
            {
                MessageBox.Show("Спочатку оберіть, який об'єкт ви бажаєте додати");
                this.ActiveControl = null;
            }
            h.EnterMaskedTextBox(maskedTextBox4, "УДК", "Посада");
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

        private void button1_Click(object sender, EventArgs e)
        {
            bool condition = true;
            s1 = h.GetMaskedText(maskedTextBox1);
            s2 = h.GetMaskedText(maskedTextBox2);
            s3 = h.GetMaskedText(maskedTextBox3);
            s4 = h.GetMaskedText(maskedTextBox4);
            if(s1 == null || s2 == null || s3 == null || s4 == null)
            {
                MessageBox.Show("Необхідно заповнити всі поля");
            }
            else 
            {
                if(BookOrReader == "Книга")
                {
                    string authorName = s1;
                    string name = s2;
                    string annotation = s3;
                    string udk = s4;
                    Book b = new Book(authorName, name, annotation, udk);

                    foreach(Book c in f1.books)
                    {
                        if (b.Equals(c)) 
                        {
                            MessageBox.Show("Вже існує");
                            condition = false;
                            break;
                        }                        
                    }
                    if (condition)
                    {
                        f1.books.Add(b);
                        //f1.dataGridView1.Rows.Add(b.AuthorName, b.Name, b.Annotation, b.Udk);
                        f1.table1.Rows.Add(b.AuthorName, b.Name, b.Annotation, b.Udk);
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
                    foreach (Reader d in f1.readers)
                    {
                        if (d.Equals(r))
                        {
                            MessageBox.Show("Вже існує");
                            condition = false;
                            break;
                        }
                    }
                    if (condition)
                    {
                        f1.readers.Add(r);
                        //f1.dataGridView2.Rows.Add(r.Name, r.Faculty, r.Departament, r.Position);
                        f1.table2.Rows.Add(r.Name, r.Faculty, r.Departament, r.Position);
                        f1.dataGridView2.DataSource = f1.table2;
                        this.Close();
                    }                        
                }
            }
        }
    }
}
