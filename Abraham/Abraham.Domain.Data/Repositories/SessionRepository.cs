using Abraham.Domain.Data.Interfaces;
using Abraham.Domain.Data.Models;
using System.Linq;
using Dapper;

namespace Abraham.Domain.Data.Repositories
{
    public class SessionRepository : SqlRepository, ISessionRepository
    {
        public SessionRepository(string connectionString) 
            : base(connectionString)
        {
        }

        public Session Get(int id)
        {
            var param = new
            {
                id = id
            };
            
            using (var ctx = GetDbContext())
            {
                return ctx.Connection
                            .Query<Session>("SELECT Id, BeginDate, EndDate, UserId, CmpId FROM FOO.VW_Session WHERE Id = @id", param, commandType: System.Data.CommandType.Text)
                            .First();
            }
        }
    }
}
