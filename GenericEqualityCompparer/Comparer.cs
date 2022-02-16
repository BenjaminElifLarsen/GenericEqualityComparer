using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericEqualityCompparer
{
    internal class GenericComparer<T, U> : IEqualityComparer<T>
    {
        private readonly Func<T, U> _key;
        public GenericComparer( Func<T, U> key)
        {
            _key = key;
        }

        public bool Equals(T x, T y)
        {
            return _key(x).Equals(_key(y));
        }

        public int GetHashCode( T obj)
        {
            return _key(obj).GetHashCode();
        }
    }
}
