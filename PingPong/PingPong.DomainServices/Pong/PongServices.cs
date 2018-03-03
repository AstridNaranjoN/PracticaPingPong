using PingPong.Domain.EventHandler;
using PingPong.Domain.Pong;
using PingPong.Domain.Repositories;
using System.Threading.Tasks;
using System;
using PingPong.Domain.PingPong;
using Newtonsoft.Json;

namespace PingPong.DomainServices.Pong
{
    public class PongServices : IPongServices
    {
        private event MessageEventHandler _onMessageStarted;

        private IUnitOfWork _unitOfWork;

        public MessageEventHandler OnMessageStarted
        {
            get { return _onMessageStarted; }
            set { _onMessageStarted = value; }
        }

        public PongServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void PongSendMessage(Guid id)
        {
            if (_onMessageStarted != null)
            {
                var message = new PingPongMessage("PONG_MESSAGE");
                _onMessageStarted(message, id.ToString());
                _unitOfWork.PongRepository.Add(message);
            }
        }

        public async void PongMessageReceived(PingPongMessage message)
        {
            _unitOfWork.PingRepository.Add(message);
            await Task.Delay(2000);
            PongSendMessage(message.Id);

        }

        public PingPongMeasure PongMeassures()
        {
            return new PingPongMeasure(_unitOfWork.PingRepository.GetAll().Count, _unitOfWork.PongRepository.GetAll().Count);
        }
    }
}
