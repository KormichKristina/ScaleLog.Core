
using Infrastructure;

namespace SnakeCards.CreateSnakeCard
{
    public static class CreateSnakeCardResources
    {
        public static SqlResourceEntity CreateSnakeCard{get;} = new SqlResourceEntity("Features.SnakeCards.CreateSnakeCard.CreateSnakeCard.sql");
    }
}