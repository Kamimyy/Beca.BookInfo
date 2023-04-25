using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Beca.BookInfo.Data;

public partial class BecaBookInfoContext : DbContext
{
    public BecaBookInfoContext()
    {
    }

    public BecaBookInfoContext(DbContextOptions<BecaBookInfoContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=WINAPMHZGDQMX63\\SQLEXPRESS;Initial Catalog=Beca.BookInfo;Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
