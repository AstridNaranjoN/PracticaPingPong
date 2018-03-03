using PingPong.Domain.PingPong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.ApplicationServices.Pong
{
    public interface IPongMessageService
    {
        PingPongMeasure PongMeassures();
    }
}
