using PingPong.Domain.EventHandler;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using Newtonsoft.Json;
using System.Text;
using PingPong.Domain.Pong;

namespace PingPong.Infraestructure.MessageBroker
{
    public class MessageBrokerHandler : ICommunicationHandler
    {
        ConnectionFactory factory;
        IConnection connection;
        static IModel channel;
        static EventingBasicConsumer consumer;

        private event MessageArriveHandler _onMessageArrived;
        public MessageArriveHandler OnMessageArrived
        {
            get { return _onMessageArrived; }
            set { _onMessageArrived = value; }
        }

        public MessageBrokerHandler()
        {
            factory = new ConnectionFactory() { HostName = "localhost" };
            connection = factory.CreateConnection();
            channel = connection.CreateModel();
        }

        public void SendMessage(PingPongMessage message, string queue)
        {
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: queue,
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                var body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(message));

                channel.BasicPublish(exchange: "",
                                     routingKey: queue,
                                     basicProperties: null,
                                     body: body);
            }
        }
        
        public void ReceiveMessage(string queue)
        {
            channel.QueueDeclare(queue: queue,
                                 durable: false,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);

            consumer = new EventingBasicConsumer(channel);
            consumer.Received += (model, ea) =>
            {
                var body = ea.Body;
                var message = Encoding.UTF8.GetString(body);
                if (OnMessageArrived != null)
                {
                    OnMessageArrived(JsonConvert.DeserializeObject<Domain.Pong.PingPongMessage>(message));
                }

            };
            channel.BasicConsume(queue: queue,
                                 autoAck: true,
                                 consumer: consumer);
        }
    }
}
