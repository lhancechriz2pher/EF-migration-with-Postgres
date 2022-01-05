using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using document.Model;
using document.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace document.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DocumentController : ControllerBase
    {
        

        private readonly ILogger<DocumentController> _logger;
        private readonly IDocumentRepository _repository;

        public DocumentController(ILogger<DocumentController> logger, IDocumentRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public async Task<List<Document>> Get()
        {
           return await _repository.GetDocuments();
        }
    }
}
