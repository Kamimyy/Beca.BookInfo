using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beca.BookInfo.Data.Entities
{
    public class Chapter
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
