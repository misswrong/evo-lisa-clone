using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvoLisaClone
{
    public static class DictionaryExtensions
    {
        public static bool TryAdd<TKey, TValue>(Dictionary<TKey, TValue> dictionary, TKey key, TValue value)
        {
            if (dictionary.Keys.Contains(key))
            {
                return false;
            }
            dictionary.Add(key, value);
            return true;
        }
    }
}
