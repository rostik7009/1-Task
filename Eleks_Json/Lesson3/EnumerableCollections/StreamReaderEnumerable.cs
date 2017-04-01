﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqP2.Collections
{
    public class StreamReaderEnumerable : IEnumerable<string>
    {
        private string _filePath;
        public StreamReaderEnumerable(string filePath)
        {
            _filePath = filePath;
        }

        // Must implement GetEnumerator, which returns a new StreamReaderEnumerator.
        public IEnumerator<string> GetEnumerator()
        {
            return new StreamReaderEnumerator(_filePath);
        }

        // Must also implement IEnumerable.GetEnumerator, but implement as a private method.
        private IEnumerator GetEnumerator1()
        {
            return this.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator1();
        }
    }

}
