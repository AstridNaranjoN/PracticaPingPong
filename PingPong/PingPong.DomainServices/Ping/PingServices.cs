using PingPong.Domain.EventHandler;
using PingPong.Domain.Pong;
using System;
using System.Threading.Tasks;

namespace PingPong.DomainServices.Ping
{
    public class PingServices : IPingServices
    {
        private event MessageEventHandler _onMessageStarted;
        public MessageEventHandler OnMessageStarted
        {
            get { return _onMessageStarted; }
            set { _onMessageStarted = value; }
        }

        public Guid PingSendMessage()
        {
            if (_onMessageStarted != null)
            {
                PingPongMessage message = new PingPongMessage("PING_MESSAGE");
                _onMessageStarted(message, "pingpongQueue");
                return message.Id;
            }

            return new Guid();
        }

        public void PingMessageReceived(PingPongMessage message)
        {
            replyMessage = message.Message;
        }


        private string replyMessage = string.Empty;
        public async Task WaitReply()
        {
            while (replyMessage == string.Empty)
            {
                await Task.Delay(500);
            }
            replyMessage = string.Empty;
        }
    }
}
