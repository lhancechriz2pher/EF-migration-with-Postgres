using document.Model;
using Microsoft.EntityFrameworkCore;

namespace document.DataContext;

public interface IDataContext
{
 
    public DbSet<Document> Documents { get; set; }
}