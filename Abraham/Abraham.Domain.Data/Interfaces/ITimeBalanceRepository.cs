using Abraham.Domain.Data.Models;

namespace Abraham.Domain.Data.Interfaces
{
    public interface ITimeBalanceRepository
    {
        TimeBalance Get(int id);
    }
}