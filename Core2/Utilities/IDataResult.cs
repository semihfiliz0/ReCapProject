using Core2.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core2.Utilities
{
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
