using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.Cache
{
    public class TrackCache : ITrackCache
    {
        private IMemoryCache _memoryCache;
        private IRedisCache _redisCache;
        public TrackCache(IMemoryCache memoryCache, IRedisCache redisCache)
        {
            _memoryCache = memoryCache;
            _redisCache = redisCache;
        }





        public void Dispose()
        {
            _memoryCache?.Dispose();
            _redisCache?.Dispose();
        }
    }
}
