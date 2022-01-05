using document.Model;
using Microsoft.EntityFrameworkCore;

namespace document.DataContext;

public class DocumentDataContext : DbContext, IDataContext
{
    public DocumentDataContext(DbContextOptions<DocumentDataContext> options) : base(options)
    {
        
    }
    
    public DbSet<Document> Documents { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Document>()
            .Property(b => b.Id)
            .IsRequired();
        modelBuilder.Entity<Document>()
            .Property(b => b.Name)
            .IsRequired();
    }
}