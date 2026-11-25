
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace SnakeCards.DeleteSnakeCard
{
    public static class DeleteSnakeCardMapper
    {
        public static void MapDeleteSnakeCard(this WebApplication app)
        {
            app.MapDelete("api/snake-card", async (IMediator mediator,[FromBody] DeleteSnakeCardCommand command) =>
            {
                await mediator.Send(command);
            });
        }
    }
}