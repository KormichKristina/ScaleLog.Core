using Infrastructure.SnakeCard;
using MediatR;
using SnakeCards.ChangeSnakeCard;

namespace SnakeCards.UpdateSnakeCard;

public class UpdateSnakeCardHandler : IRequestHandler<ChangeSnakeCardCommand>
{
    private readonly ISnakeCardRepository snakeCardRepository;

    public UpdateSnakeCardHandler(ISnakeCardRepository snakeCardRepository)
    {
        this.snakeCardRepository = snakeCardRepository;
    }

    public async Task Handle(ChangeSnakeCardCommand request, CancellationToken cancellationToken)
    {
        await snakeCardRepository.ChangeSnakeCardById(request);
    }
}