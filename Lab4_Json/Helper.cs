using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Json
{
    class Helper
    {
        public void EnterMaskedTextBox(MaskedTextBox maskedTextBox, string s1, string s2)
        {
            if (maskedTextBox.ForeColor == Color.Gray && (maskedTextBox.Text == s1 || maskedTextBox.Text == s2) )
            {
                maskedTextBox.Text = "";
                maskedTextBox.ForeColor = Color.Black;
            }

        }
        public void EmptyMaskedTextBox(string bookOrReader, MaskedTextBox maskedTextBox, string s1, string s2)
        {
            if (bookOrReader == "Книга")
            {
                if (maskedTextBox.Text == "")
                {
                    maskedTextBox.ForeColor = Color.Gray;
                    maskedTextBox.Text = s1;
                }
            }
            else if (bookOrReader == "Читач")
            {
                if (maskedTextBox.Text == "")
                {
                    maskedTextBox.ForeColor = Color.Gray;
                    maskedTextBox.Text = s2;
                }
            }
        }
        public string GetMaskedText(MaskedTextBox maskedTextBox)
        {
            if(maskedTextBox.ForeColor == Color.Gray)
            {
                return null;
            }
            else
            {
                return maskedTextBox.Text;
            }
        }

        public bool CheckEqualLinesReaders(string[] lines)
        {
            Form1 f1 = new Form1();
            List<Reader> rlist = new List<Reader>();
            bool b = false;
            string[] values;
            string[] row;
            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('|');
                row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                Reader r = new Reader(row[0], row[1], row[2], row[3]);
                foreach(Reader r2 in rlist)
                {
                    if (r2.Equals(r)) b = true;
                }
                rlist.Add(r);
            }
            return b;
        }
        public bool CheckEqualLinesBooks(string[] lines)
        {
            Form1 f1 = new Form1();
            List<Book> blist = new List<Book>();
            bool b = false;
            string[] values;
            string[] row;
            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('|');
                row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                Book r = new Book(row[0], row[1], row[2], row[3]);
                foreach (Book b1 in blist)
                {
                    if (b1.Equals(r)) b = true;
                }
                blist.Add(r);
            }
            return b;
        }
        public bool CheckTableBook(DataTable dataTable)
        {
            bool b = false;
            List<Book> blist = new List<Book>();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                string s1 = dataTable.Rows[i]["П.І.П. автора"].ToString();
                string s2 = dataTable.Rows[i]["Назва"].ToString();
                string s3 = dataTable.Rows[i]["Анотація"].ToString();
                string s4 = dataTable.Rows[i]["УДК"].ToString();
                Book book = new Book(s1, s2, s3, s4);
                foreach (Book b1 in blist)
                {
                    if (b1.Equals(book)) b = true;
                }
                blist.Add(book);
            }
            return b;
        }
        public bool CheckTableReader(DataTable dataTable)
        {
            bool b = false;
            List<Reader> rlist = new List<Reader>();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                string s1 = dataTable.Rows[i]["П.І.П."].ToString();
                string s2 = dataTable.Rows[i]["Факультет"].ToString();
                string s3 = dataTable.Rows[i]["Кафедра"].ToString();
                string s4 = dataTable.Rows[i]["Посада"].ToString();
                Reader reader = new Reader(s1, s2, s3, s4);
                foreach (Reader r1 in rlist)
                {
                    if (r1.Equals(reader)) b = true;
                }
                rlist.Add(reader);
            }
            return b;
        }     
    }
}
