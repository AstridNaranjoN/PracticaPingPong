using System.Threading.Tasks;

namespace PingPong.ApplicationServices.Ping
{
    public interface IPingMessageService
    {
        Task PingSendMessage();
    }
}
