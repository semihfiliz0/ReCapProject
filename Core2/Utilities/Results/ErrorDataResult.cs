using System;
using System.Collections.Generic;
using System.Text;

namespace Core2.Utilities.Results
{
    public class ErrorDataResult<T>:DataResults<T>
    {
        public ErrorDataResult(T data, bool success, string message) : base(data, message, false)
        {

        }
        public ErrorDataResult(T data) : base(data, false)
        {

        }
        public ErrorDataResult(string message) : base(default, message, false)
        {

        }
        public ErrorDataResult() : base(default, false)
        {

        }
    }
}
