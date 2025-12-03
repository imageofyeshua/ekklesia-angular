using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities;

public class Member
{
    public string Id { get; set; } = null!;
    public DateOnly DateOfBirth { get; set; }
    public string? ImageUrl { get; set; }
    public required string DisplayName { get; set; }
    public DateTime Created { get; set; } = DateTime.UtcNow;
    public DateTime LastActive { get; set; } = DateTime.UtcNow;
    public string? Sex { get; set; }
    public string? Description { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }

    // Navigation property
    public List<Photo> Photos { get; set; } = [];
    [ForeignKey(nameof(Id))]
    public AppUser User { get; set; } = null!;
}