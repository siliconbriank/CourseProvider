namespace CourseProvider.Infrastructure.Models;

public class Course
{
    public string id { get; set; } = null!;
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
    public virtual List<Author>? Authors { get; set; }
    public virtual Prices? Prices { get; set; }
    public virtual Content? Content { get; set; }
}

public class Author
{
    public string? author { get; set; }
}

public class Prices
{
    public string? currency { get; set; }
    public decimal price { get; set; }
    public decimal discountPrice { get; set; }
}

public class Content
{
    public string? description { get; set; }
    public string[]? includes { get; set; }
    public virtual List<ProgramDetailItem>? ProgramDetails { get; set; }
}


public class ProgramDetailItem
{
    public int id { get; set; }
    public string? title { get; set; }
    public string? description { get; set; }
}
