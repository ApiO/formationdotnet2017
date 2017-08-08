using Abraham.Domain.Data.Tools;

namespace Abraham.Domain.Data
{
    public abstract class SqlRepository
    {
        private string _connectionString;

        protected SqlRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DbContext GetDbContext()
        {
            return new DbContext(_connectionString);
        }
    }
}
