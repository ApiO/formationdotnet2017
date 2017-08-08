using System.Linq;
using Abraham.Domain.Data.Interfaces;
using Abraham.Domain.Data.Models;
using Dapper;

namespace Abraham.Domain.Data.Repositories
{
    public class ServiceRepository : SqlRepository, IServiceRepository
    {
        public ServiceRepository(string connectionString) : base(connectionString)
        {
        }

        public Service Get(int id)
        {
            var param = new
            {
                id = id
            };

            using (var ctx = GetDbContext())
            {
                return ctx.Connection
                    .Query<Service>(
                        "SELECT Id, Description, Price, ServiceTypeId as TypeId FROM FOO.VW_Service where Id = @id",
                        param, commandType: System.Data.CommandType.Text).First();
            }
        }
    }
}
