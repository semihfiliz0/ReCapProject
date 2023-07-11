using System;
using System.Collections.Generic;
using System.Text;

namespace Core2.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success,string msg):this(success)
        {
            Message = msg;
        }


        public Result(bool success) 
        {
            Success = success;
        }

        
        public bool Success { get; }

        public string Message { get; }
    }
}
