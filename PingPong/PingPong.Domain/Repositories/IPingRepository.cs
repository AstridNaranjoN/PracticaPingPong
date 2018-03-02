using PingPong.Domain.Contract;
using PingPong.Domain.Pong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Domain.Repositories
{
    public interface IPingRepository
    {
        void Add(IMessage message);
        List<IMessage> GetAll();

    }
}
