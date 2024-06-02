namespace CourseProvider.Infrastructure.Data.Entities;

public class ContentEntity
{
    public string? description { get; set; }
    public string[]? includes { get; set; }
    public virtual List<ProgramDetailItemEntity>? ProgramDetails { get; set; }
}
