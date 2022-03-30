using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMqShared
{


    public interface IConnectionFactory
    {
        public IConfiguration Configuration { get; set; }
        public IConnectionMultiplexer CreateConnection();
    }

    public class ConnectionFactory : IConnectionFactory
    {
        public IConfiguration Configuration { get; set; }

        public ConnectionFactory(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConnectionMultiplexer CreateConnection()
        {
            return ConnectionMultiplexer.Connect(Configuration.GetAddress());
        }
    }
}
