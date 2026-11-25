
using Infrastructure.SnakeCard;
using MediatR;

namespace SnakeCards.CreateSnakeCard
{
    public class CreateSnakeCardHandler : IRequestHandler<CreateSnakeCardCommand>
    {
        private readonly ISnakeCardRepository snakeCardRepository;
        public CreateSnakeCardHandler(ISnakeCardRepository snakeCardRepository)
        {
            this.snakeCardRepository = snakeCardRepository;
        }
        public async Task Handle(CreateSnakeCardCommand request, CancellationToken cancellationToken)
        {
            await snakeCardRepository.AppendSnakeCard(request);
        }
    }
}