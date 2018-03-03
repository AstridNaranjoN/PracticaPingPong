using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Domain.Repositories
{
    public interface IUnitOfWork
    {
        IPingRepository PingRepository { get; }
        IPongRepository PongRepository { get; }
    }
}
