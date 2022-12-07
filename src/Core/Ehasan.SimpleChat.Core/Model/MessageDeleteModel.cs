using tp.SimpleChat.Core.Entities;
using tp.SimpleChat.Core.Enums;

namespace tp.SimpleChat.Core.Model
{
    public class MessageDeleteModel
    {
        public string DeleteType { get; set; }
        public Message Message { get; set; }
        public string DeletedUserId { get; set; }
    }
}
