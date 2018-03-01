using PingPong.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PingPong.Domain.Pong;

namespace PingPong.Infraestructure.Repositories
{
    class PingRepository : IPingRepository
    {
        private List<PingMessage> _repository = new List<PingMessage>();

        public void Add(PingMessage message)
        {
            _repository.Add(message);
        }

        public List<PingMessage> GetAll()
        {
            return _repository;
        }
    }
}
