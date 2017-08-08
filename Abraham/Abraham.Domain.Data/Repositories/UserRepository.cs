using Abraham.Domain.Data.Interfaces;
using Abraham.Domain.Data.Models;
using System.Linq;
using Dapper;

namespace Abraham.Domain.Data.Repositories
{
    public class UserRepository : SqlRepository, IUserRepository
    {
        public UserRepository(string connectionString) 
            : base(connectionString)
        {
        }

        public User Get(int id)
        {
            var param = new
            {
                id = id
            };
            
            using (var ctx = GetDbContext())
            {
                return ctx.Connection
                            .Query<User>("SELECT Id, FirstName, LastName, Email, Balance FROM FOO.VW_User WHERE id = {id}", param, commandType: System.Data.CommandType.Text)
                            .First();
            }
        }
    }
}
