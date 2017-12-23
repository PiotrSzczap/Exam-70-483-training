using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementClassHierarchy
{
    class ImplementStandardInterfaces<T> : IComparable, IEnumerable, IEnumerable<T>, IEquatable<T>, IDisposable
    {
        public int CompareTo(object obj) => throw new NotImplementedException();
        public void Dispose() => throw new NotImplementedException();
        public bool Equals(T other) => throw new NotImplementedException();
        public IEnumerator<T> GetEnumerator() => throw new NotImplementedException();
        IEnumerator IEnumerable.GetEnumerator() => throw new NotImplementedException();
    }

    
}
