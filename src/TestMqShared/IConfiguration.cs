using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMqShared
{
    public interface IConfiguration
    {
        IAddress Address { get; set; }
        string QueueName { get; set; }

        public string GetQueueName();
        public string GetAddress();

    }

    public record Configuration : IConfiguration
    {
        public IAddress Address { get; set; }

        public string QueueName { get; set; }

        public Configuration(IAddress address, string queueName)

        {
            Address = address;
            QueueName = queueName;
        }

        public string GetQueueName()
        {
            if (QueueName == null)
                throw new NullReferenceException();
            return QueueName;
        }

        public string GetAddress()
        {
            if (Address == null)
                throw new NullReferenceException();
            return Address.Get();
        }
    }
}
