using System;
using System.Collections.Generic;

namespace MRGGameTek.Helpers
{
    public enum CustomerType
    {
        mrgreen,
        redbet
    }
    public static class CustomerTypeConverter
    {
        public static T Convert<T> (Dictionary<string, string> dict)
        {
            Type type = typeof(T);
            var obj = Activator.CreateInstance(type);

            foreach (var kv in dict)
            {
                type.GetProperty(kv.Key).SetValue(obj, kv.Value);
            }
            return (T)obj;
        }
    }
}
