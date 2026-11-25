using Infrastructure.SnakeCard;
using MediatR;

namespace SnakeCards.DeleteSnakeCard;

public class DeleteSnakeCardHandler : IRequestHandler<DeleteSnakeCardCommand>
{
    private readonly ISnakeCardRepository snakeCardRepository;

    public DeleteSnakeCardHandler(ISnakeCardRepository snakeCardRepository)
    {
        this.snakeCardRepository = snakeCardRepository;
    }

    public async Task Handle(DeleteSnakeCardCommand request, CancellationToken cancellationToken)
    {
        await snakeCardRepository.DeleteSnakeCard(request);
    }
}