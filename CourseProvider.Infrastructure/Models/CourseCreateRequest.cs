using CourseProvider.Infrastructure.Data.Entities;

namespace CourseProvider.Infrastructure.Models;

public class CourseCreateRequest
{
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
    public virtual List<AuthorCreateRequest>? Authors { get; set; }
    public virtual PriceCreateRequest? Prices { get; set; }
    public virtual ContentCreateRequest? Content { get; set; }
}

public class AuthorCreateRequest
{
    public string? author { get; set; }
}

public class PriceCreateRequest
{
    public string? currency { get; set; }
    public decimal price { get; set; }
    public decimal discountPrice { get; set; }
}

public class ContentCreateRequest
{
    public string? description { get; set; }
    public string[]? includes { get; set; }
    public virtual List<ProgramDetailItemCreateRequest>? ProgramDetails { get; set; }
}


public class ProgramDetailItemCreateRequest
{
    public int id { get; set; }
    public string? title { get; set; }
    public string? description { get; set; }
}
