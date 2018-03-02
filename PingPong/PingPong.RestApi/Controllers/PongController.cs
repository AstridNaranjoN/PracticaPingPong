using PingPong.ApplicationServices.Pong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PingPong.RestApi.Controllers
{
    public class PongController : ApiController
    {
        IPongMessageService service;

        public PongController(IPongMessageService service)
        {
            this.service = service;
        }

        public string Get()
        {
            return service.PongMeassures();
        }
    }
}
