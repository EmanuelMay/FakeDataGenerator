using GeneratorFakeData.Domain.Models;

namespace GeneratorFakeData.Domain.Interfaces.Repository
{
    public interface IUserRepository
    {
        void Save(UserData user);
    }
}
