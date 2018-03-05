using PingPong.Domain.Repositories;

namespace PingPong.Infraestructure.Repositories
{
    public class UnitOfWork : IUnitOfWork 
    {
        public IPingRepository PingRepository { get; private set; }

        public IPongRepository PongRepository { get; private set; }

        public UnitOfWork(IPingRepository pingRepository, IPongRepository pongRepository)
        {
            PingRepository = pingRepository;
            PongRepository = pongRepository;
        }
    }
}
