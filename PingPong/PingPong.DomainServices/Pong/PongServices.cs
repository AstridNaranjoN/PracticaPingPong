using PingPong.Domain.EventHandler;
using PingPong.Domain.Pong;
using PingPong.Domain.Repositories;
using System.Threading.Tasks;
using System;

namespace PingPong.DomainServices.Pong
{
    public class PongServices: IPongServices
    {
        private event MessageEventHandler _onMessageStarted;

        private IPingRepository pingRepository;

        public MessageEventHandler OnMessageStarted
        {
            get { return _onMessageStarted; }
            set { _onMessageStarted = value; }
        }

        public PongServices(IPingRepository ping)
        {
            pingRepository = ping;
        }

        public void PongSendMessage(Guid id)
        {
            if (_onMessageStarted != null)
            {
                _onMessageStarted(new PingPongMessage("PONG_MESSAGE"), id.ToString());
            }
        }

        public async void PongMessageReceived(PingPongMessage message)
        {
            pingRepository.Add(message);
            await Task.Delay(2000);
            PongSendMessage(message.Id);
        }

        public string PongMeassures()
        {
            return pingRepository.GetAll().Count.ToString();
        }
    }
}
