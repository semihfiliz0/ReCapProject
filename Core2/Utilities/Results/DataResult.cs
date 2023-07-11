using System;
using System.Collections.Generic;
using System.Text;

namespace Core2.Utilities.Results
{
    public class DataResults<T> : Result, IDataResult<T>
    {
        public DataResults(T data, string message, bool success) : base(success, message)
        {
            Data = data;
        }
        public DataResults(T data, bool success) : base(success)
        {
            Data = data;
        }

        public T Data { get; }
    }
}
