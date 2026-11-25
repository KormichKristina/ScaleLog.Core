using Infrastructure.SnakeCard;
using MediatR;

namespace SnakeCards.GetSnakeCardById;

public class GetSnakeCardByIdHandler : IRequestHandler<GetSnakeCardByIdQuery, FullSnakeCardDto?>
{
    private readonly ISnakeCardRepository snakeCardRepository;

    public GetSnakeCardByIdHandler(ISnakeCardRepository snakeCardRepository)
    {
        this.snakeCardRepository = snakeCardRepository;
    }

    public async Task<FullSnakeCardDto?> Handle(GetSnakeCardByIdQuery request, CancellationToken cancellationToken)
    {
        return await snakeCardRepository.GetSnakeCardById(request);
    }
}