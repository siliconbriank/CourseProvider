namespace CourseProvider.Infrastructure.Data.Entities;

public class PricesEntity
{
    public string? currency { get; set; }
    public decimal price { get; set; }
    public decimal discountPrice { get; set; }
}
