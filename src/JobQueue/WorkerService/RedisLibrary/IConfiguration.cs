using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisLibrary
{
    public interface IConfiguration
    {
        IAddress Address { get; set; }
        string QueueName { get; set; }

        public string GetQueueName();
        public string GetAddress();

    }
}
