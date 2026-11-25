using MediatR;

namespace SnakeCards.ChangeSnakeCard;

public record ChangeSnakeCardCommand(
    int Id,
    string Name,
    string Species,
    string? Morph
) : IRequest;