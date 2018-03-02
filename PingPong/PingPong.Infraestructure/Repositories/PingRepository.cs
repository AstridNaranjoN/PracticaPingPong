using PingPong.Domain.Repositories;
using System.Collections.Generic;
using PingPong.Domain.Pong;

namespace PingPong.Infraestructure.Repositories
{
    public class PingRepository : IPingRepository
    {
        private List<PingPongMessage> _repository = new List<PingPongMessage>();

        public void Add(PingPongMessage message)
        {
            _repository.Add(message);
        }

        public List<PingPongMessage> GetAll()
        {
            return _repository;
        }
    }
}
