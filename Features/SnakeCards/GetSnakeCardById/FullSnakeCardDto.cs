

namespace  SnakeCards.GetSnakeCardById;

public record FullSnakeCardDto
{
    public string Name { get; set; } = null!;
    public string Species { get; set; } = null!;
    public string? Morph { get; set; }
    public DateTimeOffset? DateOfBirth { get; set; }
    public DateTimeOffset CardCreated { get; set; }
    public string? Gender { get; set; }
}