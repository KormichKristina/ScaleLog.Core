
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace SnakeCards.CreateSnakeCard
{
    public static class CreateSnakeCardMapper
    {
        public static void MapCreateSnakeCard(this WebApplication app)
        {
            app.MapPost("api/snake-card", async (IMediator mediator,[FromBody] CreateSnakeCardCommand command) =>
            {
                await mediator.Send(command);
            });
        }
    }
}