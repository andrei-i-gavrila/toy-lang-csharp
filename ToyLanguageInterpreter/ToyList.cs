using System;
using System.Collections.Generic;

namespace ToyLanguageInterpreter
{
    public class ToyList<T> : List<T>
    {
        public override string ToString()
        {
            return string.Join(" ", this);
        }
    }
}