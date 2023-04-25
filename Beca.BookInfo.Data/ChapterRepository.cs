using Beca.BookInfo.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beca.BookInfo.Data
{
    public class ChapterRepository : Repository<Chapter>
    {
        public ChapterRepository(DbContext context) : base(context)
        {
        }
    }

}
