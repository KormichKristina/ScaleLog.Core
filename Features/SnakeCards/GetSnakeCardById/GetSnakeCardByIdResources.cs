
using Infrastructure;

namespace SnakeCards.GetSnakeCardById
{
    public static class GetSnakeCardByIdResources
    {
        public static SqlResourceEntity GetSnakeCardById{get;} = new SqlResourceEntity("Features.SnakeCards.GetSnakeCardById.GetSnakeCardById.sql");
    }
}