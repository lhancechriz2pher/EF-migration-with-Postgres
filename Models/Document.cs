using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace document.Model;

public class Document
{
    public  Guid Id { get; set; }
    public string Name { get; set; }
    
    [Column(TypeName="jsonb")]
    public string DataJsonb { get; set; }
    
    public DateTime Created { get; set; }
    
    public  string Path { get; set; }
}