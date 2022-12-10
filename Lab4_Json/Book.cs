using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Json
{
    public class Book
    {
        public string AuthorName { get; set; }
        public string Name { get; set; }
        public string Annotation { get; set; }
        public string Udk { get; set; }
        public Book(string authorName, string name, string annotation, string udk)
        {
            AuthorName = authorName;
            Name = name;
            Annotation = annotation;
            Udk = udk;
        }
        public override bool Equals(object other)
        {
            var book = other as Book;
            if (book == null) return false;
            return this.AuthorName == book.AuthorName && this.Name == book.Name && this.Annotation == book.Annotation && this.Udk == book.Udk;
        }
    }
}
