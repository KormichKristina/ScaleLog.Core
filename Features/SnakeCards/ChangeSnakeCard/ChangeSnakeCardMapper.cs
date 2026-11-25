
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace SnakeCards.ChangeSnakeCard
{
    public static class ChangeSnakeCardMapper
    {
        public static void MapChangeSnakeCard(this WebApplication app)
        {
            app.MapPut("api/snake-card", async (IMediator mediator,[FromBody] ChangeSnakeCardCommand command) =>
            {
                await mediator.Send(command);
            });
        }
    }
}