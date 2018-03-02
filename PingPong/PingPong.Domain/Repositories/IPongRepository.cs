using PingPong.Domain.Pong;
using System.Collections.Generic;

namespace PingPong.Domain.Repositories
{
    public interface IPongRepository
    {
        void Add(PingPongMessage message);
        List<PingPongMessage> GetAll();
    }
}
