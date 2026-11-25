
using SnakeCards.ChangeSnakeCard;
using SnakeCards.CreateSnakeCard;
using SnakeCards.DeleteSnakeCard;
using SnakeCards.GetSnakeCardById;
using SnakeCards.GetSnakesCards;

namespace Infrastructure.SnakeCard
{
    public interface ISnakeCardRepository
    {
        Task AppendSnakeCard(CreateSnakeCardCommand createSnakeCardCommand);
        Task DeleteSnakeCard(DeleteSnakeCardCommand deleteSnakeCardCommand);
        Task ChangeSnakeCardById(ChangeSnakeCardCommand changeSnakeCardCommand);
        Task<IEnumerable<ShortSnakeInfoDto>> GetAllSnakesCards();
        Task<FullSnakeCardDto> GetSnakeCardById(GetSnakeCardByIdQuery getSnakeCardByIdQuery);

    }
}