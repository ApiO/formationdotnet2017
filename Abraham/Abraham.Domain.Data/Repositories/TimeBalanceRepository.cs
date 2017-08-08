using Abraham.Domain.Data.Interfaces;
using Abraham.Domain.Data.Models;
using System.Linq;
using Dapper;

namespace Abraham.Domain.Data.Repositories
{
    public class TimeBalanceRepository : SqlRepository, ITimeBalanceRepository
    {
        public TimeBalanceRepository(string connectionString) 
            : base(connectionString)
        {
        }

        public TimeBalance Get(int id)
        {
            var param = new
            {
                id = id
            };
            
            using (var ctx = GetDbContext())
            {
                return ctx.Connection
                            .Query<TimeBalance>("SELECT Id, Value, Date, UserId FROM FOO.VW_TimeBalance WHERE Id = @id", param, commandType: System.Data.CommandType.Text)
                            .First();
            }
        }
    }
}
