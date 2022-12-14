using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.Core.Models
{
    public class Book
    {
        public int Id { get; set; }
        public int IsbnNo { get; set; } //Kitap numarası.
        public string Name { get; set; }
        public int Page { get; set; }

        public Author Author { get; set; }
        public ICollection<Operation> Operations { get; set; }

    }
}
