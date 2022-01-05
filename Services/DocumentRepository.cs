using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using document.DataContext;
using document.Model;

namespace document.Services;

public interface IDocumentRepository
{
    Task<List<Document>> GetDocuments();
}

public class DocumentRepository : IDocumentRepository
{
    private readonly DocumentDataContext _dbContext;

    public DocumentRepository(DocumentDataContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Document>> GetDocuments()
    {
        return  await _dbContext.Documents.ToListAsync();
    }
        
}