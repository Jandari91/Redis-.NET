using TestMqShared;

IAddress address = new Address("localhost", "6379");
TestMqShared.IConfiguration configuration = new TestMqShared.Configuration(address, "test-queue");
IConnectionFactory connectionFactory = new ConnectionFactory(configuration);
IQueue _queue = new Queue(connectionFactory);

while(true)
{
    string tmp = Console.ReadLine();
    var str = tmp.Split(' ');
    var command = str[0];
    var message = str[1];


    if (command == "I")
    {
        _queue.Enqueue(message);
    }
    else if (command == "D")
    {
        var result = _queue.Dequeue();
        Console.WriteLine(result);
    }
    else
    {
        _queue.Remove(message);
    }
}