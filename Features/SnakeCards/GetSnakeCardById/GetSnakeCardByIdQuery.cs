using MediatR;

namespace SnakeCards.GetSnakeCardById;

public record GetSnakeCardByIdQuery(int Id) : IRequest<FullSnakeCardDto>;