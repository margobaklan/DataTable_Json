using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Json
{
    public class Reader
    {
        public string Name { get; set; }
        public string Faculty { get; set; }
        public string Departament { get; set; }
        public string Position { get; set; }
        public Reader(string name, string faculty, string departament, string position)
        {
            Name = name;
            Faculty = faculty;
            Departament = departament;
            Position = position;
        }
        public override bool Equals(object other)
        {
            var reader = other as Reader;
            if (reader == null) return false;
            return this.Name == reader.Name && this.Faculty == reader.Faculty && this.Departament == reader.Departament && this.Position == reader.Position;
        }
    }
    
}
