namespace CourseProvider.Infrastructure.Models;

public class CourseUpdateRequest
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
    public virtual List<AuthorUpdateRequest>? Authors { get; set; }
    public virtual PriceUpdateRequest? Prices { get; set; }
    public virtual ContentUpdateRequest? Content { get; set; }
}

public class AuthorUpdateRequest
{
    public string? author { get; set; }
}

public class PriceUpdateRequest
{
    public string? currency { get; set; }
    public decimal price { get; set; }
    public decimal discountPrice { get; set; }
}

public class ContentUpdateRequest
{
    public string? description { get; set; }
    public string[]? includes { get; set; }
    public virtual List<ProgramDetailItemUpdateRequest>? ProgramDetails { get; set; }
}


public class ProgramDetailItemUpdateRequest
{
    public int id { get; set; }
    public string? title { get; set; }
    public string? description { get; set; }
}
