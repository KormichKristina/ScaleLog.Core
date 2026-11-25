
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace SnakeCards.GetSnakesCards
{
    public static class GetSnakesCardsMapper
    {
        public static void MapGetSnakeCardById(this WebApplication app)
        {
            app.MapGet("api/snake-card/all", async (IMediator mediator,[FromBody] GetSnakesCardsQuery query) =>
            {
                return await mediator.Send(query);
            });
        }
    }
}