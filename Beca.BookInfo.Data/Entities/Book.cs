using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beca.BookInfo.Data.Entities
{
    public class Book
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<Chapter> Chapters { get; set; }

    }
}
