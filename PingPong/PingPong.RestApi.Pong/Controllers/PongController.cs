using PingPong.ApplicationServices.Pong;
using PingPong.Domain.PingPong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PingPong.RestApi.Pong.Controllers
{
    public class PongController : ApiController
    {
        IPongMessageService pongMessageService;

        public PongController(IPongMessageService pongmessage)
        {
            pongMessageService = pongmessage;

        }

        public PingPongMeasure Get()
        {
            return pongMessageService.PongMeassures();
        }
    }
}
