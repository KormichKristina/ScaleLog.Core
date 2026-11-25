
using Infrastructure;

namespace SnakeCards.GetSnakesCards
{
    public static class GetSnakesCardsResources
    {
        public static SqlResourceEntity GetSnakesCards{get;} = new SqlResourceEntity("Features.SnakeCards.GetSnakesCards.GetSnakesCards.sql");
    }
}