using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Domain.Contract
{
    public interface IMessage
    {
        Guid Id { get; set; }
        String Message { get; set; }
    }
}
