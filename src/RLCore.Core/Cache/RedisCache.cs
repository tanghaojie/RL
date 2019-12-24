using Microsoft.Extensions.Configuration;
using RLCore.Configuration;
using RLCore.Web;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.Cache
{
    public class RedisCache : IRedisCache
    {
        public IDatabase Db { get; }
        private ConnectionMultiplexer Conn { get; }
        public RedisCache()
        {
            try
            {
                var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());
                var connStr = configuration.GetConnectionString(RLCoreConsts.RedisConnectionStringName);
                if (!string.IsNullOrWhiteSpace(connStr))
                {
                    Conn = ConnectionMultiplexer.Connect(connStr);
                    Db = Conn.GetDatabase();
                }
            }
            catch
            {
                Dispose();
                Conn = null;
                Db = null;
            }
        }


        public void Dispose()
        {
            Conn?.Close();
            Conn?.Dispose();
        }
    }
}
