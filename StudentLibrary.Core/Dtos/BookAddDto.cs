using StudentLibrary.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.Core.Dtos
{
    public class BookAddDto
    {
        public int IsbnNo { get; set; }
        public string Name { get; set; }
        public int Page { get; set; }


        public AuthorDto Author { get; set; }

    }
}
