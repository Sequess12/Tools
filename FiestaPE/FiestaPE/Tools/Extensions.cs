﻿using System;
using System.Collections.Generic;

namespace FiestaPE
{
    public static class Extensions
    {
        public static TValue GetOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> instance, TKey key, TValue defaultValue = default(TValue))
        {
            TValue result;
            return instance.TryGetValue(key, out result) ? result : defaultValue;
        }
    }
}
