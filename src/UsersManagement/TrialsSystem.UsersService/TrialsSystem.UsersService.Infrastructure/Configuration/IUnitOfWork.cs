namespace TrialsSystem.UsersService.Infrastructure.Configuration
{
    public interface IUnitOfWork
    {
        IUserRepository Users { get; }
        ICityRepository Cities { get; }
        IDeviceRepository Devices { get; }
    }
}