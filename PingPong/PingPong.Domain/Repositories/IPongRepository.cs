using PingPong.Domain.Pong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Domain.Repositories
{
    public interface IPongRepository
    {
        void Add(PongMessage message);
        List<PongMessage> GetAll();
    }
}
