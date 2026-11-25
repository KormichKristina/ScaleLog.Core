using Infrastructure.SnakeCard;
using MediatR;

namespace SnakeCards.GetSnakesCards;

public class GetAllSnakeCardsHandler : IRequestHandler<GetSnakesCardsQuery, IEnumerable<ShortSnakeInfoDto>>
{
    private readonly ISnakeCardRepository snakeCardRepository;

    public GetAllSnakeCardsHandler(ISnakeCardRepository snakeCardRepository)
    {
        this.snakeCardRepository = snakeCardRepository;
    }

    public async Task<IEnumerable<ShortSnakeInfoDto>> Handle(GetSnakesCardsQuery request, CancellationToken cancellationToken)
        => await snakeCardRepository.GetAllSnakesCards();
    
}