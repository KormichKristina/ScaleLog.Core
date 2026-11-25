namespace  SnakeCards.GetSnakesCards;

public record ShortSnakeInfoDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Species { get; set; } = null!;
    public string? Morph { get; set; }
    public string? Gender { get; set; }
}