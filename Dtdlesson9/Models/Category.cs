namespace Dtdlesson9.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
public partial class Category
{
    public int CategoryId { get; set; }
    
    public string? CategoryName { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
