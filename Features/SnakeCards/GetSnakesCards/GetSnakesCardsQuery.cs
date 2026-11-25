using MediatR;

namespace SnakeCards.GetSnakesCards;

public record GetSnakesCardsQuery : IRequest<IEnumerable<ShortSnakeInfoDto>>;