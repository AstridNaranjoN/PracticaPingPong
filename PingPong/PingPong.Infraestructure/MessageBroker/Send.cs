using PingPong.Domain.Contract;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Infraestructure.MessageBroker
{
    public class Send
    {
        public static void SendMessage(IMessage message, string queue)
        {
            //var factory = new ConnectionFactory() { HostName = "localhost" };
            //using (var connection = factory.CreateConnection())
            //using (var channel = connection.CreateModel())
            //{
            //    channel.QueueDeclare(queue: queue,
            //                         durable: false,
            //                         exclusive: false,
            //                         autoDelete: false,
            //                         arguments: null);

            //    //string message = "Hello World!";
            //    var body = Encoding.UTF8.GetBytes(message);

            //    channel.BasicPublish(exchange: "",
            //                         routingKey: "hello",
            //                         basicProperties: null,
            //                         body: body);
            //}
        }
    }
}
