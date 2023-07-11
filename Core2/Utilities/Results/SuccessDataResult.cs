using System;
using System.Collections.Generic;
using System.Text;

namespace Core2.Utilities.Results
{
    public class SuccessDataResult<T> : DataResults<T>
    {
        public SuccessDataResult(T data, string message) : base(data, message, true)
        {

        }
        public SuccessDataResult(T data) : base(data, true)
        {

        }   
        public SuccessDataResult(string message) : base(default, message,true)
        {

        }
        public SuccessDataResult() : base(default, true)
        {

        }
    }
}
