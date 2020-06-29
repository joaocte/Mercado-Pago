using MercadoPago.Exceptions;
using Microsoft.Extensions.Caching.Memory;
using System;

namespace MercadoPago.Core
{
    /// <summary>
    /// Class for managing cached resources.
    /// </summary>
    public class MPCache
    {
        private static IMemoryCache _cache;

        /// <summary>
        /// Adds a response to the cache structure.
        /// </summary>
        /// <param name="key">Key representing the URL.</param>
        /// <param name="response">Response representing the response of the given URL parameter.</param>
        public static void AddToCache(string key, MPAPIResponse response)
        {
            try
            {
                var opcoesDoCache = new MemoryCacheEntryOptions()
                {
                    AbsoluteExpiration = DateTime.MaxValue,
                    Priority = CacheItemPriority.Normal
                };

                _cache.Set(key, response, opcoesDoCache);
            }
            catch (Exception ex)
            {
                throw new MPException("An error has occured in the cache structure (ADD): " + ex.Message);
            }
        }

        /// <summary>
        /// Retrieves a cached response from cache structure.
        /// </summary>
        /// <param name="key">Key that will return its associated value.</param>
        /// <returns>Cached response.</returns>
        public static MPAPIResponse GetFromCache(string key)
        {
            try
            {
                MPAPIResponse value;

                _cache.TryGetValue(key, out value);

                return value;
            }
            catch (Exception ex)
            {
                throw new MPException("An error has occured in the cache structure (GET): " + ex.Message);
            }
        }

        /// <summary>
        /// Remove a specified item from cache.
        /// </summary>
        /// <param name="key">Key of the element to remove from cache.</param>
        public static void RemoveFromCache(string key)
        {
            try
            {
                MPAPIResponse value;
                var possuiCache = _cache.TryGetValue(key, out value);

                if (possuiCache)
                    _cache.Remove(key);
            }
            catch (Exception ex)
            {
                throw new MPException("An error has occured in the cache structure (REMOVE): " + ex.Message);
            }
        }
    }
}