using System.Linq;
using Abraham.Domain.Data.Interfaces;
using Abraham.Domain.Data.Models;
using Dapper;

namespace Abraham.Domain.Data.Repositories
{
    public class ComputerRepository : SqlRepository, IComputerRepository
    {

        public ComputerRepository(string connectionString) 
            : base(connectionString)
        {
        }

        public Computer Get(int id)
        {
            var param = new
            {
                id = id,
            };

            using (var ctx = GetDbContext())
            {
                return ctx.Connection
                    .Query<Computer>("SELECT Id, Description, Date, MaintenanceDate FROM FOO.VW_Computer WHERE Id = @id", param, commandType: System.Data.CommandType.Text)
                    .First();
            }
        }
    }
}
