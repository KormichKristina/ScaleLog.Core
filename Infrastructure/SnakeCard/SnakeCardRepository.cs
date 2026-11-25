
using Dapper;
using Npgsql;
using SnakeCards.ChangeSnakeCard;
using SnakeCards.CreateSnakeCard;
using SnakeCards.DeleteSnakeCard;
using SnakeCards.GetSnakeCardById;
using SnakeCards.GetSnakesCards;

namespace Infrastructure.SnakeCard
{
    public class SnakeCardRepository : ISnakeCardRepository
    {
        private readonly NpgsqlConnection npgsqlConnection;
        private readonly ISqlResourceHelper sqlResourceHelper;
        public SnakeCardRepository(IConfiguration configuration, ISqlResourceHelper sqlResourceHelper)
        {
            string conStr = configuration.GetConnectionString("default")!;
            npgsqlConnection = new NpgsqlConnection(conStr);
            this.sqlResourceHelper = sqlResourceHelper;
        }
        public async Task AppendSnakeCard(CreateSnakeCardCommand createSnakeCardCommand)
        {
            var query = sqlResourceHelper.GetSqlQuery(CreateSnakeCardResources.CreateSnakeCard);
            await npgsqlConnection.ExecuteAsync(query,createSnakeCardCommand);
        }

        public async Task DeleteSnakeCard(DeleteSnakeCardCommand deleteSnakeCardCommand)
        {
            var query = sqlResourceHelper.GetSqlQuery(DeleteSnakeCardResources.DeleteSnakeCard);
            
            await npgsqlConnection.ExecuteAsync(query, new { deleteSnakeCardCommand.Id });
        }

        public async Task ChangeSnakeCardById(ChangeSnakeCardCommand changeSnakeCardCommand)
        {
            var query = sqlResourceHelper.GetSqlQuery(ChangeSnakeCardResources.ChangeSnakeCard);
            
            await npgsqlConnection.ExecuteAsync(query, changeSnakeCardCommand);
        }

        public async Task<IEnumerable<ShortSnakeInfoDto>> GetAllSnakesCards()
        {
            var query = sqlResourceHelper.GetSqlQuery(GetSnakesCardsResources.GetSnakesCards);
            
            return await npgsqlConnection.QueryAsync<ShortSnakeInfoDto>(query);
        }

        public async Task<FullSnakeCardDto> GetSnakeCardById(GetSnakeCardByIdQuery getSnakeCardByIdQuery)
        {
            var query = sqlResourceHelper.GetSqlQuery(GetSnakesCardsResources.GetSnakesCards);
            
            return await npgsqlConnection.QueryFirstAsync<FullSnakeCardDto>(
                query, 
                new { getSnakeCardByIdQuery.Id }
            );
        }
    }
}