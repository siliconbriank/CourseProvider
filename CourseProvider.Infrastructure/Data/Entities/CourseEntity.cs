using System.ComponentModel.DataAnnotations;

namespace CourseProvider.Infrastructure.Data.Entities;

public class CourseEntity
{
    [Key]
    public string id { get; set; } = Guid.NewGuid().ToString();
    public string? image { get; set; }
    public string? bigImage { get; set; }
    public bool isBestSeller { get; set; }
    public bool isDigital { get; set; }
    public string[]? categories { get; set; }
    public string? title { get; set; }
    public string? ingress { get; set; }
    public decimal starRating { get; set; }
    public string? reviews { get; set; }
    public string? likesInProcent { get; set; }
    public string? likesInNumbers { get; set; }
    public string? hours { get; set; }
    public virtual List<AuthorEntity>? Authors { get; set; }
    public virtual PricesEntity? Prices { get; set; }
    public virtual ContentEntity? Content { get; set; }
}
