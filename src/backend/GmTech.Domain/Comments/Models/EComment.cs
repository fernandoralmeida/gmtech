namespace GmTech.Domain.Comments.Models;

public class EComment {
    public Guid Id { get; private set; }
    public string? Comment { get; private set;}
    public int Like { get; set; }
}