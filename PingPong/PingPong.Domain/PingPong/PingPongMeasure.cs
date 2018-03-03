using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Domain.PingPong
{
    public class PingPongMeasure
    {
        public int PingMessagesCount { get; private set; }
        public int PongMessagesCount { get; private set; }

        public PingPongMeasure(int pingMessagesCount, int pongMessagesCount)
        {
            PingMessagesCount = pingMessagesCount;
            PongMessagesCount = pongMessagesCount;
        }
    }
}