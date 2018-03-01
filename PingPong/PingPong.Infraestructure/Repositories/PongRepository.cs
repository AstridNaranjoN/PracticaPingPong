using PingPong.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PingPong.Domain.Pong;

namespace PingPong.Infraestructure.Repositories
{
    class PongRepository : IPongRepository
    {
        private List<PongMessage> _repository = new List<PongMessage>();

        public void Add(PongMessage message)
        {
            _repository.Add(message);
        }

        public List<PongMessage> GetAll()
        {
            return _repository;
        }
    }
}
