using tp.SimpleChat.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace tp.SimpleChat.Core.Business_Interface.ServiceQuery
{
    public interface IMessageServiceQuery
    {
        IEnumerable<Message> GetAll();
        IEnumerable<Message> GetReceivedMessages(string userId);
    }
}
