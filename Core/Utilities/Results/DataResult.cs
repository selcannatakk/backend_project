using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //base nin Dataresultı Result
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool success, string message) : base(success, message)                  //ctor contration
        {
            Data = data;
        }
        public DataResult(T data, bool success) : base(success)                  //ctor contration
        {
            Data = data;
        }
        public T Data { get; }
    }
}
