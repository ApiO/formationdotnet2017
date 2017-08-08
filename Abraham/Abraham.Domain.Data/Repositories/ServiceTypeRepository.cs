using System;
using System.Linq;
using Abraham.Domain.Data.Interfaces;
using Abraham.Domain.Data.Models;
using Dapper;

namespace Abraham.Domain.Data.Repositories
{
    public class ServiceTypeRepository : SqlRepository, IServiceTypeRepository
    {
        public ServiceTypeRepository(string connectionString) 
            : base(connectionString)
        {
        }

        public ServiceType Get(int id)
        {
            var param = new
            {
                id = id
            };

            using (var ctx = GetDbContext())
            {
                return ctx.Connection
                    .Query<ServiceType>("SELECT Id, Description FROM FOO.VW_ServiceType WHERE Id = @id", param, commandType: System.Data.CommandType.Text)
                    .First();
            }
        }
    }
}
