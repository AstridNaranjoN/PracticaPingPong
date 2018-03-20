using PingPong.ApplicationServices.Ping;
using System.Threading.Tasks;
using System.Web.Http;

namespace PingPong.RestApi.Controllers
{
    public class PingController : ApiController
    {
        IPingMessageService service;

        public PingController(IPingMessageService service)
        {
            this.service = service;
        }

        public void Get()
        {
            service.PingSendMessage();
        }
    }
}
