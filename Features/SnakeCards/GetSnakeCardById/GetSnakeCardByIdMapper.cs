
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace SnakeCards.GetSnakeCardById
{
    public static class GetSnakeCardByIdMapper
    {
        public static void MapGetSnakeCardById(this WebApplication app)
        {
            app.MapGet("api/snake-card", async (IMediator mediator,[FromBody] GetSnakeCardByIdQuery query) =>
            {
                return await mediator.Send(query);
            });
        }
    }
}