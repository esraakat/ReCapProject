using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        T Get<T>(String key);
        Object Get(string key);
        void Add(string key, object value, int duration);
        bool IsAdd(string key); //bellekte böyle bir cache değeri var mı?
        void Remove(string key);
        void RemoveByPattern(string pattern);
    }
}
