using Abraham.Domain.Business.DTOs;

namespace Abraham.Domain.Business.Interfaces
{
    public interface ITimeBalanceService
    {
        TimeBalance Get(int id);
    }
}
