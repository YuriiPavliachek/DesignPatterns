using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Bridge
{
    public abstract class Message
    {
        protected IMessageSender _sender;
        protected Message(IMessageSender sender) { this._sender = sender; }
        public abstract void Send(string content);
    }
    public class UrgentMessage : Message
    {
        public UrgentMessage(IMessageSender sender) : base(sender) { }

        public override void Send(string content)
        {
            Console.WriteLine("Urgent Message:");
            _sender.SendMessage(content);
        }
    }
    public class NormalMessage : Message
    {
        public NormalMessage(IMessageSender sender) : base(sender) { }
        public override void Send(string content)
        {
            Console.WriteLine("Normal Message:");
            _sender.SendMessage(content);
        }
    }
}
