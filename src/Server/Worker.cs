using TestMqShared;

namespace Server
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IQueue _queue;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;

            IAddress address = new Address("localhost", "6379");
            TestMqShared.IConfiguration configuration = new TestMqShared.Configuration(address, "test-queue");
            IConnectionFactory connectionFactory = new ConnectionFactory(configuration);
            _queue = new Queue(connectionFactory);

        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var result = _queue.Dequeue();
                _logger.LogDebug(result);
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(10000, stoppingToken);
            }
        }
    }
}