namespace PingPong.Domain.Repositories
{
    public interface IUnitOfWork
    {
        IPingRepository PingRepository { get; }
        IPongRepository PongRepository { get; }
    }
}
