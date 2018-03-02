using PingPong.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PingPong.Domain.Pong;
using PingPong.Domain.Contract;

namespace PingPong.Infraestructure.Repositories
{
    public class PingRepository : IPingRepository
    {
        private List<IMessage> _repository = new List<IMessage>();

        public void Add(IMessage message)
        {
            _repository.Add(message);
        }

        public List<IMessage> GetAll()
        {
            return _repository;
        }
    }
}
