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



        public int Add(ServiceType serviceType)
        {
            var param = new
            {
                Description = serviceType.Description
            };

            using (var ctx = GetDbContext())
            {
                return ctx.Connection
                    .Query<int>(@"INSERT INTO[FOO].[VW_ServiceType] ([Description]) VALUES (@Description)
                                  SELECT SCOPE_IDENTITY()"
                                , param, commandType: System.Data.CommandType.Text)
                    .First();
            }
        }

        public bool DescriptionExists(string description)
        {
            var param = new
            {
                Description = description
            };

            using (var ctx = GetDbContext())
            {
                return ctx.Connection
                    .Query<bool>(@"DECLARE @Result BIT = 0
                                IF EXISTS(SELECT 1 FROM[FOO].[VW_ServiceType] ST WITH(NOLOCK) WHERE ST.[Description] = @Description)
                                BEGIN
                                    SET @Result = 1
                                END
                                SELECT @Result"
                                , param, commandType: System.Data.CommandType.Text)
                    .First();
            }
        }
    }
}
