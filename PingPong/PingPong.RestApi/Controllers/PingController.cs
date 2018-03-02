using PingPong.ApplicationServices.Ping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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

        public async Task Get()
        {
            await service.PingSendMessage();
        }
    }
}
