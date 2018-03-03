using PingPong.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
