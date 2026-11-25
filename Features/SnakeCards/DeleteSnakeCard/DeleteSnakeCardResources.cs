
using Infrastructure;

namespace SnakeCards.DeleteSnakeCard
{
    public static class DeleteSnakeCardResources
    {
        public static SqlResourceEntity DeleteSnakeCard{get;} = new SqlResourceEntity("Features.SnakeCards.DeleteSnakeCard.DeleteSnakeCard.sql");
    }
}