using System;

namespace ManipulateStrings
{
    class FormatableImplementation : IFormatProvider, IFormattable
    {
        public object GetFormat(Type formatType) => throw new NotImplementedException();
        public string ToString(string format, IFormatProvider formatProvider) => throw new NotImplementedException();
    }
}
