using MediatR;

namespace SnakeCards.DeleteSnakeCard;

public record DeleteSnakeCardCommand(int Id) : IRequest;