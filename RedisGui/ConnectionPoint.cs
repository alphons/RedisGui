using StackExchange.Redis;

namespace RedisGui;

public class ConnectionPoint
{
	public string ConnectionString { get; set; } = "127.0.0.1:6379";
	public ConnectionMultiplexer? Connection {  get; set; }
	public IServer? Server { get; set; }
	public IDatabase? Db { get; set; }
}
