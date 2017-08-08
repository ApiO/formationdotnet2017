using Abraham.Domain.Data.Models;

namespace Abraham.Domain.Data.Interfaces
{
    public interface IComputerRepository
    {
        Computer Get(int id);
    }
}
