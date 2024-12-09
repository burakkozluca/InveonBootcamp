namespace BestPractise.API.Services;

using StackExchange.Redis;

public class CacheService
{
    private readonly IConnectionMultiplexer _connectionMultiplexer;

    public CacheService(IConnectionMultiplexer connectionMultiplexer)
    {
        _connectionMultiplexer = connectionMultiplexer;
    }

    public async Task<string> GetCacheValueAsync(string key)
    {
        var db = _connectionMultiplexer.GetDatabase();
        return await db.StringGetAsync(key);
    }

    public async Task SetCacheValueAsync(string key, string value, TimeSpan? expiry = null)
    {
        var db = _connectionMultiplexer.GetDatabase();
        await db.StringSetAsync(key, value, expiry);
    }
}
